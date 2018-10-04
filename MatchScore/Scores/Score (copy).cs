using System;
using System.Diagnostics;
using MatchScore.Points;
using MatchScore.Rules;

namespace MatchScore.Scores
{
    abstract class Score_New : IScore_New
    {
        protected readonly Stopwatch stopwatch;

        internal Score_New(IScore_New previous, bool youWon, Stopwatch stopwatch)
        {
            OppGames = previous.OppGames;
            YouGames = previous.YouGames;
            OppSets = previous.OppSets;
            YouSets = previous.YouSets;
            YouServe = previous.YouServe;
            YouWonThePoint = youWon;
            IsDoubles = previous.IsDoubles;
            IsBestOfFive = previous.IsBestOfFive;
            ElapsedPointTime = stopwatch.Elapsed;
            this.stopwatch = stopwatch;
        }

        public int OppGames { get; protected set; }

        public int YouGames { get; protected set; }

        public int OppSets { get; protected set; }

        public int YouSets { get; protected set; }

        public bool YouServe { get; protected set; }

        public abstract Point OppPoint { get; }

        public abstract Point YouPoint { get; }

        public bool YouWonThePoint { get; private set; }

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

        public TimeSpan ElapsedPointTime { get; private set; }

        protected abstract IScore_New GetNextScore(IScore_New current, bool youWon, Stopwatch stopwatch);

        public IScore_New SetOppPoint_New()
        {
            return GetNextScore(this, false, stopwatch);
        }

        public IScore_New SetYouPoint_New()
        {
            return GetNextScore(this, true, stopwatch);
        }
    }

    interface IScore_New
    {
        int OppGames { get; }

        int YouGames { get; }

        int OppSets { get; }

        int YouSets { get; }

        bool YouServe { get; }

        Point OppPoint { get; }

        Point YouPoint { get; }

        IScore_New SetOppPoint_New();

        IScore_New SetYouPoint_New();

        bool IsDoubles { get; }

        bool IsBestOfFive { get; }

        bool YouWonThePoint { get; }

        TimeSpan ElapsedPointTime { get; }
    }
}