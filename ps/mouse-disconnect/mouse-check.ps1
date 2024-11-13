# Paths to your sound files
$mouseSirenPath = "C:\Users\alenahan26\Downloads\honk.wav"
$keyboardSirenPath = "C:\Users\alenahan26\Downloads\keyboard.wav"

# Function to play the mouse siren sound
function Play-MouseSiren {
    (New-Object Media.SoundPlayer $mouseSirenPath).PlaySync()
}

# Function to play the keyboard siren sound
function Play-KeyboardSiren {
    (New-Object Media.SoundPlayer $keyboardSirenPath).PlaySync()
}

# Function to get today's diagnostics file path
function Get-LogFilePath {
    $currentDate = (Get-Date).ToString("MM.dd.yyyy")
    return "C:\Users\alenahan26\usb-diagnostics[$currentDate].txt"
}

# Function to log events to the diagnostics file
function Log-Event($message) {
    $logFile = Get-LogFilePath
    $timestamp = (Get-Date).ToString("yyyy-MM-dd HH:mm:ss")
    $logEntry = "$timestamp - $message`n"
    Add-Content -Path $logFile -Value $logEntry
}

# Get the initial state of the mouse and keyboard
$initialMouse = Get-PnpDevice -Class Mouse -Status OK | Where-Object { $_.FriendlyName -like '*mouse*' }
$initialKeyboard = Get-PnpDevice -Class Keyboard -Status OK | Where-Object { $_.FriendlyName -like '*keyboard*' }

if ($null -eq $initialMouse) {
    Write-Host "No mouse detected at the start. Ensure your mouse is connected and try again."
    exit
}

if ($null -eq $initialKeyboard) {
    Write-Host "No keyboard detected at the start. Ensure your keyboard is connected and try again."
    exit
}

Write-Host "Monitoring mouse and keyboard connections..."

# Monitor for mouse and keyboard disconnections
while ($true) {
    # Check if the mouse is still connected
    $currentMouse = Get-PnpDevice -Class Mouse -Status OK | Where-Object { $_.FriendlyName -like '*mouse*' }
    # Check if the keyboard is still connected
    $currentKeyboard = Get-PnpDevice -Class Keyboard -Status OK | Where-Object { $_.FriendlyName -like '*keyboard*' }

    # If no mouse is detected, play the mouse siren sound and log the event
    if ($null -eq $currentMouse) {
        Write-Host "Mouse disconnected! Triggering mouse siren..."
        Play-MouseSiren
        Log-Event "Mouse disconnected"
    } else {
        Write-Host "Mouse connected."
    }

    # If no keyboard is detected, play the keyboard siren sound and log the event
    if ($null -eq $currentKeyboard) {
        Write-Host "Keyboard disconnected! Triggering keyboard siren..."
        Play-KeyboardSiren
        Log-Event "Keyboard disconnected"
    } else {
        Write-Host "Keyboard connected."
    }

    # Check every 5 seconds
    Start-Sleep -Seconds 5
}
