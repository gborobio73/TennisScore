using System;
using System.Diagnostics;
using MatchScore.Rules;

namespace MatchScore.Scores
{
    class MaxiTiebreakScore : TiebreakScore
    {
        public MaxiTiebreakScore(int oppPoints, int youPoints, IScore previous, bool youWon, Stopwatch stopWatch) : 
            base(oppPoints, youPoints, previous, youWon, stopWatch)
        {

        }

        public override IScore SetOppPoint()
        {
            if (new MatchRules().IsMaxiTiebreakOver(oppPoints + 1, youPoints))
                return new NewGame(this, false, stopwatch);

            return new MaxiTiebreakScore(oppPoints + 1, youPoints, this, false, stopwatch);
        }

        public override IScore SetYouPoint()
        {
            if (new MatchRules().IsTiebreakOver(oppPoints, youPoints + 1))
                return new NewGame(this, true, stopwatch);

            return new MaxiTiebreakScore(oppPoints, youPoints + 1, this, true, stopwatch);
        }
    }
}
