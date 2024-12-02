#!/bin/bash

# Exit script on any error
set -e

echo "Starting Docker installation..."

# Step 1: Verify Ubuntu version
echo "Checking Ubuntu version..."
UBUNTU_CODENAME=$(lsb_release -cs)
echo "Detected Ubuntu release: $UBUNTU_CODENAME"

# Step 2: Remove incorrect configurations
echo "Cleaning up any previous Docker configurations..."
sudo rm -f /etc/apt/sources.list.d/docker.list
sudo rm -f /etc/apt/keyrings/docker.asc

# Step 3: Add Docker's GPG Key
echo "Adding Docker's GPG key..."
sudo install -m 0755 -d /etc/apt/keyrings
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo tee /etc/apt/keyrings/docker.asc > /dev/null
sudo chmod a+r /etc/apt/keyrings/docker.asc

# Step 4: Add the Docker repository
echo "Adding Docker repository to apt sources..."
echo "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.asc] https://download.docker.com/linux/ubuntu $UBUNTU_CODENAME stable" | sudo tee /etc/apt/sources.list.d/docker.list > /dev/null

# Step 5: Update package list
echo "Updating package list..."
sudo apt-get update

# Step 6: Install required dependencies
echo "Installing required dependencies..."
sudo apt-get install -y ca-certificates curl gnupg

# Step 7: Install Docker packages
echo "Installing Docker packages..."
sudo apt-get install -y docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin

# Step 8: Verify Docker installation
echo "Verifying Docker installation..."
docker --version
docker-compose --version

echo "Docker installation completed successfully!"
