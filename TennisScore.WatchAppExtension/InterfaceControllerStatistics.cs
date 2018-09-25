using Foundation;
using MatchScore;
using MatchScore.UI;
using System;
using System.Linq;
using WatchKit;

namespace TennisScore.WatchAppExtension
{
    public partial class InterfaceControllerStatistics : WKInterfaceController
    {
        MatchScoreFacade facade = new MatchScoreFacade();

        public InterfaceControllerStatistics(IntPtr handle) : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.


            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            var match = facade.GetMatch();
            lblDuration.SetText($"Duration: {match.Duration}");
            lblTotalPoints.SetText($"Total points: {match.Scores.Count.ToString()}");
            lblOppPoints.SetText($"Opp points: {match.Scores.Count((s) => !s.YouWonThePoint).ToString()}");
            lblYouPoints.SetText($"You points: {match.Scores.Count((s) => s.YouWonThePoint).ToString()}");
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void OnEndBtnPress()
        {
            facade.EndMatch();
            PopToRootController();
        }
    }
}