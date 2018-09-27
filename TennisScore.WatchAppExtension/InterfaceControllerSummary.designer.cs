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
    [Register ("InterfaceControllerSummary")]
    partial class InterfaceControllerSummary
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnEndMatch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblDuration { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblOppPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblTotalPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblYouPoints { get; set; }

        [Action ("OnEndMAtchBtnPress")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnEndMAtchBtnPress ();

        void ReleaseDesignerOutlets ()
        {
            if (btnEndMatch != null) {
                btnEndMatch.Dispose ();
                btnEndMatch = null;
            }

            if (lblDuration != null) {
                lblDuration.Dispose ();
                lblDuration = null;
            }

            if (lblOppPoints != null) {
                lblOppPoints.Dispose ();
                lblOppPoints = null;
            }

            if (lblTotalPoints != null) {
                lblTotalPoints.Dispose ();
                lblTotalPoints = null;
            }

            if (lblYouPoints != null) {
                lblYouPoints.Dispose ();
                lblYouPoints = null;
            }
        }
    }
}