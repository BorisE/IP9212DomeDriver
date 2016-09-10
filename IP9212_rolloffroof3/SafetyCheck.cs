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

        public static bool SafetyCheckEnabledFlag = false;
        internal static string SafetyCheckEnabledFlag_profilename = "SafetyCheckEnable";
        internal static string SafetyCheckEnabledFlag_default = "false";
        #endregion Settings variables


        /// <summary>
        /// Private variable to hold the trace logger object (creates a diagnostic log file with information that you specify)
        /// </summary>
        public static TraceLogger tl;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TelescopeDriverId">Telescope driver id to check</param>
        /// <param name="DomeDriver_ext">Link to parent dome driver</param>
        public SafetyCheck(Dome DomeDriver_ext)
        {
            DomeDriverLnk = DomeDriver_ext;

            tl = DomeDriverLnk.tl;
            tl.LogMessage("SafetyCheck_constructor", "Done");
        }

        public bool IsSafe()
        {
            tl.LogMessage("SafetyCheck_IsSafe", "Enter");
            bool safeFlag = false;

            try
            {
                ConnectTelescope();

                if (objTelescopeDriver.AtPark)
                {
                    tl.LogMessage("SafetyCheck_IsSafe", "Telesope at park. It is safe");
                    safeFlag = true;
                }else
                {
                    tl.LogMessage("SafetyCheck_IsSafe", "Telesope in't at park. It is unsafe!!!!!!");
                    safeFlag = false;
                }
            }
            catch (Exception e)
            {
                tl.LogMessage("SafetyCheck_IsSafe", "Exception duirng safe check. Unsafe");
                safeFlag = false;
            }

            try
            {
                DisconnectTelescope();
            }
            catch
            {
                tl.LogMessage("SafetyCheck_IsSafe", "Exception duirng telescope disconnect. Consider there is no influence at safety");
            }


            tl.LogMessage("SafetyCheck_IsSafe", "Exit, Return value: " + safeFlag.ToString());

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

            objTelescopeDriver.Connected = true;
            objTelescopeDriver.Dispose();
            objTelescopeDriver = null;

            tl.LogMessage("SafetyCheck_Disconnect", "Exit");

        }


    }
}
