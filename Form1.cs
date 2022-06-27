using System;
using System.Net;
using System.Windows.Forms;

namespace ToolBox_Manager
{
    public partial class Form1 : Form
    {
        WebClient Tiger;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://download.scdn.co/SpotifySetup.exe", @"C:\windows\temp\spotf.exe");
            System.Diagnostics.Process.Start(@"C:\windows\temp\spotf.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://www.7-zip.org/a/7z2200-x64.exe", @"C:\windows\temp\zip.exe");
            System.Diagnostics.Process.Start(@"c:windows\temp\zip.exe");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9005/DiscordSetup.exe", @"c:\windows\temp\discord.exe");
            System.Diagnostics.Process.Start(@"C:\windows\temp\discord.exe");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://cdn-fastly.obsproject.com/downloads/OBS-Studio-27.2.4-Full-Installer-x64.exe", @"C:\windows\temp\obs.exe");
            System.Diagnostics.Process.Start(@"C:\windows\temp\obs.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://github.com/ShareX/ShareX/releases/download/v13.7.0/ShareX-13.7.0-setup.exe", @"c:\windows\temp\share.exe");
            System.Diagnostics.Process.Start(@"c:\windows\temp\share.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://dl.bandicam.com/bdcamsetup.exe", @"C:\windows\temp\bdcam.exe");
            System.Diagnostics.Process.Start(@"C:\windows\temp\bdcam.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", @"c:\windows\temp\steam.exe");
            System.Diagnostics.Process.Start(@"C:\windows\temp\steam.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama yükleniyor...");
            Tiger.DownloadFile("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi", @"c:\windows\temp\EpicGamesLauncher.exe");
            System.Diagnostics.Process.Start(@"C:\windows\temp\EpicGamesLauncher.exe");
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
