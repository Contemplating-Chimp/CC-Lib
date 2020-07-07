using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Lib.Math.Graph.Level
{
    public static class LevelCurveGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="increase"></param>
        /// <param name="difference"></param>
        /// <param name="divider"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static LevelCurve CreateCurve(int min, int max, double increase, double difference, double divider, double div) =>
            GenerateCurve(min, max, increase, difference, divider, div);

        private static LevelCurve GenerateCurve(int min, int max, double increase, double difference, double divider, double div)
        {
            Dictionary<int, double> lvlExpValues = new Dictionary<int, double>(); //lvl:exp

            double points = 0;
            double output = 0;

            for (int lvl = min; lvl <= max + 1; lvl++)
            {
                points += System.Math.Floor(lvl + increase * System.Math.Pow(difference, lvl / div));
                output = (int)System.Math.Floor(points / divider);
                if (lvl >= min)
                    output = System.Math.Floor(points / divider);
                lvlExpValues.Add(lvl, output);
            }
            lvlExpValues[1] = 1;

            return new LevelCurve(lvlExpValues, min, max);
        }

    }
}
