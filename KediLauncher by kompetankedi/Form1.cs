using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using Microsoft.Web.WebView2.Core;
using System;
using System.Drawing;
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
            rjButton1.MouseDown += rjButton1_MouseDown;
            rjButton1.MouseMove += rjButton1_MouseMove;
            rjButton1.MouseUp += rjButton1_MouseUp;
        }
        private Point dragStartPoint;
        private bool isDragging = false;
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
            oPlay.Enabled = true;
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
            oPlay.Enabled = true;
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            oPlay.BorderRadius = 15;
            oPlay.BorderSize = 5;
            path();
            comboBox2.Text = "2048";
            comboBox1.Text = "1.8.9";
            textBox1.Enabled = false;
        }

       
        private void oPlay_Click(object sender, EventArgs e)
        {
            try { 
            if (rjToggleButton1.Checked == true)
            {
                    oPlay.Enabled = false;
                    Thread thread = new Thread(() => LaunchCrack());
                    thread.Start();
                }
                else if(rjToggleButton1.Checked==false) {
                    oPlay.Enabled = false;
                    Thread thread = new Thread(() => Launch());
                    thread.Start();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked==true)
            {
                textBox1.Enabled = true;
            }
            else { textBox1.Enabled = false;
                textBox1.Text = "";
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rjButton1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
        }

        private void rjButton1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point mousePosition = Cursor.Position;
                Location = new Point(mousePosition.X - dragStartPoint.X, mousePosition.Y - dragStartPoint.Y);
            }
        }

        private void rjButton1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}