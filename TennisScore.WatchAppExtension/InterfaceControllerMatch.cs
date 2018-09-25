using Foundation;
using MatchScore;
using System;
using System.Timers;
using WatchKit;

namespace TennisScore.WatchAppExtension
{
    public partial class InterfaceControllerMatch : WKInterfaceController
    {
        MatchScoreFacade match = new MatchScoreFacade();
        Timer matchTimer;

        public InterfaceControllerMatch(IntPtr handle) : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.

            //start new thread to update match time every second
            matchTimer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            matchTimer.Elapsed += OnTimedEvent;
            matchTimer.AutoReset = true;
            matchTimer.Enabled = true;

            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);

            if (!match.OnGoing())
            {
                match.StartMatch(Configuration.Instance.YouServe);
            } 
            RenderUI();

        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void OnUndoBtnPress()
        {
            match.UndoLasPoint();
            RenderUI();
        }

        partial void OnOpponentPointBtnPress()
        {
            match.SetOppPoint();
            RenderUI();
        }

        partial void OnYouPointBtnPress()
        {
            match.SetYouPoint();
            RenderUI();

        }

        void RenderUI()
        {
            var score = match.GetScore();
            if (score.IsEndOfMatch)
            {
                lblOppScore.SetTextColor(UIKit.UIColor.Green);
                lblYouScore.SetTextColor(UIKit.UIColor.Green);
            }
            else
            {
                lblOppScore.SetTextColor(UIKit.UIColor.White);
                lblYouScore.SetTextColor(UIKit.UIColor.White);
            }
            var oppServe = score.YouServe ? "" : "X";
            var youServe = score.YouServe ? "X" : "";
            lblOppScore.SetText($"{score.OppPoint} {score.OppGames} {score.OppSets} {oppServe}");
            lblYouScore.SetText($"{score.YouPoint} {score.YouGames} {score.YouSets} {youServe}");
            RenderMatchTime();
        }

        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            RenderMatchTime();
        }

        void RenderMatchTime(){
            lblMatchDuration.SetText(match.ElapsedTime());
        }
    }
}