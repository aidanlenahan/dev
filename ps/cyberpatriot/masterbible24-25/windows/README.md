# Windows CyberPatriot Image Hardening

This guide provides a step-by-step approach to hardening a Windows CyberPatriot image for security. Each step includes specific tasks and scripts aimed at improving the security posture of the system. Below is an overview of the steps, resources, and tasks involved.

[Source Document](https://docs.google.com/document/d/e/2PACX-1vT2zjA8CaPWgSmMfjuAQXL91jd2ioXfFl3J_zvzhtXNg7lFbNFENRbakHlqrodOCvrJ8hJ_O5YRnCyt/pub)

## Step 0 - Initial Setup
### Tasks:
- **Create Required Groups:** Set up the necessary user groups.
- **Create Required Users:** Create the required user accounts.
- **Install Necessary Programs:** Ensure all required software is installed on the system.

---

## [Step 1 - Initialization](https://raw.githubusercontent.com/aidanlenahan/dev/refs/heads/main/ps/cyberpatriot/masterbible24-25/windows/step1.ps1)
### Tasks:
1. **Set Script Execution Policy:**
   - Make `.ps1` scripts executable with the command:
     ```powershell
     Set-ExecutionPolicy Unrestricted -Scope LocalMachine
     ```
2. **View Hidden Files:**
   - Enable the visibility of all hidden files.
3. **Enable File Extension Editing:**
   - Allow file extensions to be editable.
4. **Answer Forensics Questions:**
   - Complete any provided forensics questions.

---

## Step 2 - Forensics Tools
### Recommended Resources:
- **CyberChef**
- **ChatGPT**
- **Cryptii**
- **GitHub Copilot**

---

## [Step 3 - Basic Security](https://raw.githubusercontent.com/aidanlenahan/dev/refs/heads/main/ps/cyberpatriot/masterbible24-25/windows/step3.ps1)
### Tasks:
1. **Enable Firewall:**
   - Ensure the firewall is turned on.
2. **Enable Real-Time Protection:**
   - Verify that real-time protection is enabled.
3. **Remove Bad Shares:**
   - Remove any unnecessary network shares (except `ADMIN$`, `IPC$`, and `C$`).
4. **Remove Unwanted Software:**
   - Uninstall unnecessary or insecure software such as:
     - Wireshark
     - CCleaner
     - Npcap
     - PC Cleaner
     - Network Stumbler
     - L0phtCrack
     - JDownloader
     - Minesweeper or any other games.
5. **Remove Unwanted Files:**
   - Remove unnecessary media and document files, including:
     - Audio/Video: mp3, mp4, mov, wav, aac, flac, mkv
     - Images: png, jpeg, jpg, gif, tiff, bmp
     - Documents: pdf, doc, docx
6. **Configure In-Browser Security:**
   - Use the most secure DNS.
   - Ensure that HTTPS is always used.

---

## [Step 4 - Users and Groups](https://raw.githubusercontent.com/aidanlenahan/dev/refs/heads/main/ps/cyberpatriot/masterbible24-25/windows/step4.ps1)
### Tasks:
1. **Disable Unauthorized Users:**
   - Use **Computer Management** to disable any unauthorized users.
2. **Verify Admin Group Settings:**
   - Ensure the "Password Never Expires" option is turned **OFF** for all admin users.
3. **Disable Guest and Administrator Accounts:**
   - Make sure both the **Guest** account and **Administrator** account are disabled.

##### How to execute this script:
1. **First run the script titled ‘step4.ps1’.** It will create a template file in the same directory called ‘authusers.txt’.
2. **Use this ChatGPT prompt to format the user list from the readme into the proper format that the script will recognize.**
3. Paste the readme user list to the bottom of the prompt and **enter it into ChatGPT.**
4. **Copy ChatGPT’s output and paste it into “authusers.txt”**
5. **Run the script called ‘step4.ps1’ once more.**
6. Changes can be seen in ‘diagnostics4.txt’

---

## Step 5 - Services
### Tasks:
- Manage and disable unnecessary services that may pose security risks.

---

## License
This guide is designed for use in CyberPatriot competitions and may be adapted for other cybersecurity competitions or educational purposes.
