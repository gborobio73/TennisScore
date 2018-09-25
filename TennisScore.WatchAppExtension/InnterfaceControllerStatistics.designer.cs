// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using WatchKit;

namespace TennisScore.WatchAppExtension
{
    [Register ("InnterfaceControllerStatistics")]
    partial class InnterfaceControllerStatistics
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblDuration { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblDuration != null) {
                lblDuration.Dispose ();
                lblDuration = null;
            }
        }
    }
}