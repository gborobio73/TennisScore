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
        bool YouWonThePoint { get; }
        bool IsDoubles { get; }
        bool IsBestOfFive { get; }
        bool IsTiebreak { get; }
        bool IsMaxiTiebreak { get; }
        bool EndOfMatch { get; }
    }

    public class UIScore : IUIScore
    {
        internal UIScore(IScore score, bool isTiebreak, bool isMaxiTiebreak, bool endOfMatch)
        {
            OppPoint = score.OppPoint.ToString();
            YouPoint = score.YouPoint.ToString();
            OppGames = score.OppGames.ToString();
            YouGames = score.YouGames.ToString();
            OppSets = score.OppSets.ToString();
            YouSets = score.YouSets.ToString();
            YouServe = score.YouServe;
            YouWonThePoint = score.YouWonThePoint;
            IsDoubles = score.IsDoubles;
            IsBestOfFive = score.IsBestOfFive;
            IsTiebreak = isTiebreak;
            IsMaxiTiebreak = isMaxiTiebreak;
            EndOfMatch = endOfMatch;
        }

        public string OppPoint { get; private set; }

        public string YouPoint { get; private set; }

        public string OppGames { get; private set; }

        public string YouGames { get; private set; }

        public string OppSets { get; private set; }

        public string YouSets { get; private set; }

        public bool YouServe { get; private set; }

        public bool YouWonThePoint { get; private set; }

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

        public bool IsTiebreak { get; private set; }

        public bool IsMaxiTiebreak { get; private set; }

        public bool EndOfMatch { get; private set; }
    }
}