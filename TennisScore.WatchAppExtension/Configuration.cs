using System;
using WatchKit;

namespace TennisScore.WatchAppExtension
{
    public sealed class Configuration
    {
        static readonly Lazy<Configuration> lazy =
            new Lazy<Configuration>(() => new Configuration());

        public bool YouServe { get; set; }
        public bool BestOfThree{ get; set; }

        public static Configuration Instance { get { return lazy.Value; } }

        Configuration()
        {
        }

    }
}
