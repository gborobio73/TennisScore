
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

        public override IScore SetOppPoint()
        {
            return new NewGame(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            return new FourtyAll(this, true, stopwatch);
        }
    }
}