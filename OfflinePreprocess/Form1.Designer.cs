namespace OfflinePreprocess
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
      this.components = new System.ComponentModel.Container();
      this.BTN_OpenFile = new System.Windows.Forms.Button();
      this.BTN_Play = new System.Windows.Forms.Button();
      this.imageBox1 = new Emgu.CV.UI.ImageBox();
      this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
      this.BTN_Stop = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.CB_NoNoise = new System.Windows.Forms.CheckBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.BTN_ToTab2 = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label13 = new System.Windows.Forms.Label();
      this.comboBox4 = new System.Windows.Forms.ComboBox();
      this.label12 = new System.Windows.Forms.Label();
      this.comboBox3 = new System.Windows.Forms.ComboBox();
      this.label11 = new System.Windows.Forms.Label();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.BTN_Ok = new System.Windows.Forms.Button();
      this.BTN_Next = new System.Windows.Forms.Button();
      this.BTN_Prev = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.imageBox2 = new Emgu.CV.UI.ImageBox();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
      this.imageBox3 = new Emgu.CV.UI.ImageBox();
      this.BTN_Back = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
      this.SuspendLayout();
      // 
      // BTN_OpenFile
      // 
      this.BTN_OpenFile.Location = new System.Drawing.Point(5, 5);
      this.BTN_OpenFile.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_OpenFile.Name = "BTN_OpenFile";
      this.BTN_OpenFile.Size = new System.Drawing.Size(67, 22);
      this.BTN_OpenFile.TabIndex = 0;
      this.BTN_OpenFile.Text = "Open file...";
      this.BTN_OpenFile.UseVisualStyleBackColor = true;
      this.BTN_OpenFile.Click += new System.EventHandler(this.BTN_OpenFile_Click);
      // 
      // BTN_Play
      // 
      this.BTN_Play.Location = new System.Drawing.Point(5, 32);
      this.BTN_Play.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_Play.Name = "BTN_Play";
      this.BTN_Play.Size = new System.Drawing.Size(67, 24);
      this.BTN_Play.TabIndex = 1;
      this.BTN_Play.Text = "Play";
      this.BTN_Play.UseVisualStyleBackColor = true;
      // 
      // imageBox1
      // 
      this.imageBox1.BackColor = System.Drawing.Color.Gray;
      this.imageBox1.Location = new System.Drawing.Point(95, 15);
      this.imageBox1.Margin = new System.Windows.Forms.Padding(2);
      this.imageBox1.Name = "imageBox1";
      this.imageBox1.Size = new System.Drawing.Size(194, 171);
      this.imageBox1.TabIndex = 2;
      this.imageBox1.TabStop = false;
      // 
      // zedGraphControl1
      // 
      this.zedGraphControl1.Location = new System.Drawing.Point(3, 242);
      this.zedGraphControl1.Name = "zedGraphControl1";
      this.zedGraphControl1.ScrollGrace = 0D;
      this.zedGraphControl1.ScrollMaxX = 0D;
      this.zedGraphControl1.ScrollMaxY = 0D;
      this.zedGraphControl1.ScrollMaxY2 = 0D;
      this.zedGraphControl1.ScrollMinX = 0D;
      this.zedGraphControl1.ScrollMinY = 0D;
      this.zedGraphControl1.ScrollMinY2 = 0D;
      this.zedGraphControl1.Size = new System.Drawing.Size(912, 256);
      this.zedGraphControl1.TabIndex = 3;
      // 
      // BTN_Stop
      // 
      this.BTN_Stop.Location = new System.Drawing.Point(5, 61);
      this.BTN_Stop.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_Stop.Name = "BTN_Stop";
      this.BTN_Stop.Size = new System.Drawing.Size(67, 24);
      this.BTN_Stop.TabIndex = 5;
      this.BTN_Stop.Text = "Stop";
      this.BTN_Stop.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(303, 72);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Luminance:";
      // 
      // CB_NoNoise
      // 
      this.CB_NoNoise.AutoSize = true;
      this.CB_NoNoise.Location = new System.Drawing.Point(5, 101);
      this.CB_NoNoise.Margin = new System.Windows.Forms.Padding(2);
      this.CB_NoNoise.Name = "CB_NoNoise";
      this.CB_NoNoise.Size = new System.Drawing.Size(69, 17);
      this.CB_NoNoise.TabIndex = 7;
      this.CB_NoNoise.Text = "Kill Noise";
      this.CB_NoNoise.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(9, 2);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(928, 527);
      this.tabControl1.TabIndex = 8;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.LightGray;
      this.tabPage1.Controls.Add(this.BTN_ToTab2);
      this.tabPage1.Controls.Add(this.trackBar1);
      this.tabPage1.Controls.Add(this.label9);
      this.tabPage1.Controls.Add(this.label8);
      this.tabPage1.Controls.Add(this.label7);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.CB_NoNoise);
      this.tabPage1.Controls.Add(this.BTN_OpenFile);
      this.tabPage1.Controls.Add(this.imageBox1);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.BTN_Stop);
      this.tabPage1.Controls.Add(this.zedGraphControl1);
      this.tabPage1.Controls.Add(this.BTN_Play);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
      this.tabPage1.Size = new System.Drawing.Size(920, 501);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      // 
      // BTN_ToTab2
      // 
      this.BTN_ToTab2.Location = new System.Drawing.Point(839, 9);
      this.BTN_ToTab2.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_ToTab2.Name = "BTN_ToTab2";
      this.BTN_ToTab2.Size = new System.Drawing.Size(76, 31);
      this.BTN_ToTab2.TabIndex = 17;
      this.BTN_ToTab2.Text = "Next";
      this.BTN_ToTab2.UseVisualStyleBackColor = true;
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(3, 191);
      this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(914, 45);
      this.trackBar1.TabIndex = 16;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(626, 26);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(55, 13);
      this.label9.TabIndex = 15;
      this.label9.Text = "Time End:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(622, 9);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(58, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "Time Start:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(598, 46);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(85, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Max Luminance:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(582, 86);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(100, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Median Luminance:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(590, 67);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(92, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Mean Luminance:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(308, 46);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Total time:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(297, 32);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Current time:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(308, 18);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Video File:";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.BTN_Back);
      this.tabPage2.Controls.Add(this.label13);
      this.tabPage2.Controls.Add(this.comboBox4);
      this.tabPage2.Controls.Add(this.label12);
      this.tabPage2.Controls.Add(this.comboBox3);
      this.tabPage2.Controls.Add(this.label11);
      this.tabPage2.Controls.Add(this.comboBox2);
      this.tabPage2.Controls.Add(this.label10);
      this.tabPage2.Controls.Add(this.comboBox1);
      this.tabPage2.Controls.Add(this.pictureBox1);
      this.tabPage2.Controls.Add(this.BTN_Ok);
      this.tabPage2.Controls.Add(this.BTN_Next);
      this.tabPage2.Controls.Add(this.BTN_Prev);
      this.tabPage2.Controls.Add(this.button1);
      this.tabPage2.Controls.Add(this.imageBox2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
      this.tabPage2.Size = new System.Drawing.Size(920, 501);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(4, 150);
      this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(41, 13);
      this.label13.TabIndex = 16;
      this.label13.Text = "label13";
      // 
      // comboBox4
      // 
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Location = new System.Drawing.Point(4, 166);
      this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new System.Drawing.Size(158, 21);
      this.comboBox4.TabIndex = 15;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(4, 104);
      this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(41, 13);
      this.label12.TabIndex = 14;
      this.label12.Text = "label12";
      // 
      // comboBox3
      // 
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new System.Drawing.Point(4, 120);
      this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size(158, 21);
      this.comboBox3.TabIndex = 13;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(4, 58);
      this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(41, 13);
      this.label11.TabIndex = 12;
      this.label11.Text = "label11";
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(4, 75);
      this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(158, 21);
      this.comboBox2.TabIndex = 11;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(4, 13);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(41, 13);
      this.label10.TabIndex = 10;
      this.label10.Text = "label10";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(4, 29);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(158, 21);
      this.comboBox1.TabIndex = 9;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
      this.pictureBox1.Location = new System.Drawing.Point(544, 2);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(375, 366);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
      this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
      // 
      // BTN_Ok
      // 
      this.BTN_Ok.Location = new System.Drawing.Point(675, 385);
      this.BTN_Ok.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_Ok.Name = "BTN_Ok";
      this.BTN_Ok.Size = new System.Drawing.Size(56, 19);
      this.BTN_Ok.TabIndex = 7;
      this.BTN_Ok.Text = "OK";
      this.BTN_Ok.UseVisualStyleBackColor = true;
      this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
      // 
      // BTN_Next
      // 
      this.BTN_Next.Location = new System.Drawing.Point(605, 385);
      this.BTN_Next.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_Next.Name = "BTN_Next";
      this.BTN_Next.Size = new System.Drawing.Size(56, 19);
      this.BTN_Next.TabIndex = 6;
      this.BTN_Next.Text = "Next";
      this.BTN_Next.UseVisualStyleBackColor = true;
      this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
      // 
      // BTN_Prev
      // 
      this.BTN_Prev.Location = new System.Drawing.Point(544, 385);
      this.BTN_Prev.Margin = new System.Windows.Forms.Padding(2);
      this.BTN_Prev.Name = "BTN_Prev";
      this.BTN_Prev.Size = new System.Drawing.Size(56, 19);
      this.BTN_Prev.TabIndex = 5;
      this.BTN_Prev.Text = "Prev";
      this.BTN_Prev.UseVisualStyleBackColor = true;
      this.BTN_Prev.Click += new System.EventHandler(this.BTN_Prev_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(4, 469);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(96, 19);
      this.button1.TabIndex = 4;
      this.button1.Text = "Export Data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageBox2
      // 
      this.imageBox2.BackColor = System.Drawing.Color.LightGray;
      this.imageBox2.Location = new System.Drawing.Point(166, 2);
      this.imageBox2.Margin = new System.Windows.Forms.Padding(2);
      this.imageBox2.Name = "imageBox2";
      this.imageBox2.Size = new System.Drawing.Size(375, 366);
      this.imageBox2.TabIndex = 2;
      this.imageBox2.TabStop = false;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.listBox1);
      this.tabPage3.Controls.Add(this.button3);
      this.tabPage3.Controls.Add(this.button2);
      this.tabPage3.Controls.Add(this.zedGraphControl2);
      this.tabPage3.Controls.Add(this.imageBox3);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
      this.tabPage3.Size = new System.Drawing.Size(920, 501);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "tabPage3";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(4, 353);
      this.listBox1.Margin = new System.Windows.Forms.Padding(2);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(914, 43);
      this.listBox1.TabIndex = 6;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(433, 329);
      this.button3.Margin = new System.Windows.Forms.Padding(2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(56, 19);
      this.button3.TabIndex = 5;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(433, 223);
      this.button2.Margin = new System.Windows.Forms.Padding(2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(56, 19);
      this.button2.TabIndex = 4;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // zedGraphControl2
      // 
      this.zedGraphControl2.Location = new System.Drawing.Point(434, 6);
      this.zedGraphControl2.Name = "zedGraphControl2";
      this.zedGraphControl2.ScrollGrace = 0D;
      this.zedGraphControl2.ScrollMaxX = 0D;
      this.zedGraphControl2.ScrollMaxY = 0D;
      this.zedGraphControl2.ScrollMaxY2 = 0D;
      this.zedGraphControl2.ScrollMinX = 0D;
      this.zedGraphControl2.ScrollMinY = 0D;
      this.zedGraphControl2.ScrollMinY2 = 0D;
      this.zedGraphControl2.Size = new System.Drawing.Size(484, 211);
      this.zedGraphControl2.TabIndex = 3;
      // 
      // imageBox3
      // 
      this.imageBox3.BackColor = System.Drawing.Color.DarkGray;
      this.imageBox3.Location = new System.Drawing.Point(4, 5);
      this.imageBox3.Margin = new System.Windows.Forms.Padding(2);
      this.imageBox3.Name = "imageBox3";
      this.imageBox3.Size = new System.Drawing.Size(424, 343);
      this.imageBox3.TabIndex = 2;
      this.imageBox3.TabStop = false;
      // 
      // BTN_Back
      // 
      this.BTN_Back.Location = new System.Drawing.Point(870, 373);
      this.BTN_Back.Name = "BTN_Back";
      this.BTN_Back.Size = new System.Drawing.Size(45, 23);
      this.BTN_Back.TabIndex = 17;
      this.BTN_Back.Text = "Back";
      this.BTN_Back.UseVisualStyleBackColor = true;
      this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(946, 547);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Offline Neuron Parser";
      ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BTN_OpenFile;
    private System.Windows.Forms.Button BTN_Play;
    private Emgu.CV.UI.ImageBox imageBox1;
    private ZedGraph.ZedGraphControl zedGraphControl1;
    private System.Windows.Forms.Button BTN_Stop;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox CB_NoNoise;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BTN_ToTab2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button BTN_Ok;
    private System.Windows.Forms.Button BTN_Next;
    private System.Windows.Forms.Button BTN_Prev;
    private System.Windows.Forms.Button button1;
    private Emgu.CV.UI.ImageBox imageBox2;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private ZedGraph.ZedGraphControl zedGraphControl2;
    private Emgu.CV.UI.ImageBox imageBox3;
    private System.Windows.Forms.Button BTN_Back;
  }
}

