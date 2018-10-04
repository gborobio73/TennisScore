using System;
using System.Diagnostics;
using MatchScore.Points;
using MatchScore.Rules;

namespace MatchScore.Scores
{
    class TiebreakScore : IScore
    {
        protected int oppPoints;
        protected int youPoints;
        protected Stopwatch stopwatch;

        public TiebreakScore(int oppPoints, int youPoints, IScore previous, bool youWon, Stopwatch stopWatch)
        {

            OppGames = previous.OppGames;
            YouGames = previous.YouGames;
            OppSets = previous.OppSets;
            YouSets = previous.YouSets;
            YouWonThePoint = youWon;
            ElapsedPointTime = stopWatch.Elapsed;
            this.stopwatch = stopWatch;
            this.oppPoints = oppPoints;
            this.youPoints = youPoints;
            YouServe = previous.YouServe;
            IsDoubles = previous.IsDoubles;
            IsBestOfFive = previous.IsBestOfFive;
            if (SumOfPointsIsOdd(oppPoints, youPoints))
            {
                YouServe = !previous.YouServe;
            }
        }

        public int OppGames { get; private set; }

        public int YouGames { get; private set; }

        public int OppSets { get; private set; }

        public int YouSets { get; private set; }

        public bool YouServe { get; private set; }

        public Point OppPoint => new TiebreakPoint(oppPoints);

        public Point YouPoint => new TiebreakPoint(youPoints);

        public bool YouWonThePoint { get; private set; }

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

        public TimeSpan ElapsedPointTime { get; private set; }

        public virtual IScore SetOppPoint()
        {
            if (new MatchRules().IsTiebreakOver(oppPoints + 1, youPoints)) 
                return new NewGame(this, false, stopwatch);

            return new TiebreakScore(oppPoints + 1, youPoints, this, false, stopwatch);
        }

        public virtual IScore SetYouPoint()
        {
            if (new MatchRules().IsTiebreakOver(oppPoints, youPoints + 1)) 
                return new NewGame(this, true, stopwatch);

            return new TiebreakScore(oppPoints, youPoints + 1, this, true, stopwatch);
        }

        static bool SumOfPointsIsOdd(int oppPoints, int youPoints)
        {
            return (oppPoints + youPoints) % 2 != 0;
        }
    }
}
