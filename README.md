# DPAPI Tester

This application tests if you're affected by a problem caused by the latest Windows update.

## How to use

Use [GitLoad](https://gitload.net/AyrA/DPAPITest) to download the latest version.
Run it and follow the instructions.

## Problem Description

The problem with the broken API manifests itself in various ways:

- Some applications, including Outlook and some Google products, forget passwords
- Network drives that require authentication are sometimes no longer working properly after a restart
- VPN connections seemingly broken without reason
- Some applications report corrupt configuration files (the mega.nz client for example)
- Unable to use personal certificates in some applications, for example S/MIME in Outlook

## Solution

A solution from Microsoft is currently not available, but I was able to fix it on my machine using a registry key.

1. ﻿Open the registry editor
2. Go to `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography\Protect\Providers\df9d8cd0-1501-11d1-8c7a-00c04fc297eb`
3. ﻿Create a DWORD value named `ProtectionPolicy` and set it to `1`
4. Reboot

If you prefer the command line (run as admin):

    reg add HKLM\SOFTWARE\Microsoft\Cryptography\Protect\Providers\df9d8cd0-1501-11d1-8c7a-00c04fc297eb /v ProtectionPolicy /t REG_DWORD /d 1

The test tool should now report that everything is OK and passwords should be stored again, even across restarts.
I'm not sure why this key is suddenly necessary.
I have another Windows 10 machine that works fine without it﻿.



A support topic has been opened, please add a post there so we can get some attention.
[You can visit it here](https://answers.microsoft.com/en-us/windows/forum/windows_10-security/data-protection-api-dpapi-seemingly-broken/3f37f1dc-2e74-4ee1-8de8-84a1923082a6)
