// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TennisScore.WatchAppExtension
{
    [Register ("InterfaceControllerHome")]
    partial class InterfaceControllerHome
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnStart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton btnSummary { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSwitch swBestOfFive { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSwitch swDoubles { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSwitch swYouServe { get; set; }

        [Action ("OnBestOfFiveSWPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnBestOfFiveSWPressed (System.Boolean sender);

        [Action ("OnDoublesSWPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnDoublesSWPressed (System.Boolean sender);

        [Action ("OnYouServeSwPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnYouServeSwPressed (System.Boolean sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnStart != null) {
                btnStart.Dispose ();
                btnStart = null;
            }

            if (btnSummary != null) {
                btnSummary.Dispose ();
                btnSummary = null;
            }

            if (swBestOfFive != null) {
                swBestOfFive.Dispose ();
                swBestOfFive = null;
            }

            if (swDoubles != null) {
                swDoubles.Dispose ();
                swDoubles = null;
            }

            if (swYouServe != null) {
                swYouServe.Dispose ();
                swYouServe = null;
            }
        }
    }
}