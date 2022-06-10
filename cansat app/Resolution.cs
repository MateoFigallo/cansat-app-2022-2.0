using cansat_app;
using Cansat2021;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Prueba
using System.Threading;

using System.IO;
namespace cansat_app
{
    public partial class Resolution : Form
    {
        public static List<byte> buffer = new List<byte>();
        public static List<byte> bufferout = new List<byte>();
        public static List<string> telemetry = new List<string>();
        public static SerialPort _serialPort;
        public static string simfile;
        public static string export;
        public static int line;
        public static System.IO.StreamReader file ;
        public static int packetCount = 0;
        public Resolution()
        {
            InitializeComponent();
            simfile = textBox3.Text;
            export = "C:/cansat 2022/csv/";
        }

        
        static bool _continue;
        
        public  void init()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;  
            serialPort1.PortName = SetPortName(Form1.portname );
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_OnReceiveData);
            }

            _continue = true;
           

         
        }

        private  void port_OnReceiveData(object sender,
                                  SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            
            while (serialPort1.BytesToRead >1){
                var byteReaded = serialPort1.ReadByte();
                if (byteReaded == 0x7E)
                {
                    buffer.Clear();
                    telemetry.Clear();
                }
                buffer.Add((byte)byteReaded);

                if (buffer.Count >= 9)
                {
                    var buffer2 = buffer[2];
                    byte aux;
                    aux = (byte)(buffer[2] + 0x04);
                    if (aux == (byte)buffer.Count) //pregunta si ya tenemos toda la trama dentro de buffer
                    {
                        var message = "";
                        for (int i = 8; i < (buffer.Count - 1); i++)
                        {
                            message += (char)buffer[i];
                        }

                        // escribe el mensaje en el textbox1 para ser detectado por evento "textBox1_TextChanged"
                        SetText(message.Trim().Replace("NAN","0"));
                        //Split message and send to CsvHelper class to create or append 
                        telemetry = message.Split(',').ToList();
                        
                        telemetry[2] = packetCount.ToString();
                        Cansat2021.CsvHelper.writeCsvFromList(telemetry,export); //escribe los datos en un CSV file

                        
                        

                    }
                }

            }
        }

        public void fillForm(List<string> telemetry)
        {
            if (telemetry[3] == "C")
            {

                var Containerdata = new Container {
                    TeamId = telemetry[0],
                    MissionTime =telemetry[1],
                    PacketCount =packetCount.ToString(),
                    PacketType =telemetry[3],
                    Mode =telemetry[4],
                    TPReleased =telemetry[5],
                    Altitude =telemetry[6],
                    Temperature =telemetry[7],
                    Voltage =telemetry[8],
                    GpsTime =telemetry[9],
                    GpsLatitude =telemetry[10],
                    GpsLongitude =telemetry[11],
                    GpsAltitude =telemetry[12],
                    GpsSats =telemetry[13],
                    SoftwareState =telemetry[14],
                    CmdEcho =telemetry[15]
                };

                PutData(packetCount.ToString(), Containerdata.MissionTime, Containerdata.GpsTime, Containerdata.GpsLatitude, Containerdata.GpsLongitude, Containerdata.GpsAltitude
                    , Containerdata.GpsSats, Containerdata.Voltage, Containerdata.Altitude, Containerdata.Temperature, Containerdata.TPReleased);
            }
            else
            {
                var PayloadData = 
                    new SciencePayload
                    {
                        TeamId = telemetry[0],
                        MissionTime = telemetry[1],
                        PacketCount = packetCount.ToString(),
                        PacketType = telemetry[3],
                        TpAltitude = telemetry[4],
                        TpTemperature = telemetry[5],
                        TpVoltage = telemetry[6],
                        GYRO_R = telemetry[7],
                        GYRO_P = telemetry[8],
                        GYRO_Y = telemetry[9],
                        ACCEL_R = telemetry[10],
                        ACCEL_P = telemetry[11],
                        ACCEL_Y = telemetry[12],
                        MAG_R = telemetry[13].Trim() == "NAN" ? "0" : telemetry[13],
                        MAG_P = telemetry[14].Trim() == "NAN" ? "0" : telemetry[14],
                        MAG_Y = telemetry[15].Trim() == "NAN" ? "0" : telemetry[15],
                        POINTING_ERROR = telemetry[16].Trim() == "NAN" ? "0" : telemetry[16],
                        TpSoftwareState = telemetry[17]
                    };
                if(PayloadData.PacketType == "T" || PayloadData.PacketType =="SP1")
                {
                    PutDataPayload1(PayloadData.TpAltitude, PayloadData.TpTemperature, PayloadData.POINTING_ERROR);
                }
                
            }
        }
        public static string SetPortName(string defaultPortName)
        {
            try
            {
                string portName = "";

                Console.WriteLine("Available Ports:");
                foreach (string s in SerialPort.GetPortNames())
                {
                    Console.WriteLine("   {0}", s);
                }

                Console.Write("COM port({0}): ", defaultPortName);
                //portName = Console.ReadLine();

                if (portName == "")
                {
                    portName = defaultPortName;
                }
                return portName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            init();
            btnConnect.BackColor = Color.PaleGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            file = new System.IO.StreamReader(this.textBox3.Text);
            var datatx = "CMD,1064,SIM,ACTIVATE";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(datatx.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < datatx.Length; i++)
            {
                bufferout.Add((byte)datatx[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < datatx.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);




            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var datatx = "CMD,1064,SIM,ENABLE";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(datatx.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < datatx.Length; i++)
            {
                bufferout.Add((byte)datatx[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < datatx.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);




            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(textBox2.Text.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                bufferout.Add((byte)textBox2.Text[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < textBox2.Text.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
            if (textBox2.Text.ToUpper() == "CMD,1064,CX,OFF")
            {
                btnTelOn.BackColor = Color.White;
            }


        }

        private void Resolution_Load(object sender, EventArgs e)
        {

        }

        

        //FUNCION PUBLICA MANDAR DATOS A LABEL EN TIEMPO REALL
        public void PutData(string pc, string mt, string gpsT, string gpsLa, string gpsLo, string gpsA, string gpsS, string cV, string cA, string cT, string tpr)
        {
            packetCount_lbl.Text = pc;
            missionTime_lbl.Text = mt;
            gpsTime_lbl.Text = gpsT;
            gpsLatitude_lbl.Text = gpsLa;
            gpsLongitude_lbl.Text = gpsLo;
            gpsAltitude_lbl.Text = gpsA;
            gpsSats_lbl.Text = gpsS;
            voltage_lbl.Text = cV;
            cAltitude_lbl.Text = cA;
            cTemperature_lbl.Text = cT;
            if (tpr.Equals("R"))
            {
                P1green_img.Visible = true;
                P1red_img.Visible = false;

            }
            else
            {
                P1green_img.Visible = false;
                P1red_img.Visible = true;
            }
            
            Application.DoEvents();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    string cmd = "CMD,1064,CX,ON";
                    //cmd[1]  =  "CMD,1064,SP1X,ON"; esto es solo para probar

                    //foreach (string datatx in cmd)
                    //{
                    bufferout.Clear();
                    bufferout.Add(0x7E);
                    bufferout.Add(0x00);
                    bufferout.Add((byte)(cmd.Length + 5));
                    bufferout.Add(0x01);
                    bufferout.Add(0x01);
                    bufferout.Add(0x00); //0x01 
                    bufferout.Add(0x10); //0x11
                    bufferout.Add(0x00);

                    for (int i = 0; i < cmd.Length; i++)
                    {
                        bufferout.Add((byte)cmd[i]);
                    }
                    byte chkaux = 0;
                    for (int i = 3; i < cmd.Length + 8; i++)
                    {
                        chkaux += bufferout[i];
                    }
                    chkaux = (byte)(0xFF - chkaux);
                    bufferout.Add(chkaux);




                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();

                    }
                    serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
                }
                
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text;
            }
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Resolution.simfile= this.textBox3.Text;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            packetCount++;
            btnTelOn.BackColor = Color.PaleGreen;
            fillForm(textBox1.Text.Split(',').ToList()); //muestra los datos en pantalla
            Mqtt.Publish(textBox1.Text); //envia los datos al Servidor MQTT
            imgMqttRed.Visible =false;
            imgMqttGreen.Visible = true;
        }
            

        public void PutDataPayload1(string p1a,string p1t, string POINTING_ERROR)
        {
            P1A_lbl.Text = p1a;
            P1T_lbl.Text = p1t;
            P1RPM_lbl.Text = POINTING_ERROR;
        }


        private void groupBox9_Enter(object sender, EventArgs e)
        {
            
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            imgMqttRed.Visible = true;
            imgMqttGreen.Visible = false;
            btnConnect.BackColor = Color.White;
            btnTelOn.BackColor = Color.White;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string mensaje = "SERVO2,POS,180";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(mensaje.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < mensaje.Length; i++)
            {
                bufferout.Add((byte)mensaje[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < mensaje.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
            button3.BackColor = Color.PaleGreen;
            button2.BackColor = Color.White;
            button1.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "SERVO2,POS,90";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(mensaje.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < mensaje.Length; i++)
            {
                bufferout.Add((byte)mensaje[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < mensaje.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
            button3.BackColor = Color.White;
            button2.BackColor = Color.PaleGreen;
            button1.BackColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mensaje = "SERVO2,POS,0";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(mensaje.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x00); //0x01 
            bufferout.Add(0x10); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < mensaje.Length; i++)
            {
                bufferout.Add((byte)mensaje[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < mensaje.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
            button3.BackColor = Color.White;
            button2.BackColor = Color.White;
            button1.BackColor = Color.PaleGreen;
        }
    }
    public class Container
    {
        public string TeamId { get; set; }
        public string MissionTime { get; set; }
        public string PacketCount { get; set; }
        public string PacketType { get; set; }
        public string Mode { get; set; }
        public string TPReleased { get; set; }
        public string Altitude { get; set; }
        public string Temperature { get; set; }
        public string Voltage { get; set; }
        public string GpsTime { get; set; }
        public string GpsLatitude { get; set; }
        public string GpsLongitude { get; set; }
        public string GpsAltitude { get; set; }
        public string GpsSats { get; set; }
        public string SoftwareState { get; set; }
        public string CmdEcho { get; set; }

    }

    public class SciencePayload
    {
        public string TeamId { get; set; }
        public string MissionTime { get; set; }
        public string PacketCount { get; set; }
        public string PacketType { get; set; }
        public string TpAltitude { get; set; }
        public string TpTemperature { get; set; }
        public string TpVoltage { get; set; }
        public string GYRO_R { get; set; }
        public string GYRO_P { get; set; }
        public string GYRO_Y { get; set; }
        public string ACCEL_R { get; set; }
        public string ACCEL_P { get; set; }
        public string ACCEL_Y { get; set; }
        public string MAG_R { get; set; }
        public string MAG_P { get; set; }
        public string MAG_Y { get; set; }
        public string POINTING_ERROR { get; set; }
        public string TpSoftwareState { get; set; }
    }
}
