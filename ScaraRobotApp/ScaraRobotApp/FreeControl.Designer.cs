namespace ScaraRobotApp
{
    partial class FreeControl
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
            button4 = new Button();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            trackBar1 = new TrackBar();
            textBox7 = new TextBox();
            label11 = new Label();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            textBox1 = new TextBox();
            button3 = new Button();
            button5 = new Button();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 255);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(-1, -2);
            button4.Name = "button4";
            button4.Size = new Size(145, 43);
            button4.TabIndex = 81;
            button4.Text = "<- Geri Dön";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(462, 595);
            label10.Name = "label10";
            label10.Size = new Size(343, 20);
            label10.TabIndex = 82;
            label10.Text = "Başlamadan Önce Home Komutunu Çalıştırınız !";
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(495, 519);
            button2.Name = "button2";
            button2.Size = new Size(275, 64);
            button2.TabIndex = 84;
            button2.Text = "Home Location";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(884, 184);
            button1.Name = "button1";
            button1.Size = new Size(157, 39);
            button1.TabIndex = 83;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(417, 39);
            label4.MaximumSize = new Size(1000, 1000);
            label4.Name = "label4";
            label4.Size = new Size(449, 84);
            label4.TabIndex = 86;
            label4.Text = "Free Movement";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(267, 388);
            label2.MaximumSize = new Size(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 84);
            label2.TabIndex = 94;
            label2.Text = "Z";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(651, 299);
            textBox8.Margin = new Padding(6);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(167, 38);
            textBox8.TabIndex = 92;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(266, 271);
            label12.MaximumSize = new Size(100, 100);
            label12.Name = "label12";
            label12.Size = new Size(100, 84);
            label12.TabIndex = 91;
            label12.Text = "J2";
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.NoMoveHoriz;
            trackBar1.Location = new Point(390, 299);
            trackBar1.Maximum = 150;
            trackBar1.Minimum = -150;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(237, 56);
            trackBar1.TabIndex = 90;
            trackBar1.UseWaitCursor = true;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(651, 185);
            textBox7.Margin = new Padding(6);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(167, 38);
            textBox7.TabIndex = 89;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(266, 157);
            label11.MaximumSize = new Size(100, 100);
            label11.Name = "label11";
            label11.Size = new Size(100, 84);
            label11.TabIndex = 88;
            label11.Text = "J1";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(390, 185);
            trackBar2.Maximum = 266;
            trackBar2.Minimum = -90;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(237, 56);
            trackBar2.TabIndex = 87;
            trackBar2.UseWaitCursor = true;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Cursor = Cursors.NoMoveHoriz;
            trackBar3.Location = new Point(378, 414);
            trackBar3.Maximum = 400;
            trackBar3.Minimum = -3000;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(237, 56);
            trackBar3.TabIndex = 96;
            trackBar3.UseWaitCursor = true;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(651, 414);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 38);
            textBox1.TabIndex = 100;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(884, 298);
            button3.Name = "button3";
            button3.Size = new Size(157, 39);
            button3.TabIndex = 101;
            button3.Text = "Run";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(884, 414);
            button5.Name = "button5";
            button5.Size = new Size(157, 39);
            button5.TabIndex = 102;
            button5.Text = "Run";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(651, 475);
            label13.Name = "label13";
            label13.Size = new Size(115, 17);
            label13.TabIndex = 104;
            label13.Text = "Min Value : -3000";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(651, 458);
            label14.Name = "label14";
            label14.Size = new Size(105, 17);
            label14.TabIndex = 103;
            label14.Text = "Max Value : 400";
            // 
            // FreeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1260, 676);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(trackBar3);
            Controls.Add(label2);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(trackBar1);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(trackBar2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(button4);
            Name = "FreeControl";
            Text = "FreeControl";
            Load += pageLoad;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label10;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label2;
        private TextBox textBox8;
        private Label label12;
        public TrackBar trackBar1;
        private TextBox textBox7;
        private Label label11;
        public TrackBar trackBar2;
        public TrackBar trackBar3;
        private TextBox textBox1;
        private Button button3;
        private Button button5;
        private Label label13;
        private Label label14;
    }
}