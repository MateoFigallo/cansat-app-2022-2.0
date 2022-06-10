﻿
namespace cansat_app
{
    partial class Resolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resolution));
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cTemperature_lbl = new System.Windows.Forms.Label();
            this.cAltitude_lbl = new System.Windows.Forms.Label();
            this.voltage_lbl = new System.Windows.Forms.Label();
            this.gpsSats_lbl = new System.Windows.Forms.Label();
            this.gpsAltitude_lbl = new System.Windows.Forms.Label();
            this.gpsLongitude_lbl = new System.Windows.Forms.Label();
            this.gpsLatitude_lbl = new System.Windows.Forms.Label();
            this.gpsTime_lbl = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.P1red_img = new System.Windows.Forms.PictureBox();
            this.P1green_img = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.P1RPM_lbl = new System.Windows.Forms.Label();
            this.P1T_lbl = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.P1A_lbl = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.imgMqttGreen = new System.Windows.Forms.PictureBox();
            this.imgMqttRed = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.packetCount_lbl = new System.Windows.Forms.Label();
            this.missionTime_lbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTelOn = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1red_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1green_img)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMqttGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMqttRed)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(11, 155);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Voltage =";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Altitude =";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "GPS Sats =";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "GPS Altitude =";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "GPS Longitude =";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "GPS Latitude =";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "GPS Time =";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cTemperature_lbl);
            this.groupBox1.Controls.Add(this.cAltitude_lbl);
            this.groupBox1.Controls.Add(this.voltage_lbl);
            this.groupBox1.Controls.Add(this.gpsSats_lbl);
            this.groupBox1.Controls.Add(this.gpsAltitude_lbl);
            this.groupBox1.Controls.Add(this.gpsLongitude_lbl);
            this.groupBox1.Controls.Add(this.gpsLatitude_lbl);
            this.groupBox1.Controls.Add(this.gpsTime_lbl);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 233);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Container";
            // 
            // cTemperature_lbl
            // 
            this.cTemperature_lbl.AutoSize = true;
            this.cTemperature_lbl.ForeColor = System.Drawing.Color.Black;
            this.cTemperature_lbl.Location = new System.Drawing.Point(121, 208);
            this.cTemperature_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cTemperature_lbl.Name = "cTemperature_lbl";
            this.cTemperature_lbl.Size = new System.Drawing.Size(125, 20);
            this.cTemperature_lbl.TabIndex = 40;
            this.cTemperature_lbl.Text = "cTemperature_lbl";
            // 
            // cAltitude_lbl
            // 
            this.cAltitude_lbl.AutoSize = true;
            this.cAltitude_lbl.ForeColor = System.Drawing.Color.Black;
            this.cAltitude_lbl.Location = new System.Drawing.Point(87, 183);
            this.cAltitude_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cAltitude_lbl.Name = "cAltitude_lbl";
            this.cAltitude_lbl.Size = new System.Drawing.Size(91, 20);
            this.cAltitude_lbl.TabIndex = 39;
            this.cAltitude_lbl.Text = "cAltitude_lbl";
            // 
            // voltage_lbl
            // 
            this.voltage_lbl.AutoSize = true;
            this.voltage_lbl.ForeColor = System.Drawing.Color.Black;
            this.voltage_lbl.Location = new System.Drawing.Point(87, 155);
            this.voltage_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voltage_lbl.Name = "voltage_lbl";
            this.voltage_lbl.Size = new System.Drawing.Size(83, 20);
            this.voltage_lbl.TabIndex = 38;
            this.voltage_lbl.Text = "voltage_lbl";
            // 
            // gpsSats_lbl
            // 
            this.gpsSats_lbl.AutoSize = true;
            this.gpsSats_lbl.ForeColor = System.Drawing.Color.Black;
            this.gpsSats_lbl.Location = new System.Drawing.Point(89, 129);
            this.gpsSats_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpsSats_lbl.Name = "gpsSats_lbl";
            this.gpsSats_lbl.Size = new System.Drawing.Size(87, 20);
            this.gpsSats_lbl.TabIndex = 37;
            this.gpsSats_lbl.Text = "gpsSats_lbl";
            // 
            // gpsAltitude_lbl
            // 
            this.gpsAltitude_lbl.AutoSize = true;
            this.gpsAltitude_lbl.ForeColor = System.Drawing.Color.Black;
            this.gpsAltitude_lbl.Location = new System.Drawing.Point(113, 103);
            this.gpsAltitude_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpsAltitude_lbl.Name = "gpsAltitude_lbl";
            this.gpsAltitude_lbl.Size = new System.Drawing.Size(107, 20);
            this.gpsAltitude_lbl.TabIndex = 36;
            this.gpsAltitude_lbl.Text = "gpsAltitude_lbl";
            // 
            // gpsLongitude_lbl
            // 
            this.gpsLongitude_lbl.AutoSize = true;
            this.gpsLongitude_lbl.ForeColor = System.Drawing.Color.Black;
            this.gpsLongitude_lbl.Location = new System.Drawing.Point(121, 75);
            this.gpsLongitude_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpsLongitude_lbl.Name = "gpsLongitude_lbl";
            this.gpsLongitude_lbl.Size = new System.Drawing.Size(121, 20);
            this.gpsLongitude_lbl.TabIndex = 35;
            this.gpsLongitude_lbl.Text = "gpsLongitude_lbl";
            // 
            // gpsLatitude_lbl
            // 
            this.gpsLatitude_lbl.AutoSize = true;
            this.gpsLatitude_lbl.ForeColor = System.Drawing.Color.Black;
            this.gpsLatitude_lbl.Location = new System.Drawing.Point(113, 51);
            this.gpsLatitude_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpsLatitude_lbl.Name = "gpsLatitude_lbl";
            this.gpsLatitude_lbl.Size = new System.Drawing.Size(110, 20);
            this.gpsLatitude_lbl.TabIndex = 34;
            this.gpsLatitude_lbl.Text = "gpsLatitude_lbl";
            // 
            // gpsTime_lbl
            // 
            this.gpsTime_lbl.AutoSize = true;
            this.gpsTime_lbl.ForeColor = System.Drawing.Color.Black;
            this.gpsTime_lbl.Location = new System.Drawing.Point(99, 29);
            this.gpsTime_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpsTime_lbl.Name = "gpsTime_lbl";
            this.gpsTime_lbl.Size = new System.Drawing.Size(89, 20);
            this.gpsTime_lbl.TabIndex = 14;
            this.gpsTime_lbl.Text = "gpsTime_lbl";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(11, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 20);
            this.label23.TabIndex = 33;
            this.label23.Text = "Temperature =";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.P1red_img);
            this.groupBox7.Controls.Add(this.P1green_img);
            this.groupBox7.Font = new System.Drawing.Font("Impact", 12F);
            this.groupBox7.ForeColor = System.Drawing.Color.Red;
            this.groupBox7.Location = new System.Drawing.Point(625, 34);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(232, 61);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Deployed";
            // 
            // P1red_img
            // 
            this.P1red_img.Image = ((System.Drawing.Image)(resources.GetObject("P1red_img.Image")));
            this.P1red_img.Location = new System.Drawing.Point(59, 25);
            this.P1red_img.Margin = new System.Windows.Forms.Padding(2);
            this.P1red_img.Name = "P1red_img";
            this.P1red_img.Size = new System.Drawing.Size(29, 22);
            this.P1red_img.TabIndex = 12;
            this.P1red_img.TabStop = false;
            // 
            // P1green_img
            // 
            this.P1green_img.Image = ((System.Drawing.Image)(resources.GetObject("P1green_img.Image")));
            this.P1green_img.Location = new System.Drawing.Point(148, 25);
            this.P1green_img.Margin = new System.Windows.Forms.Padding(2);
            this.P1green_img.Name = "P1green_img";
            this.P1green_img.Size = new System.Drawing.Size(29, 22);
            this.P1green_img.TabIndex = 17;
            this.P1green_img.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "POINTING ERROR =";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Temperature =";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Altitude =";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.P1RPM_lbl);
            this.groupBox3.Controls.Add(this.P1T_lbl);
            this.groupBox3.Controls.Add(this.f);
            this.groupBox3.Controls.Add(this.P1A_lbl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(626, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(232, 161);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tethered Payload";
            // 
            // P1RPM_lbl
            // 
            this.P1RPM_lbl.AutoSize = true;
            this.P1RPM_lbl.ForeColor = System.Drawing.Color.Black;
            this.P1RPM_lbl.Location = new System.Drawing.Point(144, 106);
            this.P1RPM_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P1RPM_lbl.Name = "P1RPM_lbl";
            this.P1RPM_lbl.Size = new System.Drawing.Size(76, 20);
            this.P1RPM_lbl.TabIndex = 46;
            this.P1RPM_lbl.Text = "P1RPM_lbl";
            // 
            // P1T_lbl
            // 
            this.P1T_lbl.AutoSize = true;
            this.P1T_lbl.ForeColor = System.Drawing.Color.Black;
            this.P1T_lbl.Location = new System.Drawing.Point(122, 76);
            this.P1T_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P1T_lbl.Name = "P1T_lbl";
            this.P1T_lbl.Size = new System.Drawing.Size(55, 20);
            this.P1T_lbl.TabIndex = 45;
            this.P1T_lbl.Text = "P1T_lbl";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(125, 106);
            this.f.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(0, 20);
            this.f.TabIndex = 44;
            // 
            // P1A_lbl
            // 
            this.P1A_lbl.AutoSize = true;
            this.P1A_lbl.ForeColor = System.Drawing.Color.Black;
            this.P1A_lbl.Location = new System.Drawing.Point(104, 42);
            this.P1A_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.P1A_lbl.Name = "P1A_lbl";
            this.P1A_lbl.Size = new System.Drawing.Size(55, 20);
            this.P1A_lbl.TabIndex = 43;
            this.P1A_lbl.Text = "P1A_lbl";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Font = new System.Drawing.Font("Impact", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(290, 226);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(303, 62);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CSV path";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 24);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 27);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "C:\\cansat 2022\\cvs\\";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.imgMqttGreen);
            this.groupBox8.Controls.Add(this.imgMqttRed);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Font = new System.Drawing.Font("Impact", 12F);
            this.groupBox8.ForeColor = System.Drawing.Color.Red;
            this.groupBox8.Location = new System.Drawing.Point(289, 34);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(105, 75);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "MQTT";
            // 
            // imgMqttGreen
            // 
            this.imgMqttGreen.Image = ((System.Drawing.Image)(resources.GetObject("imgMqttGreen.Image")));
            this.imgMqttGreen.Location = new System.Drawing.Point(63, 45);
            this.imgMqttGreen.Margin = new System.Windows.Forms.Padding(2);
            this.imgMqttGreen.Name = "imgMqttGreen";
            this.imgMqttGreen.Size = new System.Drawing.Size(30, 21);
            this.imgMqttGreen.TabIndex = 18;
            this.imgMqttGreen.TabStop = false;
            this.imgMqttGreen.Visible = false;
            // 
            // imgMqttRed
            // 
            this.imgMqttRed.Image = ((System.Drawing.Image)(resources.GetObject("imgMqttRed.Image")));
            this.imgMqttRed.Location = new System.Drawing.Point(63, 25);
            this.imgMqttRed.Margin = new System.Windows.Forms.Padding(2);
            this.imgMqttRed.Name = "imgMqttRed";
            this.imgMqttRed.Size = new System.Drawing.Size(30, 16);
            this.imgMqttRed.TabIndex = 12;
            this.imgMqttRed.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.packetCount_lbl);
            this.groupBox5.Controls.Add(this.missionTime_lbl);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Impact", 12F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(399, 34);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(201, 75);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            // 
            // packetCount_lbl
            // 
            this.packetCount_lbl.AutoSize = true;
            this.packetCount_lbl.ForeColor = System.Drawing.Color.Black;
            this.packetCount_lbl.Location = new System.Drawing.Point(129, 49);
            this.packetCount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packetCount_lbl.Name = "packetCount_lbl";
            this.packetCount_lbl.Size = new System.Drawing.Size(50, 20);
            this.packetCount_lbl.TabIndex = 13;
            this.packetCount_lbl.Text = "pc_lbl";
            // 
            // missionTime_lbl
            // 
            this.missionTime_lbl.AutoSize = true;
            this.missionTime_lbl.ForeColor = System.Drawing.Color.Black;
            this.missionTime_lbl.Location = new System.Drawing.Point(129, 18);
            this.missionTime_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.missionTime_lbl.Name = "missionTime_lbl";
            this.missionTime_lbl.Size = new System.Drawing.Size(51, 20);
            this.missionTime_lbl.TabIndex = 12;
            this.missionTime_lbl.Text = "mt_lbl";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 12F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(13, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Packet Count =";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Impact", 12F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(12, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Mission Time =";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSend);
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Red;
            this.groupBox9.Location = new System.Drawing.Point(73, 315);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox9.Size = new System.Drawing.Size(711, 133);
            this.groupBox9.TabIndex = 45;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Telemetry";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Impact", 12F);
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(552, 67);
            this.btnSend.Margin = new System.Windows.Forms.Padding(1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 31);
            this.btnSend.TabIndex = 42;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(428, 27);
            this.textBox2.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 27);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Impact", 12F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(28, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 20);
            this.label22.TabIndex = 43;
            this.label22.Text = "Command";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 12F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(28, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "Received";
            // 
            // btnTelOn
            // 
            this.btnTelOn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTelOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelOn.Font = new System.Drawing.Font("Impact", 12F);
            this.btnTelOn.ForeColor = System.Drawing.Color.Black;
            this.btnTelOn.Location = new System.Drawing.Point(364, 174);
            this.btnTelOn.Margin = new System.Windows.Forms.Padding(1);
            this.btnTelOn.Name = "btnTelOn";
            this.btnTelOn.Size = new System.Drawing.Size(134, 34);
            this.btnTelOn.TabIndex = 47;
            this.btnTelOn.Text = "TELEMETRY ON";
            this.btnTelOn.UseVisualStyleBackColor = true;
            this.btnTelOn.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(290, 124);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(132, 35);
            this.btnConnect.TabIndex = 46;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(447, 124);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(132, 35);
            this.btnDisconnect.TabIndex = 48;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 35);
            this.button3.TabIndex = 51;
            this.button3.Text = "180";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(136, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 35);
            this.button1.TabIndex = 52;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(73, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 35);
            this.button2.TabIndex = 53;
            this.button2.Text = "90";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Resolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnTelOn);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resolution";
            this.Text = "Resolution";
            this.Load += new System.EventHandler(this.Resolution_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.P1red_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1green_img)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMqttGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMqttRed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox P1red_img;
        private System.Windows.Forms.PictureBox P1green_img;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox imgMqttRed;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnTelOn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label packetCount_lbl;
        private System.Windows.Forms.Label missionTime_lbl;
        private System.Windows.Forms.Label cTemperature_lbl;
        private System.Windows.Forms.Label cAltitude_lbl;
        private System.Windows.Forms.Label voltage_lbl;
        private System.Windows.Forms.Label gpsSats_lbl;
        private System.Windows.Forms.Label gpsAltitude_lbl;
        private System.Windows.Forms.Label gpsLongitude_lbl;
        private System.Windows.Forms.Label gpsLatitude_lbl;
        private System.Windows.Forms.Label gpsTime_lbl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label P1RPM_lbl;
        private System.Windows.Forms.Label P1T_lbl;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label P1A_lbl;
        private System.Windows.Forms.PictureBox imgMqttGreen;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}