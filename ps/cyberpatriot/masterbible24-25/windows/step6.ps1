# This script completes step 6 of Windows in Cyberpatriot
# https://docs.google.com/document/d/e/2PACX-1vT2zjA8CaPWgSmMfjuAQXL91jd2ioXfFl3J_zvzhtXNg7lFbNFENRbakHlqrodOCvrJ8hJ_O5YRnCyt/pub

# Define the log file path
$logFile = "$PSScriptRoot\diagnostics6.txt"

# Clear the log file at the start
Clear-Content $logFile -ErrorAction SilentlyContinue

# Function to log messages with formatting
function Log-Message {
    param (
        [string]$message
    )
    Add-Content -Path $logFile -Value "----------------------------"
    Add-Content -Path $logFile -Value $message
    Add-Content -Path $logFile -Value "----------------------------`n"
}

# Option 1: Disable ALL RDP settings
function Disable-RDPSettings {
    Log-Message "Disabling ALL RDP settings"

    # Disabling RDP settings
    Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server' -Name "fDenyTSConnections" -Value 1
    Set-Service -Name TermService -StartupType Disabled
    Stop-Service -Name TermService -Force

    Log-Message "All RDP settings have been disabled."
}

# Option 2: Look for all open ports aside from the default
function Check-OpenPorts {
    Log-Message "Checking for open ports aside from the default"

    # Finding open ports other than common defaults (e.g., 80, 443, 3389)
    $openPorts = netstat -an | Select-String "LISTENING" | Select-String -NotMatch "80|443|3389"
    if ($openPorts) {
        $openPorts | ForEach-Object { Log-Message "Open port found: $_" }
    } else {
        Log-Message "No unusual open ports found."
    }
}

# Option 3: Enable automatic Windows updates through Group Policy
function Enable-AutoWindowsUpdates {
    Log-Message "Enabling automatic Windows updates through Group Policy"

    # Setting Windows Update policy
    Set-ItemProperty -Path 'HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU' -Name "NoAutoUpdate" -Value 0
    New-ItemProperty -Path 'HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU' -Name "AUOptions" -Value 4 -PropertyType DWORD -Force

    Log-Message "Automatic Windows updates have been enabled through Group Policy."
}

# Main script logic
Write-Host "Select an option:"
Write-Host "1: Disable ALL RDP settings"
Write-Host "2: Look for all open ports aside from the default"
Write-Host "3: Enable automatic Windows updates through Group Policy"
Write-Host "A: Perform ALL actions"
$choice = Read-Host "Enter your choice (1, 2, 3, A)"

switch ($choice) {
    "1" { Disable-RDPSettings }
    "2" { Check-OpenPorts }
    "3" { Enable-AutoWindowsUpdates }
    "A" {
        Disable-RDPSettings
        Check-OpenPorts
        Enable-AutoWindowsUpdates
    }
    default { Write-Host "Invalid option selected" }
}

Write-Host "Actions completed. Check the diagnostics6.txt file for details."
