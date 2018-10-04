using System;
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class EndOfMatch : IScore
    {
        public int OppGames => 0;

        public int YouGames => 0;

        public int OppSets { get; private set; }

        public int YouSets { get; private set; }

        public bool YouServe { get; private set; }

        public Point OppPoint => Point.Love();

        public Point YouPoint => Point.Love();

        public bool YouWonThePoint { get; private set; }

        public bool IsDoubles { get; private set; }

        public bool IsBestOfFive { get; private set; }

        public TimeSpan ElapsedPointTime { get; private set; }

        public bool IsEndOfMatch => true;

        public EndOfMatch(IScore current, int oppSets, int youSets, bool youWon, Stopwatch stopwatch)
        {
            OppSets = oppSets;
            YouSets = youSets;
            YouServe = current.YouServe;
            YouWonThePoint = youWon;
            IsDoubles = current.IsDoubles;
            IsBestOfFive = current.IsBestOfFive;
            ElapsedPointTime = stopwatch.Elapsed;
            stopwatch.Stop();
        }

        public IScore SetOppPoint()
        {
            return this;
        }

        public IScore SetYouPoint()
        {
            return this;
        }
    }
}