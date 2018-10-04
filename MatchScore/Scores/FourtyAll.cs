using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class FourtyAll : Score
    {
        public FourtyAll(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => Point.Fourty();

        public override Point YouPoint => Point.Fourty();

        protected override IScore GiveThePointToOpponent()
        {
            if (IsDoubles) return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
            return new OpponentAdvantage(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            if (IsDoubles) return new EndOfAGameUtil().GetNextScore(this, true, stopwatch);
            return new YourAdvantage(this, true, stopwatch);
        }
    }
}