using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json;

namespace DDragonDownloader_Riot_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //NICHT VERÄNDERN FÜR DIE BEWEGUNG DES FENSTERS WICHTIG!
        //-------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        //-------------------------

        WebClient webClient; 
        Stopwatch stopwatch;
        String saveFilePath;
        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            stopwatch = new Stopwatch();
            webClient = new WebClient();
            stopDownloadButton.Enabled = false;
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.saveFileButton, "Save MY FILE TO...");
            toolTip1.SetToolTip(this.downloadButton, "Start Download!");


            saveFilePath = "";
            label1.ForeColor = Color.Lime;
            label1.Text = "DDRAGON DOWNLOADER BY Diyar";

            consoleText.Text += "Mit diesem Programm kann man DDragon Datein von Riot Herunterladen.";
            consoleText.Text += "\nDiese Dateien sind wichtig, da sie ein bestandteil der Api von Riot sind.";
            consoleText.Text += "\n";
        }

        private void updatedConsole(String insertString)
        {
            consoleText.Text += insertString;
        }

        public void DownloadFile(string urlAddress, string location)
        {
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            Uri URL = new Uri(urlAddress);
            // Start the stopwatch which we will be using to calculate the download speed
            stopwatch.Start();

            try
            {
                // Start downloading the file
                webClient.DownloadFileAsync(URL, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            speed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / stopwatch.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            percent.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            left.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            stopwatch.Reset();

            if (e.Cancelled == true)
            {
                consoleText.Text += "\n\nDownload wurde beendet";
                saveFileButton.Enabled = true;
                downloadButton.Enabled = true;
                //MessageBox.Show("Download has been canceled.");
            }
            else
            {
                consoleText.Text += "\n\nDownload Fertig!";
                saveFileButton.Enabled = true;
                downloadButton.Enabled = true;
                //MessageBox.Show("Download completed!");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    saveFilePath = fbd.SelectedPath.ToString();
                    updatedConsole("\nSave File Path: "+saveFilePath);
                }
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (saveFilePath != "")
            {
                stopDownloadButton.Enabled = true;
                List<String> ls = new List<string>();
                ls = JsonConvert.DeserializeObject<List<string>>(webClient.DownloadString("https://ddragon.leagueoflegends.com/api/versions.json"));
                updatedConsole("\nCurrent Version: "+ls[0].ToString());
                DownloadFile("https://ddragon.leagueoflegends.com/cdn/dragontail-"+ls[0].ToString()+".tgz",@saveFilePath+"/dragontail-"+ls[0].ToString()+".tgz");
                saveFileButton.Enabled = false;
                downloadButton.Enabled = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void stopDownloadButton_Click(object sender, EventArgs e)
        {
            webClient.CancelAsync();
            webClient = new WebClient();
        }
    }
}
