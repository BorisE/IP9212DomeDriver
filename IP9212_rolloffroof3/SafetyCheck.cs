using ASCOM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCOM.IP9212_rolloffroof3
{
    class SafetyCheck
    {
        string DriverId = "";
        private ASCOM.DriverAccess.Telescope driver;

        private Dome DomeDriverLnk;


        /// <summary>
        /// Private variable to hold the trace logger object (creates a diagnostic log file with information that you specify)
        /// </summary>
        public static TraceLogger tl;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TelescopeDriverId">Telescope driver id to check</param>
        /// <param name="DomeDriver_ext">Link to parent dome driver</param>
        public SafetyCheck(string TelescopeDriverId,  Dome DomeDriver_ext)
        {
            DriverId = TelescopeDriverId;
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

                if (driver.AtPark)
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

            driver = new ASCOM.DriverAccess.Telescope(DriverId);
            driver.Connected = true;

            tl.LogMessage("SafetyCheck_ConnectTel", "Exit");

        }

        internal void DisconnectTelescope()
        {
            tl.LogMessage("SafetyCheck_Disconnect", "Enter");

            driver.Connected = true;
            driver.Dispose();
            driver = null;

            tl.LogMessage("SafetyCheck_Disconnect", "Exit");

        }


    }
}
