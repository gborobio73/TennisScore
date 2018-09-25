using System;
namespace MatchScore.Rules
{
    public class MatchRules
    {
        public bool IsEndOfMatch(int oppSets, int youSets)
        {
            return Math.Abs(oppSets - youSets) >= 2;
        }

        internal bool IsTiebreakOver(int oppPoints, int youPoints)
        {
            return (oppPoints >= 7 || youPoints >= 7) && Math.Abs(youPoints - oppPoints) >= 2;
        }

        internal bool IsSetOver(int oppGames, int youGames)
        {
            return ((youGames == 6 || oppGames == 6) && Math.Abs(youGames - oppGames) >= 2)
                || youGames == 7 || oppGames == 7;
        }

        internal bool IsTiebreak(int oppGames, int youGames)
        {
            return youGames == 6 && oppGames == 6;
        }
    }
}
