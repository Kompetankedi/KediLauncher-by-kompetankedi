using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using Microsoft.Web.WebView2.Core;
using System;
using System.Threading;
using System.Windows.Forms;

namespace KediLauncher_by_kompetankedi
{
    public partial class Form1 : Form
    {
        string temp = System.IO.Path.GetTempPath();
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public static string versiyon;
        private void path()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            foreach (var item in launcher.GetAllVersions())
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void LaunchCrack()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = Convert.ToInt32(comboBox2.SelectedItem),
                Session = MSession.CreateOfflineSession(textBox1.Text),
                ServerIp = "", // çift tırnak içine domein yada ip gir 

            };
            versiyon = comboBox1.SelectedItem.ToString();
            var process = launcher.CreateProcess(versiyon, launchOption);
            process.Start();
            metroButton1.Enabled = true;
        }

        private async void Launch()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);
            var loginHandler = JELoginHandlerBuilder.BuildDefault();
            var session = await loginHandler.Authenticate();
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = Convert.ToInt32(comboBox2.SelectedItem),
                Session = await loginHandler.AuthenticateInteractively(),
                ServerIp = "", // çift tırnak içine domein yada ip gir 

            };
            versiyon = comboBox1.SelectedItem.ToString();
            var process = launcher.CreateProcess(versiyon, launchOption);
            process.Start();
            metroButton2.Enabled = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(null, temp);
            await webView21.EnsureCoreWebView2Async(webViewEnvironment);
            webView21.Source = new Uri("https://minecraft-timeline.github.io/");


            path();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
            Thread thread = new Thread(() => LaunchCrack());
            thread.Start();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroButton2.Enabled = false;
            Thread thread = new Thread(() => Launch());
            thread.Start();
        }
    }
}