using System;
using System.Collections.Generic;
using System.Linq;
using MatchScore.UI;

namespace MatchScore
{
    public class MatchScoreFacade
    {
        public void StartMatch(bool youServe)
        {
            Match.Instance.Start(youServe);
        }

        public bool OnGoing()
        {
            return Match.Instance.OnGoing();
        }

        public void EndMatch()
        {
            Match.Instance.End();
        }

        public void SetOppPoint()
        {
            Match.Instance.SetOppPoint();
        }

        public void SetYouPoint()
        {
            Match.Instance.SetYouPoint();
        }

        public void UndoLasPoint()
        {
            Match.Instance.UndoLastPoint();
        }

        public IUIScore GetScore()
        {
            return new UIScore(Match.Instance.Current());
        }

        public string ElapsedTime()
        {
            return Match.Instance.ElapsedTime().ToString("hh\\:mm\\:ss");
        }

        public IUIMatch GetMatch()
        {
            var scores = Match.Instance.Scores().Select((s) => (IUIScore) new UIScore(s)).ToList();
            if (scores.Any()) scores.RemoveAt(0);
            return new UIMatch(Match.Instance.ElapsedTime(), scores);
        }
    }
}
