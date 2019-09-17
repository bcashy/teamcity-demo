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

namespace Genesis.Desktop.TestSuite.MasterData.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateNewItemWizardTissues recording.
    /// </summary>
    [TestModule("3fec006e-8c7c-4836-a46e-ab3ff9e7fba3", ModuleType.Recording, 1)]
    public partial class CreateNewItemWizardTissues : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Genesis.Desktop.TestSuite.MasterData.Genesis_Desktop_TestSuite_MasterDataRepository repository.
        /// </summary>
        public static global::Genesis.Desktop.TestSuite.MasterData.Genesis_Desktop_TestSuite_MasterDataRepository repo = global::Genesis.Desktop.TestSuite.MasterData.Genesis_Desktop_TestSuite_MasterDataRepository.Instance;

        static CreateNewItemWizardTissues instance = new CreateNewItemWizardTissues();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewItemWizardTissues()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewItemWizardTissues Instance
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.Orders' at 22;17.", repo.GenesisAutomation1.OrdersInfo, new RecordItemIndex(0));
            repo.GenesisAutomation1.Orders.Click("22;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.NewItemWizard' at 48;49.", repo.GenesisAutomation1.NewItemWizardInfo, new RecordItemIndex(1));
            repo.GenesisAutomation1.NewItemWizard.Click("48;49");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.BtnNext' at 66;14.", repo.PurchaseOrder.BtnNextInfo, new RecordItemIndex(2));
            repo.PurchaseOrder.BtnNext.Click("66;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlPreferredSupplier' at 311;14.", repo.PurchaseOrder.UcStep1Item.DdlPreferredSupplierInfo, new RecordItemIndex(3));
            repo.PurchaseOrder.UcStep1Item.DdlPreferredSupplier.Click("311;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'acu' with focus on 'GenesisAutomation'.", repo.GenesisAutomation.SelfInfo, new RecordItemIndex(4));
            repo.GenesisAutomation.Self.EnsureVisible();
            Keyboard.Press("acu");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't' with focus on 'GenesisAutomation'.", repo.GenesisAutomation.SelfInfo, new RecordItemIndex(5));
            repo.GenesisAutomation.Self.EnsureVisible();
            Keyboard.Press("t");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.GridControl' at 503;37.", repo.GenesisAutomation.GridControlInfo, new RecordItemIndex(6));
            repo.GenesisAutomation.GridControl.Click("503;37");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.TextMaskBox3' at 199;3.", repo.PurchaseOrder.UcStep1Item.TextMaskBox3Info, new RecordItemIndex(7));
            repo.PurchaseOrder.UcStep1Item.TextMaskBox3.Click("199;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad7 down}{NumPad8 down}{NumPad7 up}{NumPad7 down}{NumPad8 up}{NumPad8 down}{NumPad7 up}{NumPad7 down}{NumPad8 up}{NumPad7 up}' with focus on 'PurchaseOrder.UcStep1Item.TextMaskBox3'.", repo.PurchaseOrder.UcStep1Item.TextMaskBox3Info, new RecordItemIndex(8));
            repo.PurchaseOrder.UcStep1Item.TextMaskBox3.PressKeys("{NumPad7 down}{NumPad8 down}{NumPad7 up}{NumPad7 down}{NumPad8 up}{NumPad8 down}{NumPad7 up}{NumPad7 down}{NumPad8 up}{NumPad7 up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.TextMaskBox4' at 826;10.", repo.PurchaseOrder.UcStep1Item.TextMaskBox4Info, new RecordItemIndex(9));
            repo.PurchaseOrder.UcStep1Item.TextMaskBox4.Click("826;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'PurchaseOrder.UcStep1Item.TextMaskBox4'.", repo.PurchaseOrder.UcStep1Item.TextMaskBox4Info, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.PurchaseOrder.UcStep1Item.TextMaskBox4);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{RShiftKey down}{Home}{RShiftKey up}Test KIT' with focus on 'PurchaseOrder.UcStep1Item.TextMaskBox4'.", repo.PurchaseOrder.UcStep1Item.TextMaskBox4Info, new RecordItemIndex(11));
            repo.PurchaseOrder.UcStep1Item.TextMaskBox4.PressKeys("{RShiftKey down}{Home}{RShiftKey up}Test KIT");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.TESTKIT' at 610;14.", repo.GenesisAutomation.TESTKITInfo, new RecordItemIndex(12));
            repo.GenesisAutomation.TESTKIT.Click("610;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlItemGroup' at 306;15.", repo.PurchaseOrder.UcStep1Item.DdlItemGroupInfo, new RecordItemIndex(13));
            repo.PurchaseOrder.UcStep1Item.DdlItemGroup.Click("306;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GenesisAutomation.DescriptionRow6' at 112;8.", repo.GenesisAutomation.DescriptionRow6Info, new RecordItemIndex(14));
            repo.GenesisAutomation.DescriptionRow6.MoveTo("112;8");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GenesisAutomation.DescriptionRow6' at 420;41.", repo.GenesisAutomation.DescriptionRow6Info, new RecordItemIndex(15));
            repo.GenesisAutomation.DescriptionRow6.MoveTo("420;41");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlItemStatus' at 314;15.", repo.PurchaseOrder.UcStep1Item.DdlItemStatusInfo, new RecordItemIndex(16));
            repo.PurchaseOrder.UcStep1Item.DdlItemStatus.Click("314;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.GridControl' at 408;36.", repo.GenesisAutomation.GridControlInfo, new RecordItemIndex(17));
            repo.GenesisAutomation.GridControl.Click("408;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlItemCategory' at 379;14.", repo.PurchaseOrder.UcStep1Item.DdlItemCategoryInfo, new RecordItemIndex(18));
            repo.PurchaseOrder.UcStep1Item.DdlItemCategory.Click("379;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.GridControl' at 340;91.", repo.GenesisAutomation.GridControlInfo, new RecordItemIndex(19));
            repo.GenesisAutomation.GridControl.Click("340;91");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlItemBodySide' at 310;14.", repo.PurchaseOrder.UcStep1Item.DdlItemBodySideInfo, new RecordItemIndex(20));
            repo.PurchaseOrder.UcStep1Item.DdlItemBodySide.Click("310;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.GridControl' at 425;110.", repo.GenesisAutomation.GridControlInfo, new RecordItemIndex(21));
            repo.GenesisAutomation.GridControl.Click("425;110");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlItemBodySite' at 373;12.", repo.PurchaseOrder.UcStep1Item.DdlItemBodySiteInfo, new RecordItemIndex(22));
            repo.PurchaseOrder.UcStep1Item.DdlItemBodySite.Click("373;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.GridControl' at 401;40.", repo.GenesisAutomation.GridControlInfo, new RecordItemIndex(23));
            repo.GenesisAutomation.GridControl.Click("401;40");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlAccountCode' at 309;15.", repo.PurchaseOrder.UcStep1Item.DdlAccountCodeInfo, new RecordItemIndex(24));
            repo.PurchaseOrder.UcStep1Item.DdlAccountCode.Click("309;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation.GridControl' at 512;120.", repo.GenesisAutomation.GridControlInfo, new RecordItemIndex(25));
            repo.GenesisAutomation.GridControl.Click("512;120");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'PurchaseOrder.UcStep1Item.TextBoxMaskBox1' at 287;7.", repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox1Info, new RecordItemIndex(26));
            repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox1.MoveTo("287;7");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'PurchaseOrder.UcStep1Item.TextBoxMaskBox1' at 295;-1.", repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox1Info, new RecordItemIndex(27));
            repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox1.MoveTo("295;-1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'PurchaseOrder.UcStep1Item.TextBoxMaskBox' at 268;8.", repo.PurchaseOrder.UcStep1Item.TextBoxMaskBoxInfo, new RecordItemIndex(28));
            repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox.MoveTo("268;8");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad5}' with focus on 'PurchaseOrder.UcStep1Item.TextBoxMaskBox1'.", repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox1Info, new RecordItemIndex(29));
            repo.PurchaseOrder.UcStep1Item.TextBoxMaskBox1.PressKeys("{NumPad5}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.UcStep1Item.DdlTemperatureType' at 307;11.", repo.PurchaseOrder.UcStep1Item.DdlTemperatureTypeInfo, new RecordItemIndex(30));
            repo.PurchaseOrder.UcStep1Item.DdlTemperatureType.Click("307;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation' at 167;73.", repo.GenesisAutomation.SelfInfo, new RecordItemIndex(31));
            repo.GenesisAutomation.Self.Click("167;73");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.BtnNext' at 69;19.", repo.PurchaseOrder.BtnNextInfo, new RecordItemIndex(32));
            repo.PurchaseOrder.BtnNext.Click("69;19");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}