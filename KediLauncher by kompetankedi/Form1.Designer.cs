namespace KediLauncher_by_kompetankedi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.oPlay = new CustomControls.RJControls.RJButton();
            this.rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.Close = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(199, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 29);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(199, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 29);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.UseSelectable = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1024",
            "2048",
            "3072",
            "4096",
            "5120",
            "6144",
            "7168",
            "8192",
            "9216",
            "10240",
            "11264",
            "12288",
            "13312",
            "14336",
            "15360",
            "16384"});
            this.comboBox2.Location = new System.Drawing.Point(199, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 29);
            this.comboBox2.TabIndex = 15;
            // 
            // oPlay
            // 
            this.oPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oPlay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.oPlay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.oPlay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.oPlay.BorderRadius = 0;
            this.oPlay.BorderSize = 0;
            this.oPlay.FlatAppearance.BorderSize = 0;
            this.oPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oPlay.ForeColor = System.Drawing.Color.White;
            this.oPlay.Location = new System.Drawing.Point(189, 234);
            this.oPlay.Name = "oPlay";
            this.oPlay.Size = new System.Drawing.Size(150, 40);
            this.oPlay.TabIndex = 19;
            this.oPlay.Text = "Oyna";
            this.oPlay.TextColor = System.Drawing.Color.White;
            this.oPlay.UseVisualStyleBackColor = false;
            this.oPlay.Click += new System.EventHandler(this.oPlay_Click);
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(194, 198);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 20;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Korsanmı Oynuyorsun:";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = global::KediLauncher_by_kompetankedi.Properties.Resources.subtract_32px;
            this.rjButton2.Location = new System.Drawing.Point(487, 7);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(31, 27);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Close.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Close.BorderRadius = 0;
            this.Close.BorderSize = 1;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::KediLauncher_by_kompetankedi.Properties.Resources.close_32px;
            this.Close.Location = new System.Drawing.Point(525, 7);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 27);
            this.Close.TabIndex = 23;
            this.Close.TextColor = System.Drawing.Color.White;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::KediLauncher_by_kompetankedi.Properties.Resources.move_32px;
            this.rjButton1.Location = new System.Drawing.Point(0, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(564, 37);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rjButton1_MouseDown);
            this.rjButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rjButton1_MouseMove);
            this.rjButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rjButton1_MouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kaç mb ram verilsin:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sürüm:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "İsim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(564, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.oPlay);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kedi Lancher V3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private CustomControls.RJControls.RJButton oPlay;
        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton Close;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

