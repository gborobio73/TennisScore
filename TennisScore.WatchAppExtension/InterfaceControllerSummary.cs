using Foundation;
using MatchScore;
using System;
using System.Linq;
using UIKit;
using WatchKit;

namespace TennisScore.WatchAppExtension
{
    public partial class InterfaceControllerSummary : WKInterfaceController
    {
        MatchScoreFacade facade = new MatchScoreFacade();

        public InterfaceControllerSummary (IntPtr handle) : base (handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            var match = facade.GetMatch();
            lblDuration.SetText(match.Duration);
            lblTotalPoints.SetText($"{match.Scores.Count.ToString()} points");
            lblOppPoints.SetText($"{match.Scores.Count((s) => !s.YouWonThePoint).ToString()} points");
            lblYouPoints.SetText($"{match.Scores.Count((s) => s.YouWonThePoint).ToString()} points");

            //statsTable.SetNumberOfRows(10, "default");
            //b0fc17 -> green button
            //btnEndMatch.SetBackgroundColor(new UIColor(red: 0.69f, green: 0.99f, blue: 0.09f, alpha: 1.0f));
            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.

            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void OnEndMAtchBtnPress()
        {
            facade.EndMatch();
            PopToRootController();
        }
    }
}