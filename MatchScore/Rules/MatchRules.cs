using System;
namespace MatchScore.Rules
{
    public class MatchRules
    {
        public bool IsEndOfMatch(int oppSets, int youSets, bool isBestOfFive)
        {
            if (isBestOfFive)
                return oppSets == 3 || youSets == 3;// || Math.Abs(oppSets - youSets) == 2;
            return oppSets == 2 || youSets == 2;

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

        internal bool IsDecidingSet(int oppSets, int youSets, bool isBestOfFive)
        {
            if (isBestOfFive)
                return oppSets == 2 && youSets == 2;
            return oppSets == 1 && youSets == 1;
        }

        internal bool IsTiebreak(int oppGames, int youGames)
        {
            return youGames == 6 && oppGames == 6;
        }
    }
}
