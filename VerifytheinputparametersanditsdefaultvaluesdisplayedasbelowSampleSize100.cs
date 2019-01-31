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
    ///The VerifytheinputparametersanditsdefaultvaluesdisplayedasbelowSampleSize100 recording.
    /// </summary>
    [TestModule("a968e9dc-8888-4a5e-881d-4eaa75b5683b", ModuleType.Recording, 1)]
    public partial class VerifytheinputparametersanditsdefaultvaluesdisplayedasbelowSampleSize100 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MasterRepository repository.
        /// </summary>
        public static MasterRepository repo = MasterRepository.Instance;

        static VerifytheinputparametersanditsdefaultvaluesdisplayedasbelowSampleSize100 instance = new VerifytheinputparametersanditsdefaultvaluesdisplayedasbelowSampleSize100();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifytheinputparametersanditsdefaultvaluesdisplayedasbelowSampleSize100()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifytheinputparametersanditsdefaultvaluesdisplayedasbelowSampleSize100 Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='<n>Sample Si&ze (n):</n>') on item 'MainWindow.PnlCommonParameters.LblSampleSize'.", repo.MainWindow.PnlCommonParameters.LblSampleSizeInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.LblSampleSizeInfo, "Text", "<n>Sample Si&ze (n):</n>");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Computed') on item 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, "Text", "Computed");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MainWindow.PnlUserControlCollection.RdbOutputSS'.", repo.MainWindow.PnlUserControlCollection.RdbOutputSSInfo, new RecordItemIndex(2));
            Validate.Exists(repo.MainWindow.PnlUserControlCollection.RdbOutputSSInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.PnlUserControlCollection.RdbOutputPower' at 7;11.", repo.MainWindow.PnlUserControlCollection.RdbOutputPowerInfo, new RecordItemIndex(3));
            repo.MainWindow.PnlUserControlCollection.RdbOutputPower.Click("7;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='<n>Po&wer:</n>') on item 'MainWindow.PnlCommonParameters.LblPower'.", repo.MainWindow.PnlCommonParameters.LblPowerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.LblPowerInfo, "Text", "<n>Po&wer:</n>");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Computed') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "Text", "Computed");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='255, 255, 153') on item 'MainWindow.PnlCommonParameters.TxtPower'.", repo.MainWindow.PnlCommonParameters.TxtPowerInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtPowerInfo, "BackColor", "255, 255, 153");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='<n>Sample Si&ze (n):</n>') on item 'MainWindow.PnlCommonParameters.LblSampleSize'.", repo.MainWindow.PnlCommonParameters.LblSampleSizeInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.LblSampleSizeInfo, "Text", "<n>Sample Si&ze (n):</n>");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, "Text", "100");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (BackColor='Pink') on item 'MainWindow.PnlCommonParameters.TxtSampleSize'.", repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MainWindow.PnlCommonParameters.TxtSampleSizeInfo, "BackColor", "Pink");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
