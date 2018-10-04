using System;
using System.Diagnostics;
using MatchScore.Points;
using MatchScore.Rules;

namespace MatchScore.Scores
{
    class MaxiTiebreakScore: ScoreState, IScore
    {
        protected int oppPoints;
        protected int youPoints;
        protected Stopwatch stopwatch;
        public MaxiTiebreakScore(int oppPoints, int youPoints, int oppSets, int youSets, IScore previous, bool youWon, Stopwatch stopWatch)  
        {
            this.stopwatch = stopWatch;
            this.oppPoints = oppPoints;
            this.youPoints = youPoints;
            OppSets = oppSets;
            YouSets = youSets;
            YouWonThePoint = youWon;
            ElapsedPointTime = stopWatch.Elapsed;
            YouServe = new MatchRules().IsTiebreakServeChange(oppPoints, youPoints) ? !previous.YouServe : previous.YouServe;
            IsDoubles = previous.IsDoubles;
            IsBestOfFive = previous.IsBestOfFive;
        }

        public int OppGames => 0;

        public int YouGames => 0;

        public int OppSets { get; private set; }

        public int YouSets { get; private set; }

        public bool YouServe { get; private set; }

        public Point OppPoint => new TiebreakPoint(oppPoints);

        public Point YouPoint => new TiebreakPoint(youPoints);

        public bool YouWonThePoint { get; private set; }

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

        public TimeSpan ElapsedPointTime { get; private set; }

        public bool IsEndOfMatch => false;

        protected override IScore GiveThePointToOpponent()
        {
            if (new MatchRules().IsMaxiTiebreakOver(oppPoints + 1, youPoints))
                return new EndOfMatch(this, OppSets +1, YouSets, false, stopwatch);

            return new MaxiTiebreakScore(oppPoints + 1, youPoints, OppSets, YouSets, this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (new MatchRules().IsMaxiTiebreakOver(oppPoints, youPoints + 1))
                return new EndOfMatch(this, OppSets, YouSets + 1, true, stopwatch);

            return new MaxiTiebreakScore(oppPoints, youPoints + 1, OppSets, YouSets, this, true, stopwatch);
        }
    }
}
