namespace RadioBtnGrp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblChoose = new System.Windows.Forms.Label();
            this.grpWeather = new System.Windows.Forms.GroupBox();
            this.rbSnow = new System.Windows.Forms.RadioButton();
            this.rbSun = new System.Windows.Forms.RadioButton();
            this.rbRain = new System.Windows.Forms.RadioButton();
            this.grpCountry = new System.Windows.Forms.GroupBox();
            this.rbUK = new System.Windows.Forms.RadioButton();
            this.rbItaly = new System.Windows.Forms.RadioButton();
            this.rbCanada = new System.Windows.Forms.RadioButton();
            this.pbRain = new System.Windows.Forms.PictureBox();
            this.pbSun = new System.Windows.Forms.PictureBox();
            this.pbSnow = new System.Windows.Forms.PictureBox();
            this.pbCanada = new System.Windows.Forms.PictureBox();
            this.pbItaly = new System.Windows.Forms.PictureBox();
            this.pbUK = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpWeather.SuspendLayout();
            this.grpCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(13, 13);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(393, 13);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose one button from the weather group and one button from the country group";
            // 
            // grpWeather
            // 
            this.grpWeather.Controls.Add(this.rbSnow);
            this.grpWeather.Controls.Add(this.rbSun);
            this.grpWeather.Controls.Add(this.rbRain);
            this.grpWeather.Location = new System.Drawing.Point(16, 64);
            this.grpWeather.Name = "grpWeather";
            this.grpWeather.Size = new System.Drawing.Size(117, 175);
            this.grpWeather.TabIndex = 1;
            this.grpWeather.TabStop = false;
            this.grpWeather.Text = "Weather";
            // 
            // rbSnow
            // 
            this.rbSnow.AutoSize = true;
            this.rbSnow.Location = new System.Drawing.Point(49, 125);
            this.rbSnow.Name = "rbSnow";
            this.rbSnow.Size = new System.Drawing.Size(52, 17);
            this.rbSnow.TabIndex = 2;
            this.rbSnow.TabStop = true;
            this.rbSnow.Text = "Snow";
            this.rbSnow.UseVisualStyleBackColor = true;
            this.rbSnow.CheckedChanged += new System.EventHandler(this.rbSnow_CheckedChanged);
            // 
            // rbSun
            // 
            this.rbSun.AutoSize = true;
            this.rbSun.Location = new System.Drawing.Point(49, 79);
            this.rbSun.Name = "rbSun";
            this.rbSun.Size = new System.Drawing.Size(44, 17);
            this.rbSun.TabIndex = 1;
            this.rbSun.TabStop = true;
            this.rbSun.Text = "Sun";
            this.rbSun.UseVisualStyleBackColor = true;
            this.rbSun.CheckedChanged += new System.EventHandler(this.rbSun_CheckedChanged);
            // 
            // rbRain
            // 
            this.rbRain.AutoSize = true;
            this.rbRain.Location = new System.Drawing.Point(49, 34);
            this.rbRain.Name = "rbRain";
            this.rbRain.Size = new System.Drawing.Size(47, 17);
            this.rbRain.TabIndex = 0;
            this.rbRain.TabStop = true;
            this.rbRain.Text = "Rain";
            this.rbRain.UseVisualStyleBackColor = true;
            this.rbRain.CheckedChanged += new System.EventHandler(this.rbRain_CheckedChanged);
            // 
            // grpCountry
            // 
            this.grpCountry.Controls.Add(this.rbUK);
            this.grpCountry.Controls.Add(this.rbItaly);
            this.grpCountry.Controls.Add(this.rbCanada);
            this.grpCountry.Location = new System.Drawing.Point(211, 64);
            this.grpCountry.Name = "grpCountry";
            this.grpCountry.Size = new System.Drawing.Size(117, 175);
            this.grpCountry.TabIndex = 2;
            this.grpCountry.TabStop = false;
            this.grpCountry.Text = "Country";
            // 
            // rbUK
            // 
            this.rbUK.AutoSize = true;
            this.rbUK.Location = new System.Drawing.Point(49, 125);
            this.rbUK.Name = "rbUK";
            this.rbUK.Size = new System.Drawing.Size(40, 17);
            this.rbUK.TabIndex = 2;
            this.rbUK.TabStop = true;
            this.rbUK.Text = "UK";
            this.rbUK.UseVisualStyleBackColor = true;
            this.rbUK.CheckedChanged += new System.EventHandler(this.rbUK_CheckedChanged);
            // 
            // rbItaly
            // 
            this.rbItaly.AutoSize = true;
            this.rbItaly.Location = new System.Drawing.Point(49, 79);
            this.rbItaly.Name = "rbItaly";
            this.rbItaly.Size = new System.Drawing.Size(44, 17);
            this.rbItaly.TabIndex = 1;
            this.rbItaly.TabStop = true;
            this.rbItaly.Text = "Italy";
            this.rbItaly.UseVisualStyleBackColor = true;
            this.rbItaly.CheckedChanged += new System.EventHandler(this.rbItaly_CheckedChanged);
            // 
            // rbCanada
            // 
            this.rbCanada.AutoSize = true;
            this.rbCanada.Location = new System.Drawing.Point(49, 34);
            this.rbCanada.Name = "rbCanada";
            this.rbCanada.Size = new System.Drawing.Size(62, 17);
            this.rbCanada.TabIndex = 0;
            this.rbCanada.TabStop = true;
            this.rbCanada.Text = "Canada";
            this.rbCanada.UseVisualStyleBackColor = true;
            this.rbCanada.CheckedChanged += new System.EventHandler(this.rbCanada_CheckedChanged);
            // 
            // pbRain
            // 
            this.pbRain.Image = ((System.Drawing.Image)(resources.GetObject("pbRain.Image")));
            this.pbRain.Location = new System.Drawing.Point(150, 83);
            this.pbRain.Name = "pbRain";
            this.pbRain.Size = new System.Drawing.Size(46, 32);
            this.pbRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRain.TabIndex = 3;
            this.pbRain.TabStop = false;
            this.pbRain.Visible = false;
            // 
            // pbSun
            // 
            this.pbSun.Image = ((System.Drawing.Image)(resources.GetObject("pbSun.Image")));
            this.pbSun.Location = new System.Drawing.Point(150, 128);
            this.pbSun.Name = "pbSun";
            this.pbSun.Size = new System.Drawing.Size(46, 32);
            this.pbSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSun.TabIndex = 4;
            this.pbSun.TabStop = false;
            this.pbSun.Visible = false;
            // 
            // pbSnow
            // 
            this.pbSnow.Image = ((System.Drawing.Image)(resources.GetObject("pbSnow.Image")));
            this.pbSnow.Location = new System.Drawing.Point(150, 174);
            this.pbSnow.Name = "pbSnow";
            this.pbSnow.Size = new System.Drawing.Size(46, 32);
            this.pbSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnow.TabIndex = 5;
            this.pbSnow.TabStop = false;
            this.pbSnow.Visible = false;
            // 
            // pbCanada
            // 
            this.pbCanada.Image = ((System.Drawing.Image)(resources.GetObject("pbCanada.Image")));
            this.pbCanada.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCanada.InitialImage")));
            this.pbCanada.Location = new System.Drawing.Point(334, 83);
            this.pbCanada.Name = "pbCanada";
            this.pbCanada.Size = new System.Drawing.Size(46, 32);
            this.pbCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCanada.TabIndex = 6;
            this.pbCanada.TabStop = false;
            this.pbCanada.Visible = false;
            // 
            // pbItaly
            // 
            this.pbItaly.Image = ((System.Drawing.Image)(resources.GetObject("pbItaly.Image")));
            this.pbItaly.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbItaly.InitialImage")));
            this.pbItaly.Location = new System.Drawing.Point(334, 128);
            this.pbItaly.Name = "pbItaly";
            this.pbItaly.Size = new System.Drawing.Size(46, 32);
            this.pbItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItaly.TabIndex = 7;
            this.pbItaly.TabStop = false;
            this.pbItaly.Visible = false;
            // 
            // pbUK
            // 
            this.pbUK.Image = ((System.Drawing.Image)(resources.GetObject("pbUK.Image")));
            this.pbUK.Location = new System.Drawing.Point(334, 174);
            this.pbUK.Name = "pbUK";
            this.pbUK.Size = new System.Drawing.Size(46, 32);
            this.pbUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUK.TabIndex = 8;
            this.pbUK.TabStop = false;
            this.pbUK.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 289);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbUK);
            this.Controls.Add(this.pbItaly);
            this.Controls.Add(this.pbCanada);
            this.Controls.Add(this.pbSnow);
            this.Controls.Add(this.pbSun);
            this.Controls.Add(this.pbRain);
            this.Controls.Add(this.grpCountry);
            this.Controls.Add(this.grpWeather);
            this.Controls.Add(this.lblChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpWeather.ResumeLayout(false);
            this.grpWeather.PerformLayout();
            this.grpCountry.ResumeLayout(false);
            this.grpCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.GroupBox grpWeather;
        private System.Windows.Forms.RadioButton rbSnow;
        private System.Windows.Forms.RadioButton rbSun;
        private System.Windows.Forms.RadioButton rbRain;
        private System.Windows.Forms.GroupBox grpCountry;
        private System.Windows.Forms.RadioButton rbUK;
        private System.Windows.Forms.RadioButton rbItaly;
        private System.Windows.Forms.RadioButton rbCanada;
        private System.Windows.Forms.PictureBox pbRain;
        private System.Windows.Forms.PictureBox pbSun;
        private System.Windows.Forms.PictureBox pbSnow;
        private System.Windows.Forms.PictureBox pbCanada;
        private System.Windows.Forms.PictureBox pbItaly;
        private System.Windows.Forms.PictureBox pbUK;
        private System.Windows.Forms.Button btnExit;
    }
}

