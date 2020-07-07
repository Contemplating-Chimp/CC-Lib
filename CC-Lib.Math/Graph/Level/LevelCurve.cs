using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Lib.Math.Graph.Level
{
    public class LevelCurve
    {
        public class LevelCurveExceptions
        {
            public const string LevelExceedsMaxLevelMessage = "Given level exceeds the max level limit";
            public const string LevelIsLessThanMinLevelMessage = "Given level is below the min level limit";
        }

        private Dictionary<int, double> levelDict;

        /// <summary>
        /// Return the level dictionary, Dict(level, experience)
        /// </summary>
        public Dictionary<int, double> LevelDict
        {
            get
            {
                return levelDict;
            }
            set
            {
                levelDict = value;
            }
        }

        private int minLevel;
        /// <summary>
        /// Returns the minimal level of this level curve
        /// </summary>
        public int MinLevel
        {
            get => minLevel;
            set => minLevel = value;
        }

        private int maxLevel;
        /// <summary>
        /// Returns the max level of this level curve
        /// </summary>
        public int MaxLevel
        {
            get => maxLevel;
            set => maxLevel = value;
        }

        internal LevelCurve(Dictionary<int, double> dict, int min, int max)
        {
            LevelDict = dict;
            MaxLevel = max;
            minLevel = min;
        }

        /// <summary>
        /// Gets the experience found at the key of given level
        /// </summary>
        /// <param name="level">The level (key)</param>
        /// <returns>The experience at given key (value)</returns>
        public int GetExperienceByLevel(int level) 
        {
            if (level > maxLevel)
                throw new ArgumentOutOfRangeException("level", level, LevelCurveExceptions.LevelExceedsMaxLevelMessage);
            if(level < minLevel)
                throw new ArgumentOutOfRangeException("level", level, LevelCurveExceptions.LevelIsLessThanMinLevelMessage);
            return (int)System.Math.Floor(LevelDict[level]);
        }
        
        /// <summary>
        /// Finds nearest level based on exp
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public int GetLevelByExperience(double exp) =>
            LevelDict.FirstOrDefault(x => x.Value == exp).Key;
    }
}
