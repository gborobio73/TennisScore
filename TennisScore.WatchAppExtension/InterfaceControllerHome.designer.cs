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
        WatchKit.WKInterfaceButton btnStats { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSwitch swBestOfThree { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceSwitch swYouServe { get; set; }

        [Action ("OnBestOfThreeSWPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnBestOfThreeSWPressed (System.Boolean sender);

        [Action ("OnYouServeSwPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnYouServeSwPressed (System.Boolean sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnStart != null) {
                btnStart.Dispose ();
                btnStart = null;
            }

            if (btnStats != null) {
                btnStats.Dispose ();
                btnStats = null;
            }

            if (swBestOfThree != null) {
                swBestOfThree.Dispose ();
                swBestOfThree = null;
            }

            if (swYouServe != null) {
                swYouServe.Dispose ();
                swYouServe = null;
            }
        }
    }
}