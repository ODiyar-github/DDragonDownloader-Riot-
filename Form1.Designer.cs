namespace DDragonDownloader_Riot_
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.stopDownloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(320, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 24);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(290, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(26, 24);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1, 214);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(345, 23);
            this.progressBar.TabIndex = 5;
            // 
            // consoleText
            // 
            this.consoleText.BackColor = System.Drawing.Color.Black;
            this.consoleText.ForeColor = System.Drawing.Color.Lime;
            this.consoleText.Location = new System.Drawing.Point(1, 60);
            this.consoleText.Name = "consoleText";
            this.consoleText.ReadOnly = true;
            this.consoleText.Size = new System.Drawing.Size(345, 128);
            this.consoleText.TabIndex = 6;
            this.consoleText.Text = "";
            // 
            // saveFileButton
            // 
            this.saveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.Location = new System.Drawing.Point(1, 31);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(26, 23);
            this.saveFileButton.TabIndex = 7;
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadButton.Image = ((System.Drawing.Image)(resources.GetObject("downloadButton.Image")));
            this.downloadButton.Location = new System.Drawing.Point(33, 31);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(26, 23);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.ForeColor = System.Drawing.Color.Lime;
            this.speed.Location = new System.Drawing.Point(207, 191);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(0, 13);
            this.speed.TabIndex = 10;
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.ForeColor = System.Drawing.Color.Lime;
            this.left.Location = new System.Drawing.Point(-2, 191);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(0, 13);
            this.left.TabIndex = 11;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.ForeColor = System.Drawing.Color.Lime;
            this.percent.Location = new System.Drawing.Point(301, 191);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(0, 13);
            this.percent.TabIndex = 12;
            // 
            // stopDownloadButton
            // 
            this.stopDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopDownloadButton.Image = ((System.Drawing.Image)(resources.GetObject("stopDownloadButton.Image")));
            this.stopDownloadButton.Location = new System.Drawing.Point(65, 31);
            this.stopDownloadButton.Name = "stopDownloadButton";
            this.stopDownloadButton.Size = new System.Drawing.Size(26, 23);
            this.stopDownloadButton.TabIndex = 13;
            this.stopDownloadButton.UseVisualStyleBackColor = true;
            this.stopDownloadButton.Click += new System.EventHandler(this.stopDownloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(348, 238);
            this.Controls.Add(this.stopDownloadButton);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.left);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.consoleText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox consoleText;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Button stopDownloadButton;
    }
}

