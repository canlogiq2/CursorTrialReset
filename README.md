# Cursor Trial Reset Tool

A utility tool that helps manage Cursor editor's device identification system by resetting stored device IDs. This can help users to resolve issues related to account restrictions when switching between accounts or during trial periods.

# How It Works

The tool generates a new device identifier, which allows Cursor to recognize your system as a new device.


# Key Features

- ✨ Automatic random device ID generation
- 🔄 Automatic backup of original configuration

❗️❗️❗️ Important: You need to log out and completely close Cursor before running the script. If Cursor is still running in the background, it may revert back to the previous device ID, undoing the reset.

# Configuration Location

You can also manually edit the configuration file to set a specific device ID. The default configuration file for each operating system is located at:

- Windows: `%APPDATA%\Cursor\User\globalStorage\storage.json`
- macOS: `~/Library/Application Support/Cursor/User/globalStorage/storage.json`
- Linux: `~/.config/Cursor/User/globalStorage/storage.json`

# Important Notice

This tool is developed for research and educational purposes only. Please use responsibly. The developer assumes no liability for any issues that may arise from using this tool.

# You can access the Python version here

Thanks for making this tool

https://github.com/ultrasev/cursor-reset