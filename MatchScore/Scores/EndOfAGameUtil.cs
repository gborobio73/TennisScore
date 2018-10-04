using System;
using System.Diagnostics;
using MatchScore.Rules;

namespace MatchScore.Scores
{
    class EndOfAGameUtil
    {
        readonly MatchRules matchRules = new MatchRules();

        internal IScore GetNextScore(IScore current, bool youWon, Stopwatch stopwatch)
        {
            var oppGames = youWon ? current.OppGames : current.OppGames + 1;
            var youGames = youWon ? current.YouGames +1 : current.YouGames;

            var YouServe = !current.YouServe;

            if (matchRules.IsSetOver(oppGames, youGames))
            {
                var oppSets = youWon ? current.OppSets : current.OppSets + 1;
                var youSets = youWon ? current.YouSets + 1 : current.YouSets;

                youGames = 0;
                oppGames = 0;

                if (matchRules.IsEndOfMatch(oppSets, youSets, current.IsBestOfFive))
                {
                    return new EndOfMatch(current, oppSets, youSets, youWon, stopwatch);
                }

                if (matchRules.IsMaxiTiebreak(oppSets, youSets, current.IsBestOfFive, current.IsDoubles))
                {
                    return new MaxiTiebreakScore(0, 0, oppSets, youSets, current, youWon, stopwatch);
                }
                return new NewSet(current, youWon, stopwatch);
            }
            else
            {
                if (matchRules.IsTiebreak(oppGames, youGames))
                {
                    return new TiebreakScore(0, 0, current, youWon, stopwatch);
                }
                return new NewGame(current, youWon, stopwatch);
            }
        }
    }
}
