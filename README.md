# DPAPI Tester

This application tests if you're affected by a problem caused by the latest Windows update.

## How to use

Use [GitLoad](https://gitload.net/AyrA/DPAPITest) to download the latest version.
Run it and follow the instructions.

## Problem Description

The problem with the broken API manifests itself in various ways:

- Some applications, including Outlook and some Google products, forget passwords
- Network drives that require authentication are no longer working properly after a restart
- VPN connections seemingly broken without reason

## Solution

A solution is currently not available.
If you still can, you can try to revert your system to before the update was installed.
Because of the nature of the problem, it's very likely to appear again if you install the update.
It's also likely you did not notice the problem for so long, that you can't revert anymore,
or reverting would break too many applications by now.

A support topic has been opened, please add a post there so we can get some attention.
[You can visit it here](https://answers.microsoft.com/en-us/windows/forum/windows_10-security/data-protection-api-dpapi-seemingly-broken/3f37f1dc-2e74-4ee1-8de8-84a1923082a6)

### New Accounts

As a way to fix the problem, you can try to create a new account,
then try the test application there.
On ony of my machines, the problem doesn't seems to propagate to newly created accounts.
