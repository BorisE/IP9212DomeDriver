using ASCOM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCOM.IP9212_rolloffroof3
{
    class SafetyCheck
    {
        internal ASCOM.DriverAccess.Telescope objTelescopeDriver;
        
        private Dome DomeDriverLnk;

        //Settings
        #region Settings variables
        public static string TelescopeDriverId = "EQMOD_SIM.Telescope"; //for debug
        internal static string TelescopeDriverId_profilename = "SafetyCheck_TelescopeDriver";
        internal static string TelescopeDriverId_default = "";

        public static bool SafetyCheck_ParkedFlag = false;
        internal static string SafetyCheck_ParkedFlag_profilename = "SafetyCheckEnable";
        internal static string SafetyCheck_ParkedFlag_default = "false";

        public static bool SafetyCheck_PositionFlag = false;
        internal static string SafetyCheck_PositionFlag_profilename = "SafetyCheckEnable";
        internal static string SafetyCheck_PositionFlag_default = "false";

        public static double SafetyCheck_Azimuth_min = 0.0;
        internal static string SafetyCheck_Azimuth_min_profilename = "SafetyCheck_Azimuth_min";
        internal static string SafetyCheck_Azimuth_min_default = "0";
        public static double SafetyCheck_Azimuth_max = 10.0;
        internal static string SafetyCheck_Azimuth_max_profilename = "SafetyCheck_Azimuth_max";
        internal static string SafetyCheck_Azimuth_max_default = "10";
        public static double SafetyCheck_Altitude_min = -20.0;
        internal static string SafetyCheck_Altitude_min_profilename = "SafetyCheck_Altitude_min";
        internal static string SafetyCheck_Altitude_min_default = "-20";
        public static double SafetyCheck_Altitude_max = 5.0;
        internal static string SafetyCheck_Altitude_max_profilename = "SafetyCheck_Altitude_max";
        internal static string SafetyCheck_Altitude_max_default = "5";

        #endregion Settings variables


        /// <summary>
        /// Private variable to hold the trace logger object (creates a diagnostic log file with information that you specify)
        /// </summary>
        public static TraceLogger tl;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="DomeDriver_ext">Link to parent dome driver</param>
        public SafetyCheck(Dome DomeDriver_ext)
        {
            DomeDriverLnk = DomeDriver_ext;

            tl = Dome.tl;
            tl.LogMessage("SafetyCheck_constructor", "Done");
        }

        /// <summary>
        /// Main function to check safe situation
        /// </summary>
        /// <param name="ParkedFlag">return if parked conditon met</param>
        /// <param name="PositionAltFlag">return if alt postion conditon met</param>
        /// <param name="PositionAzFlag">return if az postion conditon met</param>
        /// <returns></returns>
        public bool? IsSafe(out bool? ParkedFlag, out bool? PositionAltFlag, out bool? PositionAzFlag)
        {
            tl.LogMessage("SafetyCheck_IsSafe", "Enter");
            bool? safeFlag = false;
            bool safeParked_Flag = false;
            bool safePosition_Flag = false;
            bool safePosition_Alt_Flag = false;
            bool safePosition_Az_Flag = false;

            //Is any check specified?
            if (SafetyCheck_ParkedFlag || SafetyCheck_PositionFlag)
            {
                try
                {
                    //Connect telescope
                    ConnectTelescope();

                    //Park Check
                    if (SafetyCheck_ParkedFlag)
                    {
                        //Check at park
                        if (objTelescopeDriver.AtPark)
                        {
                            tl.LogMessage("SafetyCheck_IsSafe", "Telesope at park. It is safe");
                            safeParked_Flag = true;
                        }
                        else
                        {
                            tl.LogMessage("SafetyCheck_IsSafe", "Telesope in't at park. It is unsafe!!!");
                            safeParked_Flag = false;
                        }
                    }else { safeParked_Flag = true; }

                    //Position check
                    if (SafetyCheck_PositionFlag)
                    {
                        //Check position
                        double alt = objTelescopeDriver.Altitude;
                        double az = objTelescopeDriver.Azimuth;

                        //Alt check
                        if (alt > SafetyCheck_Altitude_min && alt < SafetyCheck_Altitude_max)
                        {
                            safePosition_Alt_Flag = true;
                            tl.LogMessage("SafetyCheck_IsSafe", "Safe alt postion (ALT: " + Math.Round(alt, 1) + ", (" + SafetyCheck_Altitude_min + "," + SafetyCheck_Altitude_max + "))");
                        }
                        else
                        {
                            safePosition_Alt_Flag = false;
                            tl.LogMessage("SafetyCheck_IsSafe", "UNSAFE alt postion (ALT: " + Math.Round(alt, 1) + ", (" + SafetyCheck_Altitude_min + "," + SafetyCheck_Altitude_max + "))");
                        }

                        //Az check
                        if (az > SafetyCheck_Azimuth_min && alt < SafetyCheck_Azimuth_max)
                        {
                            safePosition_Az_Flag = true;
                            tl.LogMessage("SafetyCheck_IsSafe", "Safe azimuth postion (AZ: " + Math.Round(az, 1) + ", (" + SafetyCheck_Azimuth_min + "," + SafetyCheck_Azimuth_max + "))");
                        }
                        else
                        {
                            safePosition_Az_Flag = false;
                            tl.LogMessage("SafetyCheck_IsSafe", "UNSAFE azimuth postion (AZ: " + Math.Round(az, 1) + ", (" + SafetyCheck_Azimuth_min + "," + SafetyCheck_Azimuth_max + "))");
                        }

                        //General position check
                        safePosition_Flag = safePosition_Alt_Flag && safePosition_Az_Flag;
                    } else { safePosition_Flag = true; }

                    //ALL CONDITIONS
                    safeFlag = safeParked_Flag && safePosition_Flag;
                }
                catch (Exception e)
                {
                    tl.LogMessage("SafetyCheck_IsSafe", "Exception [" + e.Message + "] duirng safe check. Unsafe");
                    safeFlag = null;
                }



                try
                {
                    DisconnectTelescope();
                }
                catch (Exception e)
                {
                    tl.LogMessage("SafetyCheck_IsSafe", "Exception ["+e.Message+"] duirng telescope disconnect. Consider there is no influence at safety");
                }
            }

            tl.LogMessage("SafetyCheck_IsSafe", "Exit, Return value: " + safeFlag.ToString());

            ParkedFlag = safeParked_Flag;
            PositionAltFlag = safePosition_Alt_Flag;
            PositionAzFlag = safePosition_Az_Flag;

            return safeFlag;
        }


        internal void ConnectTelescope()
        {
            tl.LogMessage("SafetyCheck_ConnectTel", "Enter");

            objTelescopeDriver = new ASCOM.DriverAccess.Telescope(TelescopeDriverId);
            objTelescopeDriver.Connected = true;

            tl.LogMessage("SafetyCheck_ConnectTel", "Exit");

        }

        internal void DisconnectTelescope()
        {
            tl.LogMessage("SafetyCheck_Disconnect", "Enter");

            if (objTelescopeDriver != null)
            {
                objTelescopeDriver.Connected = false;
                objTelescopeDriver.Dispose();
                objTelescopeDriver = null;
            }

            tl.LogMessage("SafetyCheck_Disconnect", "Exit");

        }

        /// <summary>
        /// Standart dispose method
        /// </summary>
        internal void Dispose()
        {
            tl.LogMessage("SafetyCheck_Dispose", "Enter");
            DisconnectTelescope();
            tl.LogMessage("SafetyCheck_Dispose", "Exit");
        }
    }
}

