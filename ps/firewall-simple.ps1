# Enable Windows Firewall for all profiles (Domain, Private, Public)
Write-Host "Enabling Windows Firewall for all profiles..."
Set-NetFirewallProfile -Profile Domain,Private,Public -Enabled True

# Enable Windows Defender Real-Time Protection
Write-Host "Enabling Windows Defender Real-Time Protection..."
Set-MpPreference -DisableRealtimeMonitoring $false

# Enable Windows Defender Automatic Sample Submission (optional)
Write-Host "Enabling Windows Defender Automatic Sample Submission..."
Set-MpPreference -SubmitSamplesConsent 1

# Enable Windows Defender Cloud-Based Protection
Write-Host "Enabling Windows Defender Cloud-Based Protection..."
Set-MpPreference -MAPSReporting Advanced

# Enable Windows Defender Scanning for Potentially Unwanted Programs (PUP)
Write-Host "Enabling Windows Defender PUP Protection..."
Set-MpPreference -PUAProtection 1

Write-Host "Basic Windows Defender security settings have been enabled."
