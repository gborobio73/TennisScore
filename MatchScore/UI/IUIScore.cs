using MatchScore.Scores;

namespace MatchScore.UI
{
    public interface IUIScore
    {
        string OppPoint { get; }
        string YouPoint { get; }
        string OppGames { get; }
        string YouGames { get; }
        string OppSets { get; }
        string YouSets { get; }
        bool YouServe { get; }
        bool IsEndOfMatch { get; }
        bool YouWonThePoint { get; }
        bool IsDoubles { get; }
        bool IsBestOfFive { get; }

    }

    public class UIScore : IUIScore
    {
        internal UIScore(IScore score)
        {
            OppPoint = score.OppPoint.Equals(50) ? "Ad" : score.OppPoint.ToString();
            YouPoint = score.YouPoint.Equals(50) ? "Ad" : score.YouPoint.ToString();
            OppGames = score.OppGames.ToString();
            YouGames = score.YouGames.ToString();
            OppSets = score.OppSets.ToString();
            YouSets = score.YouSets.ToString();
            IsEndOfMatch = score.IsEndOfMatch();
            YouServe = score.YouServe;
            YouWonThePoint = score.YouWonThePoint;
            IsDoubles = score.IsDoubles;
            IsBestOfFive = score.IsBestOfFive;
        }

        public string OppPoint { get; private set; }

        public string YouPoint { get; private set; }

        public string OppGames { get; private set; }

        public string YouGames { get; private set; }

        public string OppSets { get; private set; }

        public string YouSets { get; private set; }

        public bool IsEndOfMatch { get; private set; }

        public bool YouServe { get; private set; }

        public bool YouWonThePoint { get; private set; }

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }
    }
}