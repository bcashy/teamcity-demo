﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Genesis.Desktop.Recordings.Inventory
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateRequisition recording.
    /// </summary>
    [TestModule("57fd6c8e-5d94-4ef1-ac82-a123b86c33fe", ModuleType.Recording, 1)]
    public partial class CreateRequisition : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Genesis.Desktop.Genesis_DesktopRepository repository.
        /// </summary>
        public static global::Genesis.Desktop.Genesis_DesktopRepository repo = global::Genesis.Desktop.Genesis_DesktopRepository.Instance;

        static CreateRequisition instance = new CreateRequisition();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateRequisition()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateRequisition Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.CreateRequisition' at 52;29.", repo.FrmMain.CreateRequisitionInfo, new RecordItemIndex(0));
            repo.FrmMain.CreateRequisition.Click("52;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Open' at 9;15.", repo.FrmCreateRequisition.OpenInfo, new RecordItemIndex(1));
            repo.FrmCreateRequisition.Open.Click("9;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.Row2' at 5;8.", repo.GenesisAutomation.Row2Info, new RecordItemIndex(2));
            repo.GenesisAutomation.Row2.Click("5;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Open1' at 7;15.", repo.FrmCreateRequisition.Open1Info, new RecordItemIndex(3));
            repo.FrmCreateRequisition.Open1.Click("7;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.Row1' at 6;10.", repo.GenesisAutomation.Row1Info, new RecordItemIndex(4));
            repo.GenesisAutomation.Row1.Click("6;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.AddRequisition' at 74;12.", repo.FrmCreateRequisition.AddRequisitionInfo, new RecordItemIndex(5));
            repo.FrmCreateRequisition.AddRequisition.Click("74;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Confirm' at 94;15.", repo.FrmCreateRequisition.ConfirmInfo, new RecordItemIndex(7));
            repo.FrmCreateRequisition.Confirm.Click("94;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'GenesisAutomation1.ButtonOK'.", repo.GenesisAutomation1.ButtonOKInfo, new RecordItemIndex(8));
            Validate.Exists(repo.GenesisAutomation1.ButtonOKInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonOK' at 42;8.", repo.GenesisAutomation1.ButtonOKInfo, new RecordItemIndex(9));
            repo.GenesisAutomation1.ButtonOK.Click("42;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}