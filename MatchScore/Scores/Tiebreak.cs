using MatchScore.Points;

namespace MatchScore.Scores
{
    class Tiebreak
    {
        protected int oppPoints;
        protected int youPoints;
        public Tiebreak(int oppPoints, int youPoints)
        {
            this.oppPoints = oppPoints;
            this.youPoints = youPoints;
        }

        public bool YouServe { get; private set; }

        public Point OppPoint => new TiebreakPoint(oppPoints);

        public Point YouPoint => new TiebreakPoint(youPoints);
    }
}
