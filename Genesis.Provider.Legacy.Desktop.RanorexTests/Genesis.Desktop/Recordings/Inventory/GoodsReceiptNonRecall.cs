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
    ///The GoodsReceiptNonRecall recording.
    /// </summary>
    [TestModule("ae1d4807-d938-4a23-bdeb-ca72374d272d", ModuleType.Recording, 1)]
    public partial class GoodsReceiptNonRecall : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Genesis.Desktop.Genesis_DesktopRepository repository.
        /// </summary>
        public static global::Genesis.Desktop.Genesis_DesktopRepository repo = global::Genesis.Desktop.Genesis_DesktopRepository.Instance;

        static GoodsReceiptNonRecall instance = new GoodsReceiptNonRecall();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GoodsReceiptNonRecall()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GoodsReceiptNonRecall Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.CreateRequisition' at 50;29.", repo.FrmMain.CreateRequisitionInfo, new RecordItemIndex(0));
            repo.FrmMain.CreateRequisition.Click("50;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Open' at 10;13.", repo.FrmCreateRequisition.OpenInfo, new RecordItemIndex(1));
            repo.FrmCreateRequisition.Open.Click("10;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.Row2' at 5;10.", repo.GenesisAutomation.Row2Info, new RecordItemIndex(2));
            repo.GenesisAutomation.Row2.Click("5;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Open1' at 10;17.", repo.FrmCreateRequisition.Open1Info, new RecordItemIndex(3));
            repo.FrmCreateRequisition.Open1.Click("10;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.TextSelectItem' at 123;53.", repo.FrmCreateRequisition.TextSelectItemInfo, new RecordItemIndex(4));
            repo.FrmCreateRequisition.TextSelectItem.Click("123;53");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'act235' with focus on 'FrmCreateRequisition.TextSelectItem'.", repo.FrmCreateRequisition.TextSelectItemInfo, new RecordItemIndex(5));
            repo.FrmCreateRequisition.TextSelectItem.PressKeys("act235");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.Row1' at 5;9.", repo.GenesisAutomation.Row1Info, new RecordItemIndex(6));
            repo.GenesisAutomation.Row1.Click("5;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.AddRequisition' at 83;11.", repo.FrmCreateRequisition.AddRequisitionInfo, new RecordItemIndex(7));
            repo.FrmCreateRequisition.AddRequisition.Click("83;11");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'GenesisAutomation1.ButtonYes' at 32;7.", repo.GenesisAutomation1.ButtonYesInfo, new RecordItemIndex(8));
                repo.GenesisAutomation1.ButtonYes.Click("32;7");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmCreateRequisition.Confirm' at 75;12.", repo.FrmCreateRequisition.ConfirmInfo, new RecordItemIndex(9));
            repo.FrmCreateRequisition.Confirm.Click("75;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonOK' at 33;12.", repo.GenesisAutomation1.ButtonOKInfo, new RecordItemIndex(10));
            repo.GenesisAutomation1.ButtonOK.Click("33;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.NewOrders' at 52;10.", repo.FrmMain.NewOrdersInfo, new RecordItemIndex(11));
            repo.FrmMain.NewOrders.Click("52;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.ReleaseRow0' at 30;11.", repo.FrmMain.ReleaseRow0Info, new RecordItemIndex(12));
            repo.FrmMain.ReleaseRow0.Click("30;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonYes' at 38;14.", repo.GenesisAutomation1.ButtonYesInfo, new RecordItemIndex(13));
            repo.GenesisAutomation1.ButtonYes.Click("38;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.SplitControl.OutstandingOrders' at 75;17.", repo.FrmMain.SplitControl.OutstandingOrdersInfo, new RecordItemIndex(14));
            repo.FrmMain.SplitControl.OutstandingOrders.Click("75;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.SplitControl.GoodsReceiptRow0' at 32;14.", repo.FrmMain.SplitControl.GoodsReceiptRow0Info, new RecordItemIndex(15));
            repo.FrmMain.SplitControl.GoodsReceiptRow0.Click("32;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ReceiptRow0' at 25;11.", repo.PurchaseOrder.ReceiptRow0Info, new RecordItemIndex(16));
            repo.PurchaseOrder.ReceiptRow0.Click("25;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.TextMaskBox' at 93;7.", repo.PurchaseOrder.TextMaskBoxInfo, new RecordItemIndex(17));
            repo.PurchaseOrder.TextMaskBox.Click("93;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'non recall' with focus on 'PurchaseOrder.TextMaskBox'.", repo.PurchaseOrder.TextMaskBoxInfo, new RecordItemIndex(18));
            repo.PurchaseOrder.TextMaskBox.PressKeys("non recall");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Receive' at 105;16.", repo.PurchaseOrder.ReceiveInfo, new RecordItemIndex(19));
            repo.PurchaseOrder.Receive.Click("105;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonNo' at 43;15.", repo.GenesisAutomation1.ButtonNoInfo, new RecordItemIndex(20));
            repo.GenesisAutomation1.ButtonNo.Click("43;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.CloseWindow1' at 103;10.", repo.PurchaseOrder.CloseWindow1Info, new RecordItemIndex(21));
            repo.PurchaseOrder.CloseWindow1.Click("103;10");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}