using System.Windows.Forms;

namespace CloudSensor_BoltWood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_baudRate = new System.Windows.Forms.TextBox();
            this.textBox_DataBits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Stop = new System.Windows.Forms.TextBox();
            this.textBox_Parity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_RunStop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1_SkyBrt = new System.Windows.Forms.TextBox();
            this.textBox_wind = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_DewP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Humid = new System.Windows.Forms.TextBox();
            this.textBox_Press = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Rain = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Ambi = new System.Windows.Forms.TextBox();
            this.textBox_SkyAmbi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Cloud = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connection";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(206, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "●";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(787, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Baudrate";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(281, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Data Bits";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_baudRate
            // 
            this.textBox_baudRate.BackColor = System.Drawing.Color.Black;
            this.textBox_baudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_baudRate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_baudRate.ForeColor = System.Drawing.Color.Lime;
            this.textBox_baudRate.Location = new System.Drawing.Point(871, 31);
            this.textBox_baudRate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_baudRate.Name = "textBox_baudRate";
            this.textBox_baudRate.Size = new System.Drawing.Size(75, 26);
            this.textBox_baudRate.TabIndex = 12;
            this.textBox_baudRate.Text = "9600";
            this.textBox_baudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_DataBits
            // 
            this.textBox_DataBits.BackColor = System.Drawing.Color.Black;
            this.textBox_DataBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DataBits.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_DataBits.ForeColor = System.Drawing.Color.Lime;
            this.textBox_DataBits.Location = new System.Drawing.Point(335, 29);
            this.textBox_DataBits.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_DataBits.Name = "textBox_DataBits";
            this.textBox_DataBits.Size = new System.Drawing.Size(50, 26);
            this.textBox_DataBits.TabIndex = 12;
            this.textBox_DataBits.Text = "8";
            this.textBox_DataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(424, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stop bits";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(609, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Parity";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Stop
            // 
            this.textBox_Stop.BackColor = System.Drawing.Color.Black;
            this.textBox_Stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Stop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Stop.ForeColor = System.Drawing.Color.Lime;
            this.textBox_Stop.Location = new System.Drawing.Point(475, 30);
            this.textBox_Stop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Stop.Name = "textBox_Stop";
            this.textBox_Stop.Size = new System.Drawing.Size(82, 26);
            this.textBox_Stop.TabIndex = 12;
            this.textBox_Stop.Text = "1";
            this.textBox_Stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Parity
            // 
            this.textBox_Parity.BackColor = System.Drawing.Color.Black;
            this.textBox_Parity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Parity.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Parity.ForeColor = System.Drawing.Color.Lime;
            this.textBox_Parity.Location = new System.Drawing.Point(665, 31);
            this.textBox_Parity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Parity.Name = "textBox_Parity";
            this.textBox_Parity.Size = new System.Drawing.Size(82, 26);
            this.textBox_Parity.TabIndex = 12;
            this.textBox_Parity.Text = "None";
            this.textBox_Parity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(985, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Port";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_port);
            this.groupBox3.Controls.Add(this.textBox_baudRate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_DataBits);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox_Parity);
            this.groupBox3.Controls.Add(this.textBox_Stop);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(1209, 74);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Serial Port Open ";
            // 
            // comboBox_port
            // 
            this.comboBox_port.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox_port.DropDownHeight = 200;
            this.comboBox_port.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_port.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_port.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.IntegralHeight = false;
            this.comboBox_port.Location = new System.Drawing.Point(1049, 32);
            this.comboBox_port.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(126, 24);
            this.comboBox_port.TabIndex = 0;
            this.comboBox_port.SelectedIndexChanged += new System.EventHandler(this.comboBox_port_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 32);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1062, 260);
            this.listBox1.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(14, 529);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(1210, 318);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log Message";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(1092, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 250);
            this.button1.TabIndex = 0;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_LogClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_RunStop);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(15, 853);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(1209, 113);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // checkBox_RunStop
            // 
            this.checkBox_RunStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_RunStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_RunStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_RunStop.FlatAppearance.BorderSize = 0;
            this.checkBox_RunStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.checkBox_RunStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_RunStop.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.checkBox_RunStop.ForeColor = System.Drawing.Color.Black;
            this.checkBox_RunStop.Location = new System.Drawing.Point(45, 25);
            this.checkBox_RunStop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBox_RunStop.Name = "checkBox_RunStop";
            this.checkBox_RunStop.Size = new System.Drawing.Size(1119, 70);
            this.checkBox_RunStop.TabIndex = 13;
            this.checkBox_RunStop.Text = "Run";
            this.checkBox_RunStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_RunStop.UseVisualStyleBackColor = false;
            this.checkBox_RunStop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(1209, 421);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1_SkyBrt, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_wind, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_DewP, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(833, 46);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 328);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox1_SkyBrt
            // 
            this.textBox1_SkyBrt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1_SkyBrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_SkyBrt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1_SkyBrt.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_SkyBrt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1_SkyBrt.Location = new System.Drawing.Point(228, 224);
            this.textBox1_SkyBrt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1_SkyBrt.Multiline = true;
            this.textBox1_SkyBrt.Name = "textBox1_SkyBrt";
            this.textBox1_SkyBrt.Size = new System.Drawing.Size(108, 102);
            this.textBox1_SkyBrt.TabIndex = 6;
            this.textBox1_SkyBrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wind
            // 
            this.textBox_wind.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_wind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_wind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_wind.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_wind.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_wind.Location = new System.Drawing.Point(228, 114);
            this.textBox_wind.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_wind.Multiline = true;
            this.textBox_wind.Name = "textBox_wind";
            this.textBox_wind.Size = new System.Drawing.Size(108, 104);
            this.textBox_wind.TabIndex = 5;
            this.textBox_wind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::CloudSensor_BoltWood.Properties.Resources._7_dewPoint_100;
            this.pictureBox7.Location = new System.Drawing.Point(4, 2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(104, 106);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Image = global::CloudSensor_BoltWood.Properties.Resources._8_wind_100;
            this.pictureBox8.Location = new System.Drawing.Point(4, 112);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(104, 106);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Image = global::CloudSensor_BoltWood.Properties.Resources._9_skyBrightness_100;
            this.pictureBox9.Location = new System.Drawing.Point(4, 222);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(104, 104);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.YellowGreen;
            this.label14.Location = new System.Drawing.Point(116, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 110);
            this.label14.TabIndex = 2;
            this.label14.Text = "DewPoint (°C)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.YellowGreen;
            this.label15.Location = new System.Drawing.Point(116, 110);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 110);
            this.label15.TabIndex = 3;
            this.label15.Text = "Wind (m/s)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.YellowGreen;
            this.label16.Location = new System.Drawing.Point(116, 220);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 108);
            this.label16.TabIndex = 3;
            this.label16.Text = "Sky Brightness (lux)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_DewP
            // 
            this.textBox_DewP.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_DewP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DewP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_DewP.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_DewP.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_DewP.Location = new System.Drawing.Point(228, 4);
            this.textBox_DewP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_DewP.Multiline = true;
            this.textBox_DewP.Name = "textBox_DewP";
            this.textBox_DewP.Size = new System.Drawing.Size(108, 104);
            this.textBox_DewP.TabIndex = 4;
            this.textBox_DewP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_Humid, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Press, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Rain, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(439, 46);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 328);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox_Humid
            // 
            this.textBox_Humid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_Humid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Humid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_Humid.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Humid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Humid.Location = new System.Drawing.Point(228, 224);
            this.textBox_Humid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Humid.Multiline = true;
            this.textBox_Humid.Name = "textBox_Humid";
            this.textBox_Humid.Size = new System.Drawing.Size(108, 102);
            this.textBox_Humid.TabIndex = 6;
            this.textBox_Humid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Press
            // 
            this.textBox_Press.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_Press.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Press.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Press.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Press.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Press.Location = new System.Drawing.Point(228, 112);
            this.textBox_Press.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Press.Multiline = true;
            this.textBox_Press.Name = "textBox_Press";
            this.textBox_Press.Size = new System.Drawing.Size(108, 106);
            this.textBox_Press.TabIndex = 5;
            this.textBox_Press.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::CloudSensor_BoltWood.Properties.Resources._4_rain_100;
            this.pictureBox4.Location = new System.Drawing.Point(4, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 106);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::CloudSensor_BoltWood.Properties.Resources._5_air_pressure_100;
            this.pictureBox5.Location = new System.Drawing.Point(4, 112);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 106);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::CloudSensor_BoltWood.Properties.Resources._6_humidity_100;
            this.pictureBox6.Location = new System.Drawing.Point(4, 222);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(104, 104);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.YellowGreen;
            this.label7.Location = new System.Drawing.Point(116, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 110);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rain Rate (mm/h)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.YellowGreen;
            this.label10.Location = new System.Drawing.Point(116, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 110);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pressure (hPa)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.YellowGreen;
            this.label11.Location = new System.Drawing.Point(116, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 108);
            this.label11.TabIndex = 3;
            this.label11.Text = "Humidity (%)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Rain
            // 
            this.textBox_Rain.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_Rain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Rain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Rain.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Rain.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Rain.Location = new System.Drawing.Point(228, 2);
            this.textBox_Rain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Rain.Multiline = true;
            this.textBox_Rain.Name = "textBox_Rain";
            this.textBox_Rain.Size = new System.Drawing.Size(108, 106);
            this.textBox_Rain.TabIndex = 4;
            this.textBox_Rain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Ambi, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SkyAmbi, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Cloud, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 328);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Ambi
            // 
            this.textBox_Ambi.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Ambi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ambi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Ambi.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Ambi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Ambi.Location = new System.Drawing.Point(228, 222);
            this.textBox_Ambi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Ambi.Multiline = true;
            this.textBox_Ambi.Name = "textBox_Ambi";
            this.textBox_Ambi.Size = new System.Drawing.Size(108, 104);
            this.textBox_Ambi.TabIndex = 6;
            this.textBox_Ambi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_SkyAmbi
            // 
            this.textBox_SkyAmbi.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_SkyAmbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SkyAmbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SkyAmbi.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_SkyAmbi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_SkyAmbi.Location = new System.Drawing.Point(228, 112);
            this.textBox_SkyAmbi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_SkyAmbi.Multiline = true;
            this.textBox_SkyAmbi.Name = "textBox_SkyAmbi";
            this.textBox_SkyAmbi.Size = new System.Drawing.Size(108, 106);
            this.textBox_SkyAmbi.TabIndex = 5;
            this.textBox_SkyAmbi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CloudSensor_BoltWood.Properties.Resources._1_cloud_Sun_100;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::CloudSensor_BoltWood.Properties.Resources._2_skyAmbientTherature_100;
            this.pictureBox2.Location = new System.Drawing.Point(4, 112);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 106);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::CloudSensor_BoltWood.Properties.Resources._3_ambientTemperature_100;
            this.pictureBox3.Location = new System.Drawing.Point(4, 222);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 104);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(116, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 110);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cloud (%)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(116, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 110);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sky Ambient   (°C)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.YellowGreen;
            this.label6.Location = new System.Drawing.Point(116, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 108);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ambient    (°C)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Cloud
            // 
            this.textBox_Cloud.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Cloud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Cloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Cloud.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Cloud.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Cloud.Location = new System.Drawing.Point(228, 2);
            this.textBox_Cloud.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Cloud.Multiline = true;
            this.textBox_Cloud.Name = "textBox_Cloud";
            this.textBox_Cloud.Size = new System.Drawing.Size(108, 106);
            this.textBox_Cloud.TabIndex = 4;
            this.textBox_Cloud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1242, 985);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[환경계측부]  CloudSenser BoltWood  V1.0 ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label9;
        private TextBox textBox_baudRate;
        private TextBox textBox_DataBits;
        private Label label4;
        private Label label12;
        private TextBox textBox_Stop;
        private TextBox textBox_Parity;
        private Label label13;
        private GroupBox groupBox3;
        private ListBox listBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private ComboBox comboBox_port;
        private Button button1;
        private GroupBox groupBox1;
        private Timer timer1;
        private CheckBox checkBox_RunStop;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label14;
        private Label label15;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox textBox1_SkyBrt;
        private TextBox textBox_wind;
        private TextBox textBox_DewP;
        private TextBox textBox_Humid;
        private TextBox textBox_Press;
        private TextBox textBox_Rain;
        private TextBox textBox_Ambi;
        private TextBox textBox_SkyAmbi;
        private TextBox textBox_Cloud;
    }
}