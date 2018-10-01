using System;
using Foundation;
using WatchKit;

namespace TennisScore.WatchAppExtension
{
    public sealed class Configuration
    {
        static readonly Lazy<Configuration> lazy = new Lazy<Configuration>(() => new Configuration());

        public bool YouServe { get; internal set; }
        public bool Doubles { get; internal set; }
        public bool BestOfFive { get; internal set; }

        public static Configuration Instance { get { return lazy.Value; } }

        Configuration()
        {
        }

    }
}
