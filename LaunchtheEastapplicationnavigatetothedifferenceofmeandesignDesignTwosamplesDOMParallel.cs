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
    ///The LaunchtheEastapplicationnavigatetothedifferenceofmeandesignDesignTwosamplesDOMParallel recording.
    /// </summary>
    [TestModule("08806c1b-043b-40cd-afd7-81a816baf3aa", ModuleType.Recording, 1)]
    public partial class LaunchtheEastapplicationnavigatetothedifferenceofmeandesignDesignTwosamplesDOMParallel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MasterRepository repository.
        /// </summary>
        public static MasterRepository repo = MasterRepository.Instance;

        static LaunchtheEastapplicationnavigatetothedifferenceofmeandesignDesignTwosamplesDOMParallel instance = new LaunchtheEastapplicationnavigatetothedifferenceofmeandesignDesignTwosamplesDOMParallel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchtheEastapplicationnavigatetothedifferenceofmeandesignDesignTwosamplesDOMParallel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchtheEastapplicationnavigatetothedifferenceofmeandesignDesignTwosamplesDOMParallel Instance
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

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}