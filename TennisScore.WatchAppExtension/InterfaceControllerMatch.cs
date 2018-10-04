using Foundation;
using MatchScore;
using System;
using System.Drawing;
using System.Timers;
using WatchKit;
using UIKit;

namespace TennisScore.WatchAppExtension
{
    // btn color #fff8c000
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
            RenderMatchTime();
            lblSet.SetText($"S{Environment.NewLine}E{Environment.NewLine}T{Environment.NewLine}S");
            lblGames.SetText($"G{Environment.NewLine}A{Environment.NewLine}M{Environment.NewLine}E{Environment.NewLine}S");
            var doublesText = Configuration.Instance.Doubles ? "DOUBLES" : "SINGLES";
            lblDoubles.SetText(doublesText);
            var bestOf = Configuration.Instance.BestOfFive ? "BEST OF 5" : "BEST OF 3";
            lblBestOf.SetText(bestOf);

            //lblGames.SetText("gam"+Environment.NewLine+"es");
            //start new thread to update match time every second
            matchTimer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            matchTimer.Elapsed += OnTimedEvent;
            matchTimer.AutoReset = true;
            matchTimer.Enabled = true;

            if (!match.OnGoing())
            {
                match.StartMatch(Configuration.Instance.Doubles,
                                 Configuration.Instance.BestOfFive,
                                 Configuration.Instance.YouServe);
            }

            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);

            RenderScore();
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        partial void OnUndoBtnPress()
        {
            match.UndoLasPoint();
            RenderScore();
        }

        partial void OnOpponentPointBtnPress()
        {
            match.SetOppPoint();
            RenderScore();
        }

        partial void OnYouPointBtnPress()
        {
            match.SetYouPoint();
            RenderScore();

        }

        void RenderScore()
        {
            var score = match.GetScore();
            lblExtra.SetText("");

            if (score.EndOfMatch)
            {
                lblExtra.SetText("FINITO");
                btnOppPoint.SetEnabled(false);
                btnOppGroup.SetBackgroundColor(UIColor.DarkGray);
                btnYouPoint.SetEnabled(false);
                btnYouGroup.SetBackgroundColor(UIColor.DarkGray);

            }
            else
            {
                btnOppPoint.SetEnabled(true);
                btnOppGroup.SetBackgroundColor(new UIColor(red: 0.97f, green: 0.75f, blue: 0.00f, alpha: 1.0f));
                btnYouPoint.SetEnabled(true);
                btnYouGroup.SetBackgroundColor(new UIColor(red: 0.97f, green: 0.75f, blue: 0.00f, alpha: 1.0f));
            }

            if (score.YouServe){
                youPoints.SetTextColor(UIColor.Green);
                oppPoints.SetTextColor(UIColor.White);

            }
            else 
            {
                youPoints.SetTextColor(UIColor.White);
                oppPoints.SetTextColor(UIColor.Green);
            }

            if (score.IsTiebreak)
            {
                lblExtra.SetText("Tiebreak");
            }

            if (score.IsMaxiTiebreak)
            {
                lblExtra.SetText("10p Tiebr.");
            }

            oppPoints.SetText(score.OppPoint);
            youPoints.SetText(score.YouPoint);
            oppGames.SetText(score.OppGames);
            youGames.SetText(score.YouGames);
            oppSets.SetText(score.OppSets);
            youSets.SetText(score.YouSets);

        }

        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            RenderMatchTime();
        }

        void RenderMatchTime(){
            lblMatchHour.SetText(match.ElapsedTime().Substring(0,2));
            lblMatchMin.SetText(match.ElapsedTime().Substring(3));

        }
    }
}