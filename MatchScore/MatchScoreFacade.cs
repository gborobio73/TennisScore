using System;
using System.Collections.Generic;
using System.Linq;
using MatchScore.Scores;
using MatchScore.UI;

namespace MatchScore
{
    public class MatchScoreFacade
    {
        public void StartMatch(bool isDoubles, bool isBestOfFive, bool youServe)
        {
            Match.Instance.Start(isDoubles, isBestOfFive, youServe);
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
            return BuildUIScore(Match.Instance.Current());
        }

        public string ElapsedTime()
        {
            return Match.Instance.ElapsedTime().ToString("hh\\:mm\\:ss");
        }

        public IUIMatch GetMatch()
        {
            var scores = Match.Instance.Scores().Select(BuildUIScore).ToList();
            if (scores.Any()) scores.RemoveAt(0);
            return new UIMatch(Match.Instance.ElapsedTime(), scores);
        }

        IUIScore BuildUIScore(IScore score)
        {
            var isTiebreak = score.GetType().Equals(typeof(TiebreakScore));
            var isMaxiTiebreak = score.GetType().Equals(typeof(MaxiTiebreakScore));
            var endOfMatch = score.GetType().Equals(typeof(EndOfMatch));
            return new UIScore(score, isTiebreak, isMaxiTiebreak, endOfMatch);
        }
    }
}
