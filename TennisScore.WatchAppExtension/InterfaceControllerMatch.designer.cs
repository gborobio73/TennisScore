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
        WatchKit.WKInterfaceLabel lblGames { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblMatchDuration { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel lblSet { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel oppGames { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel oppPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel oppServe { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel oppSets { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel youGames { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel youPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel youServe { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel youSets { get; set; }

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

            if (lblGames != null) {
                lblGames.Dispose ();
                lblGames = null;
            }

            if (lblMatchDuration != null) {
                lblMatchDuration.Dispose ();
                lblMatchDuration = null;
            }

            if (lblSet != null) {
                lblSet.Dispose ();
                lblSet = null;
            }

            if (oppGames != null) {
                oppGames.Dispose ();
                oppGames = null;
            }

            if (oppPoints != null) {
                oppPoints.Dispose ();
                oppPoints = null;
            }

            if (oppServe != null) {
                oppServe.Dispose ();
                oppServe = null;
            }

            if (oppSets != null) {
                oppSets.Dispose ();
                oppSets = null;
            }

            if (youGames != null) {
                youGames.Dispose ();
                youGames = null;
            }

            if (youPoints != null) {
                youPoints.Dispose ();
                youPoints = null;
            }

            if (youServe != null) {
                youServe.Dispose ();
                youServe = null;
            }

            if (youSets != null) {
                youSets.Dispose ();
                youSets = null;
            }
        }
    }
}