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
    ///The AddNewItemImportMultiple recording.
    /// </summary>
    [TestModule("755fd6fc-f9aa-483e-9691-663b4b3b40a4", ModuleType.Recording, 1)]
    public partial class AddNewItemImportMultiple : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Genesis.Desktop.TestSuite.MasterData.Genesis_Desktop_TestSuite_MasterDataRepository repository.
        /// </summary>
        public static global::Genesis.Desktop.TestSuite.MasterData.Genesis_Desktop_TestSuite_MasterDataRepository repo = global::Genesis.Desktop.TestSuite.MasterData.Genesis_Desktop_TestSuite_MasterDataRepository.Instance;

        static AddNewItemImportMultiple instance = new AddNewItemImportMultiple();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddNewItemImportMultiple()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddNewItemImportMultiple Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.MasterData' at 43;8.", repo.FrmMain.MasterDataInfo, new RecordItemIndex(0));
            repo.FrmMain.MasterData.Click("43;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.RefreshTasks' at 24;28.", repo.GenesisAutomation1.RefreshTasksInfo, new RecordItemIndex(1));
            repo.GenesisAutomation1.RefreshTasks.Click("24;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ImportData' at 95;14.", repo.GenesisAutomation1.ImportDataInfo, new RecordItemIndex(2));
            repo.GenesisAutomation1.ImportData.Click("95;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.GetTemplate' at 102;11.", repo.PurchaseOrder.GetTemplateInfo, new RecordItemIndex(3));
            repo.PurchaseOrder.GetTemplate.Click("102;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ButtonSave' at 45;9.", repo.PurchaseOrder.ButtonSaveInfo, new RecordItemIndex(4));
            repo.PurchaseOrder.ButtonSave.Click("45;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ButtonYes' at 32;9.", repo.PurchaseOrder.ButtonYesInfo, new RecordItemIndex(5));
            repo.PurchaseOrder.ButtonYes.Click("32;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ButtonYes1' at 37;11.", repo.PurchaseOrder.ButtonYes1Info, new RecordItemIndex(6));
            repo.PurchaseOrder.ButtonYes1.Click("37;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Close1' at 10;13.", repo.PurchaseOrder.Close1Info, new RecordItemIndex(7));
            repo.PurchaseOrder.Close1.Click("10;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.Ribbon' at 1838;24.", repo.FrmMain.RibbonInfo, new RecordItemIndex(8));
            repo.FrmMain.Ribbon.Click("1838;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(9));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ItemImportTemplate1.CellF5' at 45;0.", repo.PurchaseOrder.ItemImportTemplate1.CellF5Info, new RecordItemIndex(10));
            repo.PurchaseOrder.ItemImportTemplate1.CellF5.Click("45;0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Up}{Up}{Up}{Up}{Up}{Up}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(11));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Up}{Up}{Up}{Up}{Up}{Up}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(12));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Down}{Down}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(13));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}{Down}{Down}{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(14));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(15));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(16));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}{Delete}{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ItemImportTemplate1.CellC4' at 39;116.", repo.PurchaseOrder.ItemImportTemplate1.CellC4Info, new RecordItemIndex(17));
            repo.PurchaseOrder.ItemImportTemplate1.CellC4.Click("39;116");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'MOBMD1' with focus on 'PurchaseOrder.ItemImportTemplate1.CellC4'.", repo.PurchaseOrder.ItemImportTemplate1.CellC4Info, new RecordItemIndex(18));
            repo.PurchaseOrder.ItemImportTemplate1.CellC4.PressKeys("MOBMD1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder.ItemImportTemplate1.CellC4'.", repo.PurchaseOrder.ItemImportTemplate1.CellC4Info, new RecordItemIndex(20));
            repo.PurchaseOrder.ItemImportTemplate1.CellC4.PressKeys("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'B27RQ' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(21));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("B27RQ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(22));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(23));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'MOBMD1' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(24));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("MOBMD1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(25));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(26));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'MULTIPLE ITEM IMPORT TEST' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(27));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("MULTIPLE ITEM IMPORT TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}{Right}{Right}{Right}1{Right}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(28));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}{Right}{Right}{Right}1{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'TEST' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(29));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}1{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(30));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}1{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7380' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(31));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("7380");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(32));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AAA{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(33));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("AAA{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '218{Right}{Right}{Right}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(34));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("218{Right}{Right}{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(35));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(36));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ItemImportTemplate1.CellC5' at 50;120.", repo.PurchaseOrder.ItemImportTemplate1.CellC5Info, new RecordItemIndex(37));
            repo.PurchaseOrder.ItemImportTemplate1.CellC5.Click("50;120");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ALGMD1' with focus on 'PurchaseOrder.ItemImportTemplate1.CellC5'.", repo.PurchaseOrder.ItemImportTemplate1.CellC5Info, new RecordItemIndex(38));
            repo.PurchaseOrder.ItemImportTemplate1.CellC5.PressKeys("ALGMD1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(39));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder.ItemImportTemplate1.CellC5'.", repo.PurchaseOrder.ItemImportTemplate1.CellC5Info, new RecordItemIndex(40));
            repo.PurchaseOrder.ItemImportTemplate1.CellC5.PressKeys("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'B27RQ2' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(41));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("B27RQ2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(42));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(43));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ALGMD1' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(44));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("ALGMD1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(45));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(46));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'MULTIPLE ITEM IMPORT TEST' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(47));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("MULTIPLE ITEM IMPORT TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}{Right}{Right}{Right}1{Right}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(48));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}{Right}{Right}{Right}1{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'TEST' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(49));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}1{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(50));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}1{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7445' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(51));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("7445");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(52));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AAB{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(53));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("AAB{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '218{Right}{Right}{Right}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(54));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("218{Right}{Right}{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(55));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(56));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.ItemImportTemplate1.CellC6' at 46;119.", repo.PurchaseOrder.ItemImportTemplate1.CellC6Info, new RecordItemIndex(57));
            repo.PurchaseOrder.ItemImportTemplate1.CellC6.Click("46;119");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'HCEMD1' with focus on 'PurchaseOrder.ItemImportTemplate1.CellC6'.", repo.PurchaseOrder.ItemImportTemplate1.CellC6Info, new RecordItemIndex(58));
            repo.PurchaseOrder.ItemImportTemplate1.CellC6.PressKeys("HCEMD1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(59));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder.ItemImportTemplate1.CellC6'.", repo.PurchaseOrder.ItemImportTemplate1.CellC6Info, new RecordItemIndex(60));
            repo.PurchaseOrder.ItemImportTemplate1.CellC6.PressKeys("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'B27RQ3' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(61));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("B27RQ3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(62));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(63));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'HCEMD1' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(64));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("HCEMD1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(65));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(66));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'MULTIPLE ITEM IMPORT TEST' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(67));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("MULTIPLE ITEM IMPORT TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}{Right}{Right}{Right}1{Right}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(68));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}{Right}{Right}{Right}1{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'TEST' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(69));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("TEST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}1{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(70));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}1{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7446' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(71));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("7446");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(72));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AAC{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(73));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("AAC{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '218{Right}{Right}{Right}{Right}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(74));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("218{Right}{Right}{Right}{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(75));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}' with focus on 'PurchaseOrder'.", repo.PurchaseOrder.SelfInfo, new RecordItemIndex(76));
            repo.PurchaseOrder.Self.EnsureVisible();
            Keyboard.Press("{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}{Left}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Save1' at 18;9.", repo.PurchaseOrder.Save1Info, new RecordItemIndex(77));
            repo.PurchaseOrder.Save1.Click("18;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Continue' at 51;8.", repo.PurchaseOrder.ContinueInfo, new RecordItemIndex(78));
            repo.PurchaseOrder.Continue.Click("51;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Close2' at 20;25.", repo.PurchaseOrder.Close2Info, new RecordItemIndex(79));
            repo.PurchaseOrder.Close2.Click("20;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.RunningApplications.GenesisAutomation1RunningWindow' at 27;15.", repo.Explorer.RunningApplications.GenesisAutomation1RunningWindowInfo, new RecordItemIndex(80));
            repo.Explorer.RunningApplications.GenesisAutomation1RunningWindow.Click("27;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ImportData' at 94;10.", repo.GenesisAutomation1.ImportDataInfo, new RecordItemIndex(81));
            repo.GenesisAutomation1.ImportData.Click("94;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.PushButton' at 8;14.", repo.PurchaseOrder.PushButtonInfo, new RecordItemIndex(82));
            repo.PurchaseOrder.PushButton.Click("8;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Text1148' at 121;11.", repo.PurchaseOrder.Text1148Info, new RecordItemIndex(83));
            repo.PurchaseOrder.Text1148.Click("121;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ImportItemTemplate' with focus on 'PurchaseOrder.Text1148'.", repo.PurchaseOrder.Text1148Info, new RecordItemIndex(84));
            repo.PurchaseOrder.Text1148.PressKeys("ImportItemTemplate");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'PurchaseOrder.Text1148'.", repo.PurchaseOrder.Text1148Info, new RecordItemIndex(85));
            repo.PurchaseOrder.Text1148.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PurchaseOrder.Import' at 96;16.", repo.PurchaseOrder.ImportInfo, new RecordItemIndex(86));
            repo.PurchaseOrder.Import.Click("96;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GenesisAutomation1.ButtonOK' at 38;12.", repo.GenesisAutomation1.ButtonOKInfo, new RecordItemIndex(87));
            repo.GenesisAutomation1.ButtonOK.Click("38;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
