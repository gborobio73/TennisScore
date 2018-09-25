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
    [Register ("InterfaceControllerMatch")]
    partial class InterfaceControllerMatch
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnOppPoint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnUndoPoint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnYouPoint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblMatchDuration { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblOppScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblYouScore { get; set; }

        [Action ("OnOpponentPointBtnPress")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnOpponentPointBtnPress ();

        [Action ("OnUndoBtnPress")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnUndoBtnPress ();

        [Action ("OnYouPointBtnPress")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnYouPointBtnPress ();

        void ReleaseDesignerOutlets ()
        {
            if (btnOppPoint != null) {
                btnOppPoint.Dispose ();
                btnOppPoint = null;
            }

            if (btnUndoPoint != null) {
                btnUndoPoint.Dispose ();
                btnUndoPoint = null;
            }

            if (btnYouPoint != null) {
                btnYouPoint.Dispose ();
                btnYouPoint = null;
            }

            if (lblMatchDuration != null) {
                lblMatchDuration.Dispose ();
                lblMatchDuration = null;
            }

            if (lblOppScore != null) {
                lblOppScore.Dispose ();
                lblOppScore = null;
            }

            if (lblYouScore != null) {
                lblYouScore.Dispose ();
                lblYouScore = null;
            }
        }
    }
}