using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;

namespace CursorTrialReset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResetIds_Click(object sender, EventArgs e)
        {
            try
            {
                string storageFilePath = GetStorageFilePath();
                if (!string.IsNullOrEmpty(storageFilePath))
                {
                    string backupPath = BackupFile(storageFilePath);
                    ResetCursorId(storageFilePath);
                    LogMessage("Reset successful!", System.Drawing.Color.Green);
                }
                else
                {
                    LogMessage("Storage file not found.", System.Drawing.Color.Red);
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}", System.Drawing.Color.Red);
            }
        }

        private void LogMessage(string message, System.Drawing.Color color)
        {
            logText.ForeColor = color;
            logText.Text = $"{message}";
        }

        private string BackupFile(string filePath)
        {
            string backupPath = filePath + $".backup_{DateTime.Now:yyyyMMdd_HHmmss}";
            File.Copy(filePath, backupPath, true);
            return backupPath;
        }

        private string GetStorageFilePath()
        {
            string system = Environment.OSVersion.Platform.ToString();
            string storageFilePath = "";

            if (system.Contains("Win"))
            {
                storageFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Cursor", "User", "globalStorage", "storage.json");
            }
            else if (system.Contains("Mac"))
            {
                storageFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Library", "Application Support", "Cursor", "User", "globalStorage", "storage.json");
            }
            else if (system.Contains("Unix"))
            {
                storageFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".config", "Cursor", "User", "globalStorage", "storage.json");
            }
            else
            {
                throw new NotSupportedException("Unsupported operating system.");
            }

            return File.Exists(storageFilePath) ? storageFilePath : throw new FileNotFoundException("Storage file not found.");
        }

        private void ResetCursorId(string storageFilePath)
        {
            string jsonData = File.Exists(storageFilePath) ? File.ReadAllText(storageFilePath) : "{}";

            var options = new JsonSerializerOptions { WriteIndented = true };
            var data = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData, options)
                       ?? new Dictionary<string, object>();

            UpdateJsonValue(data, "telemetry.machineId", GenerateRandomHex(32));
            UpdateJsonValue(data, "telemetry.macMachineId", GenerateRandomHex(32));
            UpdateJsonValue(data, "telemetry.devDeviceId", Guid.NewGuid().ToString());

            File.WriteAllText(storageFilePath, JsonSerializer.Serialize(data, options));
        }

        private void UpdateJsonValue(Dictionary<string, object> data, string key, string newValue)
        {
            if (data.ContainsKey(key))
            {
                data[key] = newValue;
            }
            else
            {
                data.Add(key, newValue);
            }
        }

        private string GenerateRandomHex(int byteLength)
        {
            byte[] randomBytes = new byte[byteLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return BitConverter.ToString(randomBytes).Replace("-", string.Empty).ToLower();
        }

        private void backupsLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string backupFolderPath = Path.Combine(appDataPath, "Cursor", "User", "globalStorage");

                if (Directory.Exists(backupFolderPath))
                {
                    Process.Start("explorer.exe", backupFolderPath);
                }
                else
                {
                    MessageBox.Show("Backup folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the backup folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void githubLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string githubUrl = githubLbl.Text;
                Process.Start(new ProcessStartInfo
                {
                    FileName = githubUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
