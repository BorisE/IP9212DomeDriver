﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCOM.IP9212_rolloffroof2
{
    public partial class TestASCOM2 : Form
    {
        private string DefaultDriverId = "ASCOM.IP9212_rolloffroof3.Dome";
        public string DriverId;

        private ASCOM.DriverAccess.Dome driver;


        private Int32 caretPos = 0;
        public Int32 MAX_LOG_LINES = 500;


        public TestASCOM2()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            DriverId = ASCOM.DriverAccess.Dome.Choose("Dome");
            txtDriverId.Text = DriverId;
        }

        private void TestASCOM2_Load(object sender, EventArgs e)
        {
            DriverId = DefaultDriverId;
            txtDriverId.Text = DriverId;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            driver = new ASCOM.DriverAccess.Dome(DriverId);
            if (buttonConnect.Text == "Connect")
            {
                driver.Connected = true;
                timer1.Enabled = true;
                buttonOpenShutter.Enabled = true;
                buttonCloseShutter.Enabled = true;
                buttonConnect.Text = "Disconnect";


                txtDeviceAddr.Text = driver.Action("IPAddress", "");
            }
            else
            {
                timer1.Enabled = false;
                buttonOpenShutter.Enabled = false;
                buttonCloseShutter.Enabled = false;
                driver.Connected = false;
                buttonConnect.Text = "Connect";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver.OpenShutter();

        }

        private void buttonCloseShutter_Click(object sender, EventArgs e)
        {
            driver.CloseShutter();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            txtShutterStatus.Text=driver.ShutterStatus.ToString();
            string LogText = DateTime.Now.ToString("HH:mm:ss.f") + " : " + txtShutterStatus.Text + Environment.NewLine;
            caretPos = txtLog.SelectionStart;
            txtLog.AppendText(LogText);

            //Cut log window contents if it is greater then MAX_LOG_LINES
            var txtLogLinesArr = txtLog.Lines;
            if (txtLogLinesArr.Count() > MAX_LOG_LINES)
            {
                int NumOfSkipLines = txtLogLinesArr.Count() - MAX_LOG_LINES;
                var newLines = txtLogLinesArr.Skip(NumOfSkipLines);
                txtLog.Lines = newLines.ToArray();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (driver==null) driver = new ASCOM.DriverAccess.Dome(DriverId);
            driver.SetupDialog();
        }
    }
}
