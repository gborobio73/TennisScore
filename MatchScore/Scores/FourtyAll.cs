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

        public override IScore SetOppPoint()
        {
            if (IsDoubles)
                return new NewGame(this, false, stopwatch);
            return new OpponentAdvantage(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (IsDoubles)
                return new NewGame(this, true, stopwatch);
            return new YourAdvantage(this, true, stopwatch);
        }
    }
}