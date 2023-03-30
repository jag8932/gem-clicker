using System;
using System.Collections.Generic;
using System.Text;

namespace GemClicker.Models
{
    public static class Data
    {
        // This model allows static data to be manipulated and shared by multiple pages and classes.
        // Useful for implementing the upgrade feature.
        public static int TotalGems = 0;
        public static int miningLevel = 1;
        public static int miningEfficiency = 1;
        public static int numDefenses = 0;
        public static int dragonDamage = 100 - (Data.numDefenses * 2);
        public static int autoLevel = 1;
        public static int perSecond = (Data.miningEfficiency * Data.miningLevel) + ((Data.miningLevel * Data.miningEfficiency) * Data.autoLevel);
    }
}
