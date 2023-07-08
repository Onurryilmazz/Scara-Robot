namespace ScaraRobotApp
{
    partial class ForwardKınematic
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
            label14 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            trackBar3 = new TrackBar();
            textBox10 = new TextBox();
            label16 = new Label();
            trackBar4 = new TrackBar();
            label13 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            trackBar1 = new TrackBar();
            textBox7 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            trackBar2 = new TrackBar();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button4 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.Font = new Font("Siemens Slab SC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Green;
            label14.Location = new Point(733, 93);
            label14.MaximumSize = new Size(1000, 1000);
            label14.Name = "label14";
            label14.Size = new Size(399, 69);
            label14.TabIndex = 51;
            label14.Text = "Place Location";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.Location = new Point(1087, 350);
            textBox9.Margin = new Padding(6);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(167, 38);
            textBox9.TabIndex = 50;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(721, 322);
            label15.MaximumSize = new Size(100, 100);
            label15.Name = "label15";
            label15.Size = new Size(100, 84);
            label15.TabIndex = 49;
            label15.Text = "J2";
            // 
            // trackBar3
            // 
            trackBar3.Cursor = Cursors.NoMoveHoriz;
            trackBar3.Location = new Point(827, 350);
            trackBar3.Maximum = 150;
            trackBar3.Minimum = -150;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(237, 56);
            trackBar3.TabIndex = 48;
            trackBar3.UseWaitCursor = true;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.Location = new Point(1087, 220);
            textBox10.Margin = new Padding(6);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(167, 38);
            textBox10.TabIndex = 47;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(721, 192);
            label16.MaximumSize = new Size(100, 100);
            label16.Name = "label16";
            label16.Size = new Size(100, 84);
            label16.TabIndex = 46;
            label16.Text = "J1";
            // 
            // trackBar4
            // 
            trackBar4.Cursor = Cursors.NoMoveHoriz;
            trackBar4.Location = new Point(827, 220);
            trackBar4.Maximum = 266;
            trackBar4.Minimum = -90;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(237, 56);
            trackBar4.TabIndex = 45;
            trackBar4.UseWaitCursor = true;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // label13
            // 
            label13.Font = new Font("Siemens Slab SC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(43, 93);
            label13.MaximumSize = new Size(1000, 1000);
            label13.Name = "label13";
            label13.Size = new Size(361, 69);
            label13.TabIndex = 44;
            label13.Text = "Pick Location";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(428, 350);
            textBox8.Margin = new Padding(6);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(167, 38);
            textBox8.TabIndex = 43;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(43, 322);
            label12.MaximumSize = new Size(100, 100);
            label12.Name = "label12";
            label12.Size = new Size(100, 84);
            label12.TabIndex = 42;
            label12.Text = "J2";
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.NoMoveHoriz;
            trackBar1.Location = new Point(167, 350);
            trackBar1.Maximum = 150;
            trackBar1.Minimum = -150;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(237, 56);
            trackBar1.TabIndex = 41;
            trackBar1.UseWaitCursor = true;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(428, 220);
            textBox7.Margin = new Padding(6);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(167, 38);
            textBox7.TabIndex = 40;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(43, 192);
            label11.MaximumSize = new Size(100, 100);
            label11.Name = "label11";
            label11.Size = new Size(100, 84);
            label11.TabIndex = 39;
            label11.Text = "J1";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(390, 9);
            label10.MaximumSize = new Size(1000, 1000);
            label10.Name = "label10";
            label10.Size = new Size(550, 84);
            label10.TabIndex = 38;
            label10.Text = "Forward Kinematics";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(167, 220);
            trackBar2.Maximum = 266;
            trackBar2.Minimum = -90;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(237, 56);
            trackBar2.TabIndex = 37;
            trackBar2.UseWaitCursor = true;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(801, 542);
            button3.Name = "button3";
            button3.Size = new Size(181, 64);
            button3.TabIndex = 77;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(366, 542);
            button2.Name = "button2";
            button2.Size = new Size(192, 64);
            button2.TabIndex = 76;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(584, 542);
            button1.Name = "button1";
            button1.Size = new Size(181, 64);
            button1.TabIndex = 75;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 638);
            label1.Name = "label1";
            label1.Size = new Size(343, 20);
            label1.TabIndex = 78;
            label1.Text = "Başlamadan Önce Home Komutunu Çalıştırınız !";
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
            // label2
            // 
            label2.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 423);
            label2.MaximumSize = new Size(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 84);
            label2.TabIndex = 82;
            label2.Text = "Z";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(179, 453);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 38);
            textBox1.TabIndex = 83;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(842, 453);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 38);
            textBox2.TabIndex = 85;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(733, 423);
            label3.MaximumSize = new Size(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 84);
            label3.TabIndex = 84;
            label3.Text = "Z";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(366, 470);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 87;
            label4.Text = "Min Value : -3000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(366, 453);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 86;
            label5.Text = "Max Value : 400";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1027, 470);
            label6.Name = "label6";
            label6.Size = new Size(115, 17);
            label6.TabIndex = 89;
            label6.Text = "Min Value : -3000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(1027, 453);
            label7.Name = "label7";
            label7.Size = new Size(105, 17);
            label7.TabIndex = 88;
            label7.Text = "Max Value : 400";
            // 
            // ForwardKınematic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1295, 683);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(textBox9);
            Controls.Add(label15);
            Controls.Add(trackBar3);
            Controls.Add(textBox10);
            Controls.Add(label16);
            Controls.Add(trackBar4);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(trackBar1);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(trackBar2);
            Name = "ForwardKınematic";
            Text = "ForwardKınematic";
            Load += pageLoad;
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private TextBox textBox9;
        private Label label15;
        public TrackBar trackBar3;
        private TextBox textBox10;
        private Label label16;
        public TrackBar trackBar4;
        private Label label13;
        private TextBox textBox8;
        private Label label12;
        public TrackBar trackBar1;
        private TextBox textBox7;
        private Label label11;
        private Label label10;
        public TrackBar trackBar2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button4;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}