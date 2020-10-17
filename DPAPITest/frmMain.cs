using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics;

namespace DPAPITest
{
    public partial class frmMain : Form
    {
        private struct FileData
        {
            public byte[] MachineEncrypted;
            public byte[] UserEncrypted;
            public string[] KeyFiles;
            public string UserSID;
        }

        private static readonly byte[] Protected = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static readonly string Dir = Path.GetDirectoryName(Application.ExecutablePath);

        private static string CryptoDir
        {
            get
            {
                var temp = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return Path.Combine(temp, "Microsoft", "Protect");
            }
        }
        private static string TestFile
        {
            get
            {
                return Path.Combine(Dir, CRYPTO_FILE);
            }
        }
        private static string StartupLink
        {
            get
            {
                var temp = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                return Path.Combine(temp, "Crypto API Test.lnk");
            }
        }

        private const string CRYPTO_FILE = "test.crypt";

        private const string TEST_PASS = "OK";
        private const string TEST_FAIL = "Problem";

        private bool DeleteOnExit = false;

        public frmMain()
        {
            InitializeComponent();
            if (btnStep3.Enabled = File.Exists(TestFile))
            {
                if (Environment.GetCommandLineArgs().Contains("/step3"))
                {
                    btnStep1.Enabled = false;
                }
            }
            Text += " " + Application.ProductVersion;
            AddAutostart();
        }

        private static string GetUserSid()
        {
            return Directory
                .GetDirectories(CryptoDir)
                .Select(Path.GetFileName)
                .FirstOrDefault(m => m.StartsWith("S-"));
        }

        private string[] GetKeyFiles()
        {
            return Directory.GetFiles(Path.Combine(CryptoDir, GetUserSid()))
                .Select(Path.GetFileName)
                .OrderBy(m => m)
                .ToArray();
        }

        private static FileData ReadCryptoFile()
        {
            try
            {
                using (var FS = File.OpenRead(TestFile))
                {
                    using (var BR = new BinaryReader(FS))
                    {
                        var Ret = new FileData
                        {
                            MachineEncrypted = BR.ReadBytes(BR.ReadInt32()),
                            UserEncrypted = BR.ReadBytes(BR.ReadInt32())
                        };
                        var FileCount = BR.ReadInt32();
                        Ret.KeyFiles = Enumerable
                            .Range(0, FileCount)
                            .Select(m => BR.ReadString())
                            .ToArray();
                        Ret.UserSID = BR.ReadString();
                        return Ret;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to read the crypto data. Reason: " + ex.Message);
            }
            return default;
        }

        private static bool WriteCryptoFile(FileData D)
        {
            if (File.Exists(TestFile) && MessageBox.Show("The crypto file already exists. Do you really want to start again and overwrite it?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return false;
            }
            try
            {
                using (var FS = File.Create(TestFile))
                {
                    using (var BW = new BinaryWriter(FS))
                    {
                        BW.Write(D.MachineEncrypted.Length);
                        BW.Write(D.MachineEncrypted);
                        BW.Write(D.UserEncrypted.Length);
                        BW.Write(D.UserEncrypted);
                        BW.Write(D.KeyFiles.Length);
                        foreach (var s in D.KeyFiles)
                        {
                            BW.Write(s);
                        }
                        BW.Write(D.UserSID);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write crypto data. Reason: " + ex.Message);
                return false;
            }
        }

        private static void AddAutostart()
        {
            DeleteAutostart();
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("DP API Test");
            link.SetPath(Application.ExecutablePath);
            link.SetArguments("/step3");

            // save it
            IPersistFile file = (IPersistFile)link;
            file.Save(StartupLink, false);
        }

        private static void DeleteAutostart()
        {
            try
            {
                File.Delete(StartupLink);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Removal of {StartupLink} failed. Reason: {ex.Message}");
            }
        }

        private static int RestartComputer()
        {
            var psi = new ProcessStartInfo("shutdown.exe", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            using (var P = Process.Start(psi))
            {
                P.WaitForExit();
                return P.ExitCode;
            }
        }

        private void SetLabel(Label L, string Text, bool Success)
        {
            if (Success)
            {
                L.BackColor = Color.LightGreen;
                L.ForeColor = Color.Black;
            }
            else
            {
                L.BackColor = Color.Red;
                L.ForeColor = Color.White;
            }
            L.Enabled = true;
            L.Font = new Font(L.Font, FontStyle.Bold);
            L.Text = Text;
        }

        private void btnStep1_Click(object sender, EventArgs e)
        {
            var D = new FileData()
            {
                MachineEncrypted = ProtectedData.Protect(Protected, null, DataProtectionScope.LocalMachine),
                UserEncrypted = ProtectedData.Protect(Protected, null, DataProtectionScope.CurrentUser),
                KeyFiles = GetKeyFiles(),
                UserSID = GetUserSid()
            };
            if (WriteCryptoFile(D))
            {
                MessageBox.Show("Test data has been written. Please continue with step 2", "DP Test data written", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStep1.Enabled = false;
                btnStep2.Enabled = true;
                btnStep3.Enabled = false;
            }
            else
            {
                btnStep2.Enabled = false;
                btnStep3.Enabled = File.Exists(Path.Combine(Dir, CRYPTO_FILE));
            }
        }

        private void btnStep2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"A restart is required. Please save all unsaved work before continuing.
After you're logged back into your account, this application will automatically continue.
If it does not (because of your anti virus for example) you can launch it again yourself to continue.

Restart now?", "Computer Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                AddAutostart();
                if (RestartComputer() != 0)
                {
                    MessageBox.Show("Unable to restart your computer. Please try manually from the start menu.", "Restart failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStep3_Click(object sender, EventArgs e)
        {
            var Data = ReadCryptoFile();
            DeleteAutostart();
            btnStep3.Enabled = false;
            if (Data.MachineEncrypted == null || Data.UserEncrypted == null)
            {
                if (File.Exists(TestFile))
                {
                    MessageBox.Show("The file seems to be corrupt. Please try again using Step 1", "File data missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnStep1.Enabled = true;
                return;
            }
            if (GetUserSid() != Data.UserSID)
            {
                MessageBox.Show("The file seems to be for a different user. Please try again using Step 1, or switch to the user that created this file.", "File data missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStep1.Enabled = true;
                return;
            }
            bool OkMachine = false;
            bool OkUser = false;
            bool SameKeys = GetKeyFiles().Length == Data.KeyFiles.Length;
            try
            {
                ProtectedData.Unprotect(Data.MachineEncrypted, null, DataProtectionScope.LocalMachine);
                OkMachine = true;
            }
            catch (Exception ex)
            {
                OkMachine = false;
                Debug.WriteLine($"Decryption of machine data failed. Reason: {ex.Message}", "Decryption failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                ProtectedData.Unprotect(Data.UserEncrypted, null, DataProtectionScope.CurrentUser);
                OkUser = true;
            }
            catch (Exception ex)
            {
                OkUser = false;
                Debug.WriteLine($"Decryption of user data failed. Reason: {ex.Message}", "Decryption failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (OkMachine && OkUser && SameKeys)
            {
                MessageBox.Show("Everything seems to be in order. Your problem is not related to a broken DP API", "All OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetLabel(lblOkGeneral, TEST_PASS, true);
                DeleteOnExit = true;
                btnReport.Text = "Open support topic";
            }
            else
            {
                SetLabel(lblOkGeneral, TEST_FAIL, false);
                btnReport.Text = "Report to Microsoft";
            }
            btnReport.Enabled = true;

            if (OkMachine)
            {
                SetLabel(lblOkMachine, TEST_PASS, true);
            }
            else
            {
                SetLabel(lblOkMachine, TEST_FAIL, false);
            }

            if (OkUser)
            {
                SetLabel(lblOkUser, TEST_PASS, true);
            }
            else
            {
                SetLabel(lblOkUser, TEST_FAIL, false);
            }

            if (SameKeys)
            {
                SetLabel(lblOkFiles, TEST_PASS, true);
            }
            else
            {
                SetLabel(lblOkFiles, TEST_FAIL, false);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (DeleteOnExit || MessageBox.Show(@"To get Microsoft to fix this problem, we need enough people that report it.
Clicking [YES] will open a support topic where you can add, that you're affected by this problem too.", "Open support topic", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start("https://answers.microsoft.com/en-us/windows/forum/all/data-protection-api-dpapi-seemingly-broken/3f37f1dc-2e74-4ee1-8de8-84a1923082a6");
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DeleteOnExit)
            {
                try
                {
                    File.Delete(TestFile);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Unable to delete the test file {TestFile}");
                }
            }
        }
    }
}
