namespace DPAPITest
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntro = new System.Windows.Forms.Label();
            this.gbStep1 = new System.Windows.Forms.GroupBox();
            this.btnStep1 = new System.Windows.Forms.Button();
            this.gbStep2 = new System.Windows.Forms.GroupBox();
            this.btnStep2 = new System.Windows.Forms.Button();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.gbStep3 = new System.Windows.Forms.GroupBox();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.btnStep3 = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOkMachine = new System.Windows.Forms.Label();
            this.lblOkUser = new System.Windows.Forms.Label();
            this.lblOkFiles = new System.Windows.Forms.Label();
            this.lblOkGeneral = new System.Windows.Forms.Label();
            this.gbStep1.SuspendLayout();
            this.gbStep2.SuspendLayout();
            this.gbStep3.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntro.AutoEllipsis = true;
            this.lblIntro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntro.Location = new System.Drawing.Point(12, 9);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(777, 39);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "This application tests if your data protection API (DP API) was broken by the lat" +
    "est Windows 10 update. Please perform the steps below as instructed";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStep1
            // 
            this.gbStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStep1.Controls.Add(this.lblStep1);
            this.gbStep1.Controls.Add(this.btnStep1);
            this.gbStep1.Location = new System.Drawing.Point(12, 51);
            this.gbStep1.Name = "gbStep1";
            this.gbStep1.Size = new System.Drawing.Size(777, 56);
            this.gbStep1.TabIndex = 1;
            this.gbStep1.TabStop = false;
            this.gbStep1.Text = "Step 1";
            // 
            // btnStep1
            // 
            this.btnStep1.Location = new System.Drawing.Point(6, 19);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(166, 23);
            this.btnStep1.TabIndex = 2;
            this.btnStep1.Text = "Prepare data using the DP API";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.btnStep1_Click);
            // 
            // gbStep2
            // 
            this.gbStep2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStep2.Controls.Add(this.lblStep2);
            this.gbStep2.Controls.Add(this.btnStep2);
            this.gbStep2.Location = new System.Drawing.Point(12, 113);
            this.gbStep2.Name = "gbStep2";
            this.gbStep2.Size = new System.Drawing.Size(777, 56);
            this.gbStep2.TabIndex = 3;
            this.gbStep2.TabStop = false;
            this.gbStep2.Text = "Step 2";
            // 
            // btnStep2
            // 
            this.btnStep2.Enabled = false;
            this.btnStep2.Location = new System.Drawing.Point(6, 19);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(166, 23);
            this.btnStep2.TabIndex = 4;
            this.btnStep2.Text = "Restart the computer";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // lblStep1
            // 
            this.lblStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStep1.AutoEllipsis = true;
            this.lblStep1.Location = new System.Drawing.Point(178, 24);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(593, 18);
            this.lblStep1.TabIndex = 5;
            this.lblStep1.Text = "This will encrypt a few bytes and also makes note of the current state of the DP " +
    "API";
            // 
            // lblStep2
            // 
            this.lblStep2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStep2.AutoEllipsis = true;
            this.lblStep2.Location = new System.Drawing.Point(178, 24);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(593, 18);
            this.lblStep2.TabIndex = 6;
            this.lblStep2.Text = "Simply logging out and back in is usually not enough. A full restart is required." +
    "";
            // 
            // gbStep3
            // 
            this.gbStep3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStep3.Controls.Add(this.lblStep3);
            this.gbStep3.Controls.Add(this.btnStep3);
            this.gbStep3.Location = new System.Drawing.Point(12, 175);
            this.gbStep3.Name = "gbStep3";
            this.gbStep3.Size = new System.Drawing.Size(777, 56);
            this.gbStep3.TabIndex = 7;
            this.gbStep3.TabStop = false;
            this.gbStep3.Text = "Step 3";
            // 
            // lblStep3
            // 
            this.lblStep3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStep3.AutoEllipsis = true;
            this.lblStep3.Location = new System.Drawing.Point(178, 24);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(593, 18);
            this.lblStep3.TabIndex = 6;
            this.lblStep3.Text = "Verify that the encrypted data is still readable.";
            // 
            // btnStep3
            // 
            this.btnStep3.Enabled = false;
            this.btnStep3.Location = new System.Drawing.Point(6, 19);
            this.btnStep3.Name = "btnStep3";
            this.btnStep3.Size = new System.Drawing.Size(166, 23);
            this.btnStep3.TabIndex = 4;
            this.btnStep3.Text = "Try to use encrypted data";
            this.btnStep3.UseVisualStyleBackColor = true;
            this.btnStep3.Click += new System.EventHandler(this.btnStep3_Click);
            // 
            // gbReport
            // 
            this.gbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReport.Controls.Add(this.label4);
            this.gbReport.Controls.Add(this.label3);
            this.gbReport.Controls.Add(this.label2);
            this.gbReport.Controls.Add(this.lblOkGeneral);
            this.gbReport.Controls.Add(this.lblOkFiles);
            this.gbReport.Controls.Add(this.lblOkUser);
            this.gbReport.Controls.Add(this.lblOkMachine);
            this.gbReport.Controls.Add(this.label1);
            this.gbReport.Controls.Add(this.btnReport);
            this.gbReport.Location = new System.Drawing.Point(12, 237);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(777, 140);
            this.gbReport.TabIndex = 8;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Report";
            // 
            // btnReport
            // 
            this.btnReport.Enabled = false;
            this.btnReport.Location = new System.Drawing.Point(6, 19);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(166, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Waiting for \"Step 3\"";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Decrypting machine data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Decrypting user data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key file count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Overall result:";
            // 
            // lblOkMachine
            // 
            this.lblOkMachine.AutoSize = true;
            this.lblOkMachine.Enabled = false;
            this.lblOkMachine.Location = new System.Drawing.Point(312, 24);
            this.lblOkMachine.Name = "lblOkMachine";
            this.lblOkMachine.Size = new System.Drawing.Size(102, 13);
            this.lblOkMachine.TabIndex = 9;
            this.lblOkMachine.Text = "Waiting for \"Step 3\"";
            // 
            // lblOkUser
            // 
            this.lblOkUser.AutoSize = true;
            this.lblOkUser.Enabled = false;
            this.lblOkUser.Location = new System.Drawing.Point(312, 50);
            this.lblOkUser.Name = "lblOkUser";
            this.lblOkUser.Size = new System.Drawing.Size(102, 13);
            this.lblOkUser.TabIndex = 9;
            this.lblOkUser.Text = "Waiting for \"Step 3\"";
            // 
            // lblOkFiles
            // 
            this.lblOkFiles.AutoSize = true;
            this.lblOkFiles.Enabled = false;
            this.lblOkFiles.Location = new System.Drawing.Point(312, 76);
            this.lblOkFiles.Name = "lblOkFiles";
            this.lblOkFiles.Size = new System.Drawing.Size(102, 13);
            this.lblOkFiles.TabIndex = 9;
            this.lblOkFiles.Text = "Waiting for \"Step 3\"";
            // 
            // lblOkGeneral
            // 
            this.lblOkGeneral.AutoSize = true;
            this.lblOkGeneral.Enabled = false;
            this.lblOkGeneral.Location = new System.Drawing.Point(312, 102);
            this.lblOkGeneral.Name = "lblOkGeneral";
            this.lblOkGeneral.Size = new System.Drawing.Size(102, 13);
            this.lblOkGeneral.TabIndex = 9;
            this.lblOkGeneral.Text = "Waiting for \"Step 3\"";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 389);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbStep3);
            this.Controls.Add(this.gbStep2);
            this.Controls.Add(this.gbStep1);
            this.Controls.Add(this.lblIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "DP API Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.gbStep1.ResumeLayout(false);
            this.gbStep2.ResumeLayout(false);
            this.gbStep3.ResumeLayout(false);
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.GroupBox gbStep1;
        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.GroupBox gbStep2;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Button btnStep2;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.GroupBox gbStep3;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Button btnStep3;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOkGeneral;
        private System.Windows.Forms.Label lblOkFiles;
        private System.Windows.Forms.Label lblOkUser;
        private System.Windows.Forms.Label lblOkMachine;
        private System.Windows.Forms.Label label1;
    }
}

