using System;
namespace MatchScore.Points
{
    abstract class Point
    {
        public abstract override string ToString();

        internal static Point Fifteen()
        {
            return new Fifteen();
        }

        internal static Point Thirty()
        {
            return new Thirty();
        }

        internal static Point Love()
        {
            return new Love();
        }

        internal static Point Fourty()
        {
            return new Fourty();
        }

        internal static Point Ad()
        {
            return new Ad();
        }
    }

    class Love : Point
    {
        public override string ToString()
        {
            return 0.ToString();
        }
    }


    class Fifteen : Point
    {
        public override string ToString()
        {
            return 15.ToString();
        }
    }

    class Thirty : Point
    {
        public override string ToString()
        {
            return 30.ToString();
        }
    }

    class Fourty : Point
    {
        public override string ToString()
        {
            return 40.ToString();
        }
    }

    class Ad : Point
    {
        public override string ToString()
        {
            return "Ad";
        }
    }

    class TiebreakPoint : Point
    {
        readonly int points;

        public TiebreakPoint(int points)
        {
            this.points = points;
        }
        public override string ToString()
        {
            return points.ToString();
        }
    }
}
