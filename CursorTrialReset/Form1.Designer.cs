namespace CursorTrialReset
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            backupsLbl = new LinkLabel();
            label2 = new Label();
            githubLbl = new LinkLabel();
            logText = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(336, 68);
            button1.TabIndex = 0;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnResetIds_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(58, 13);
            label1.TabIndex = 2;
            label1.Text = "Backups : ";
            // 
            // backupsLbl
            // 
            backupsLbl.AutoSize = true;
            backupsLbl.Font = new Font("Segoe UI", 8.25F);
            backupsLbl.Location = new Point(68, 111);
            backupsLbl.Name = "backupsLbl";
            backupsLbl.Size = new Size(280, 13);
            backupsLbl.TabIndex = 3;
            backupsLbl.TabStop = true;
            backupsLbl.Text = "%APPDATA%\\Cursor\\User\\globalStorage\\storage.json";
            backupsLbl.LinkClicked += backupsLbl_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F);
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(49, 13);
            label2.TabIndex = 4;
            label2.Text = "Github :";
            // 
            // githubLbl
            // 
            githubLbl.AutoSize = true;
            githubLbl.Font = new Font("Segoe UI", 8.25F);
            githubLbl.Location = new Point(68, 134);
            githubLbl.Name = "githubLbl";
            githubLbl.Size = new Size(246, 13);
            githubLbl.TabIndex = 5;
            githubLbl.TabStop = true;
            githubLbl.Text = "https://github.com/canlogiq2/CursorTrialReset";
            githubLbl.LinkClicked += githubLbl_LinkClicked;
            // 
            // logText
            // 
            logText.AutoSize = true;
            logText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            logText.ForeColor = Color.Peru;
            logText.Location = new Point(68, 88);
            logText.Name = "logText";
            logText.Size = new Size(31, 13);
            logText.TabIndex = 7;
            logText.Text = "Wait";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(32, 13);
            label3.TabIndex = 8;
            label3.Text = "Log :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 165);
            Controls.Add(label3);
            Controls.Add(logText);
            Controls.Add(githubLbl);
            Controls.Add(label2);
            Controls.Add(backupsLbl);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cursor Reset Trial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private LinkLabel backupsLbl;
        private Label label2;
        private LinkLabel githubLbl;
        private Label logText;
        private Label label3;
    }
}
