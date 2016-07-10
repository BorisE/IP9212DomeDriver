﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IP9212_emul
{

    // shutterOpen 0 Dome shutter status open  
    // shutterClosed 1 Dome shutter status closed  
    // shutterOpening 2 Dome shutter status opening  
    // shutterClosing 3 Dome shutter status closing  
    // shutterError 4 Dome shutter status error  

    public enum ShutterStatus
    {
        shutterOpen=0, // Dome shutter status open  
        shutterClosed = 1, // Dome shutter status closed  
        shutterOpening = 2, // Dome shutter status opening  
        shutterClosing = 3, // Dome shutter status closing  
        shutterError = 4 // Dome shutter status error  
    }

    class IP9212device
    {

        public const string SWITCH_PORT = "5";
        public const string OPENED_PORT = "6";
        public const string CLOSED_PORT = "7";

        DateTime RoofMoving_start;
        ShutterStatus RoofStatus = ShutterStatus.shutterError;

        public string username = "";
        public string pass = "";
        public string cmd = "";

        Dictionary<string, int> InputState = new Dictionary<string, int>();
        Dictionary<string, int> OutputState = new Dictionary<string, int>();
        private int MOVING_TIME=10;

        public IP9212device()
        {
            //init device
            InputState.Add("1", 1);
            InputState.Add("2", 1);
            InputState.Add("3", 1);
            InputState.Add("4", 1);
            InputState.Add("5", 1);
            InputState.Add("6", 1);
            InputState.Add("7", 1);
            InputState.Add("8", 1);

            OutputState.Add("1", 1);
            OutputState.Add("2", 1);
            OutputState.Add("3", 1);
            OutputState.Add("4", 1);
            OutputState.Add("5", 1);
            OutputState.Add("6", 1);
            OutputState.Add("7", 1);
            OutputState.Add("8", 1);


            InputState[OPENED_PORT] = 0;
            InputState[CLOSED_PORT] = 1;
            RoofStatus = ShutterStatus.shutterClosed;

            RoofMoving_start = DateTime.MinValue;

        }

        public void ParseParameters(string ParamStr)
        {
            //Set.cmd?user=usename+pass=passwordCMD=command

            //http://username:password@IPAddress/Set.cmd?CMD=Command

            //set.cmd?cmd=getio
            //set.cmd?cmd=getpower
            //set.cmd?cmd=setpower+P61=1

            //http://192.168.1.147/Set.cmd?CMD=setpower+P63=1

            //Get User name for case 2
            int iStartPos = ParamStr.IndexOf("user=");
            int iEndPos = ParamStr.IndexOf("+");
            iEndPos = (iEndPos < 0 ? ParamStr.Length : iEndPos) - 5;

            if (iStartPos < 0)
            {
                username = "";
            }
            else
            {
                username = ParamStr.Substring(iStartPos + 5, iEndPos - iStartPos);
            }


            //Get PASSWORD for case 2
            iStartPos = ParamStr.IndexOf("pass=") + 5;
            iEndPos = ParamStr.IndexOf("CMD=");
            iEndPos = (iEndPos < 0 ? ParamStr.Length : iEndPos);

            if (iStartPos < 0)
            {
                pass = "";
            }
            else
            {
                pass = ParamStr.Substring(iStartPos, iEndPos - iStartPos);
            }

            //Parse COMMAND
            iStartPos = ParamStr.IndexOf("CMD=");
            cmd = ParamStr.Substring(iStartPos + 4);
        }

        public string ParseCommand()
        {
            //emulation check
            RoofBehaviorEmulation_Check();

            string ret = "";
            if (cmd == "getio")
            {
                ret=ListInput();
            }
            else if (cmd == "getpower")
            {
                ret = ListOutput();
            }
            else if (cmd.IndexOf("setpower")>=0)
            {
                ret = setPower();
            }

            return ret;

        }


        private string ListOutput()
        {
            //P61=0,P62=1,P63=0,P64=0,P65=0,P66=0,P67=0,P68=1 HTTP/1 .0 200 OK Connection: close
            string str = "";
            foreach (KeyValuePair<string, int> pair in OutputState)
            {
                str += (str != "" ? ",":"")+ "P6" + pair.Key + "=" + pair.Value;
            }
            return str;
        }

        private string ListInput()
        {
            //P51=0, P52=1, P53=0, P54=1, P55=0, P56=1, P57=0, P58=1
            string str = "";
            foreach (KeyValuePair<string, int> pair in InputState)
            {
                str += (str != "" ? "," : "") + "P5" + pair.Key + "=" + pair.Value;
            }
            return str;
        }

        private string setPower()
        {
            //set.cmd?cmd=setpower+P61=1

            int iStartPos = cmd.IndexOf("+P6")+3;
            int iEndPos = cmd.IndexOf("=");
            iEndPos = (iEndPos < 0 ? cmd.Length : iEndPos);

            string outputPort_name = cmd.Substring(iStartPos, iEndPos-iStartPos);
            string outputPort_state = cmd.Substring(iEndPos+1);

            if (outputPort_name==SWITCH_PORT)
            {
                if (OutputState[SWITCH_PORT]==0 && outputPort_state=="1")
                {
                    RoofBehaviorEmulation_sendsignal();
                }
            }

            OutputState[outputPort_name] = Convert.ToInt32(outputPort_state);
            return "P6" + outputPort_name+"=" + OutputState[outputPort_name].ToString();
        }


        private void RoofBehaviorEmulation_sendsignal()
        {
            if (RoofStatus == ShutterStatus.shutterClosed)
            {
                //roof was closed

                RoofMoving_start = DateTime.Now;
                RoofStatus = ShutterStatus.shutterOpening;
                InputState[CLOSED_PORT] = 0;
                InputState[OPENED_PORT] = 0;
            }
            else if (RoofStatus == ShutterStatus.shutterOpen)
            {
                //roof was opened
                RoofMoving_start = DateTime.Now;
                RoofStatus = ShutterStatus.shutterClosing;
                InputState[OPENED_PORT] = 0;
                InputState[CLOSED_PORT] = 0;
            }
        }

        private void RoofBehaviorEmulation_Check()
        {
            //if roof is moving
            if (RoofStatus == ShutterStatus.shutterOpening || RoofStatus == ShutterStatus.shutterClosing)
            {
                TimeSpan passed = DateTime.Now - RoofMoving_start;

                //if move time exceeded
                if (passed.TotalSeconds> MOVING_TIME)
                {

                    //set move time to null
                    RoofMoving_start = DateTime.MinValue;

                    //change status
                    if (RoofStatus == ShutterStatus.shutterOpening)
                    {
                        RoofStatus = ShutterStatus.shutterOpen;
                        InputState[CLOSED_PORT] = 0;
                        InputState[OPENED_PORT] = 1;
                    }

                    if (RoofStatus == ShutterStatus.shutterClosing)
                    {
                        RoofStatus = ShutterStatus.shutterClosed;
                        InputState[CLOSED_PORT] = 1;
                        InputState[OPENED_PORT] = 0;
                    }


                }
            }
        }

        public string LittleHelp()
        {
            return "Roof: " + RoofStatus.ToString() + "<br>"
                + "Switch port " + SWITCH_PORT + " (state change: from 0 to 1)<br>"
                + "Opened port " + OPENED_PORT + " (state should be 1)<br>"
                + "Closed port " + CLOSED_PORT + " (state should be 1)<br>";
        }
    }
}