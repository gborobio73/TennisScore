
using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class OpponentAdvantage : Score
    {
        public OpponentAdvantage(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => Point.Ad();

        public override Point YouPoint => Point.Fourty();

        protected override IScore GiveThePointToOpponent()
        {
            return new EndOfAGameUtil().GetNextScore(this, false, stopwatch);
        }

        protected override IScore GiveThePointToYou()
        {
            return new FourtyAll(this, true, stopwatch);
        }
    }
}