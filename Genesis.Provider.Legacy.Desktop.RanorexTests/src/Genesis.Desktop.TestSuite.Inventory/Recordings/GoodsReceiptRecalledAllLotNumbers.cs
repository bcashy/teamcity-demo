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

namespace Genesis.Desktop.TestSuite.Inventory.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GoodsReceiptRecalledAllLotNumbers recording.
    /// </summary>
    [TestModule("1481a818-9edd-43dc-9bd7-9c7e103dfcc9", ModuleType.Recording, 1)]
    public partial class GoodsReceiptRecalledAllLotNumbers : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Genesis.Desktop.TestSuite.Inventory.Genesis_Desktop_TestSuite_InventoryRepository repository.
        /// </summary>
        public static global::Genesis.Desktop.TestSuite.Inventory.Genesis_Desktop_TestSuite_InventoryRepository repo = global::Genesis.Desktop.TestSuite.Inventory.Genesis_Desktop_TestSuite_InventoryRepository.Instance;

        static GoodsReceiptRecalledAllLotNumbers instance = new GoodsReceiptRecalledAllLotNumbers();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GoodsReceiptRecalledAllLotNumbers()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GoodsReceiptRecalledAllLotNumbers Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.CreateRequisition' at 45;23.", repo.FrmMain.CreateRequisitionInfo, new RecordItemIndex(0));
            repo.FrmMain.CreateRequisition.Click("45;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Open' at 8;14.", repo.FrmCreateRequisition.OpenInfo, new RecordItemIndex(1));
            repo.FrmCreateRequisition.Open.Click("8;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.Row1' at 5;6.", repo.GenesisAutomation.Row1Info, new RecordItemIndex(2));
            repo.GenesisAutomation.Row1.Click("5;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Open1' at 7;15.", repo.FrmCreateRequisition.Open1Info, new RecordItemIndex(3));
            repo.FrmCreateRequisition.Open1.Click("7;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.TextMaskBox' at 138;6.", repo.GenesisAutomation.TextMaskBoxInfo, new RecordItemIndex(4));
            repo.GenesisAutomation.TextMaskBox.Click("138;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fsl' with focus on 'GenesisAutomation.TextMaskBox'.", repo.GenesisAutomation.TextMaskBoxInfo, new RecordItemIndex(5));
            repo.GenesisAutomation.TextMaskBox.PressKeys("fsl");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '532' with focus on 'GenesisAutomation.TextMaskBox'.", repo.GenesisAutomation.TextMaskBoxInfo, new RecordItemIndex(6));
            repo.GenesisAutomation.TextMaskBox.PressKeys("532");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.Row1' at 7;7.", repo.GenesisAutomation.Row1Info, new RecordItemIndex(7));
            repo.GenesisAutomation.Row1.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.AddRequisition' at 75;12.", repo.FrmCreateRequisition.AddRequisitionInfo, new RecordItemIndex(8));
            repo.FrmCreateRequisition.AddRequisition.Click("75;12");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'GenesisAutomation1.ButtonYes' at 34;10.", repo.GenesisAutomation1.ButtonYesInfo, new RecordItemIndex(9));
                repo.GenesisAutomation1.ButtonYes.Click("34;10");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Confirm' at 95;16.", repo.FrmCreateRequisition.ConfirmInfo, new RecordItemIndex(10));
            repo.FrmCreateRequisition.Confirm.Click("95;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonOK' at 41;12.", repo.GenesisAutomation1.ButtonOKInfo, new RecordItemIndex(11));
            repo.GenesisAutomation1.ButtonOK.Click("41;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.NewOrders' at 57;13.", repo.FrmMain.NewOrdersInfo, new RecordItemIndex(12));
            repo.FrmMain.NewOrders.Click("57;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.ReleaseRow0' at 28;20.", repo.FrmMain.ReleaseRow0Info, new RecordItemIndex(13));
            repo.FrmMain.ReleaseRow0.Click("28;20");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'GenesisAutomation1.ButtonYes' at 36;4.", repo.GenesisAutomation1.ButtonYesInfo, new RecordItemIndex(14));
                repo.GenesisAutomation1.ButtonYes.Click("36;4");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'PurchaseOrder.ButtonOK' at 36;4.", repo.PurchaseOrder.ButtonOKInfo, new RecordItemIndex(15));
                repo.PurchaseOrder.ButtonOK.Click("36;4");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.SplitControl.OutstandingOrders' at 29;15.", repo.FrmMain.SplitControl.OutstandingOrdersInfo, new RecordItemIndex(16));
            repo.FrmMain.SplitControl.OutstandingOrders.Click("29;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.SplitControl.GoodsReceiptRow0' at 27;21.", repo.FrmMain.SplitControl.GoodsReceiptRow0Info, new RecordItemIndex(17));
            repo.FrmMain.SplitControl.GoodsReceiptRow0.Click("27;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ReceiptRow0' at 23;11.", repo.PurchaseOrder.ReceiptRow0Info, new RecordItemIndex(18));
            repo.PurchaseOrder.ReceiptRow0.Click("23;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.TextMaskBox' at 75;12.", repo.PurchaseOrder.TextMaskBoxInfo, new RecordItemIndex(19));
            repo.PurchaseOrder.TextMaskBox.Click("75;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'recall all lot numbers' with focus on 'PurchaseOrder.TextMaskBox'.", repo.PurchaseOrder.TextMaskBoxInfo, new RecordItemIndex(20));
            repo.PurchaseOrder.TextMaskBox.PressKeys("recall all lot numbers");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Receive' at 106;23.", repo.PurchaseOrder.ReceiveInfo, new RecordItemIndex(21));
            repo.PurchaseOrder.Receive.Click("106;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'GenesisAutomation1.ButtonYes'.", repo.GenesisAutomation1.ButtonYesInfo, new RecordItemIndex(22));
            Validate.Exists(repo.GenesisAutomation1.ButtonYesInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonYes' at 34;13.", repo.GenesisAutomation1.ButtonYesInfo, new RecordItemIndex(23));
            repo.GenesisAutomation1.ButtonYes.Click("34;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonNo' at 35;14.", repo.GenesisAutomation1.ButtonNoInfo, new RecordItemIndex(24));
            repo.GenesisAutomation1.ButtonNo.Click("35;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.CloseWindow1' at 80;11.", repo.PurchaseOrder.CloseWindow1Info, new RecordItemIndex(25));
            repo.PurchaseOrder.CloseWindow1.Click("80;11");
            Delay.Milliseconds(16230);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
