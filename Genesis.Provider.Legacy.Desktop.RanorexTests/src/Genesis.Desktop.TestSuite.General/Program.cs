/*
 * Created by Ranorex
 * User: BrianCashman
 * Date: 23/08/2019
 * Time: 10:50
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using Ranorex;
using Ranorex.Core.Testing;
using System;

namespace Genesis.Desktop.TestSuite.General
{
    class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            // Uncomment the following 2 lines if you want to automate Windows apps
            // by starting the test executable directly
            //if (Util.IsRestartRequiredForWinAppAccess)
            //    return Util.RestartWithUiAccess();

            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error = 0;

            try
            {
                error = TestSuiteRunner.Run(typeof(Program), Environment.CommandLine);
            }
            catch (Exception e)
            {
                Report.Error("Unexpected exception occurred: " + e.ToString());
                error = -1;
            }
            return error;
        }
    }
}
