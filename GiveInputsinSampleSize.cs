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

namespace Master
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GiveInputsinSampleSize recording.
    /// </summary>
    [TestModule("a5f5599f-9cf8-460b-bd44-c57a7487d6a7", ModuleType.Recording, 1)]
    public partial class GiveInputsinSampleSize : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MasterRepository repository.
        /// </summary>
        public static MasterRepository repo = MasterRepository.Instance;

        static GiveInputsinSampleSize instance = new GiveInputsinSampleSize();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GiveInputsinSampleSize()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GiveInputsinSampleSize Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100' with focus on 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(0));
            repo.MainWindow.PnlCommonParameters.TxtSampleSize.PressKeys("100");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.BtnCompute' at 45;16.", repo.MainWindow.BtnComputeInfo, new RecordItemIndex(1));
            repo.MainWindow.BtnCompute.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.PnlCommonParameters.TxtPower' at 53;7.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(3));
            repo.MainWindow.PnlCommonParameters.TxtPower.Click("53;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.323') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "Text", "0.323");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.303') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "Text", "0.303");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            // Test01
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '200' with focus on 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(9));
            repo.MainWindow.PnlCommonParameters.TxtSampleSize.PressKeys("200");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.BtnCompute' at 45;16.", repo.MainWindow.BtnComputeInfo, new RecordItemIndex(10));
            repo.MainWindow.BtnCompute.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.PnlCommonParameters.TxtPower' at 53;7.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(12));
            repo.MainWindow.PnlCommonParameters.TxtPower.Click("53;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.564') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "Text", "0.564");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.544') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "Text", "0.544");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            // Test02
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '250' with focus on 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(18));
            repo.MainWindow.PnlCommonParameters.TxtSampleSize.PressKeys("250");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.BtnCompute' at 45;16.", repo.MainWindow.BtnComputeInfo, new RecordItemIndex(19));
            repo.MainWindow.BtnCompute.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(20));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.PnlCommonParameters.TxtPower' at 53;7.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(21));
            repo.MainWindow.PnlCommonParameters.TxtPower.Click("53;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.66') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "Text", "0.66");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.64') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "Text", "0.64");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            // Test03
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '400' with focus on 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(27));
            repo.MainWindow.PnlCommonParameters.TxtSampleSize.PressKeys("400");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.BtnCompute' at 45;16.", repo.MainWindow.BtnComputeInfo, new RecordItemIndex(28));
            repo.MainWindow.BtnCompute.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(29));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.PnlCommonParameters.TxtPower' at 53;7.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(30));
            repo.MainWindow.PnlCommonParameters.TxtPower.Click("53;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.851') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "Text", "0.851");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.831') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "Text", "0.831");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            // Test04
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(35));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '550' with focus on 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(36));
            repo.MainWindow.PnlCommonParameters.TxtSampleSize.PressKeys("550");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.BtnCompute' at 45;16.", repo.MainWindow.BtnComputeInfo, new RecordItemIndex(37));
            repo.MainWindow.BtnCompute.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(38));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.PnlCommonParameters.TxtPower' at 53;7.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(39));
            repo.MainWindow.PnlCommonParameters.TxtPower.Click("53;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.94') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "Text", "0.94");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0.92') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(42));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "Text", "0.92");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlUserControlCollection.TxtModifiedPower'.", repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.MainWindow.PnlUserControlCollection.TxtModifiedPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            // Test05
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(44));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
