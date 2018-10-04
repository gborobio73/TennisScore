using System;
using System.Diagnostics;
using MatchScore.Points;
using MatchScore.Rules;

namespace MatchScore.Scores
{
    class TiebreakScore : ScoreState, IScore
    {
        protected int oppPoints;
        protected int youPoints;
        protected Stopwatch stopwatch;

        public TiebreakScore(int oppPoints, int youPoints, IScore previous, bool youWon, Stopwatch stopWatch)
        {
            OppSets = previous.OppSets;
            YouSets = previous.YouSets;
            YouWonThePoint = youWon;
            ElapsedPointTime = stopWatch.Elapsed;
            this.stopwatch = stopWatch;
            this.oppPoints = oppPoints;
            this.youPoints = youPoints;
            YouServe = new MatchRules().IsTiebreakServeChange(oppPoints, youPoints)? !previous.YouServe : previous.YouServe;
            IsDoubles = previous.IsDoubles;
            IsBestOfFive = previous.IsBestOfFive;
        }

        public virtual int OppGames => 6;

        public virtual int YouGames => 6;

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
            if (new MatchRules().IsTiebreakOver(oppPoints + 1, youPoints))
                return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);

            return new TiebreakScore(oppPoints + 1, youPoints, this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if(new MatchRules().IsTiebreakOver(oppPoints, youPoints + 1))
                return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);

            return new TiebreakScore(oppPoints, youPoints + 1, this, true, stopwatch);
        }
    }
}
