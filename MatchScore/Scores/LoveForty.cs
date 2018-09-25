using System.Diagnostics;
using MatchScore.Points;

namespace MatchScore.Scores
{
    class LoveForty : Score
    {
        public LoveForty(IScore previous, bool youWon, Stopwatch stopwatch) 
            : base(previous, youWon, stopwatch)
        {
        }

        public override Point OppPoint => YouServe ? Point.Fourty() : Point.Love();

        public override Point YouPoint => YouServe ? Point.Love() : Point.Fourty();

        public override IScore SetOppPoint()
        {
            if (YouServe) return new NewGame(this, false, stopwatch);
            return new FifteenForty(this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (YouServe) return new FifteenForty(this, true, stopwatch);
            return new NewGame(this, true, stopwatch);
        }
    }
}