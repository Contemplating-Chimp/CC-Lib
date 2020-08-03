using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Lib.Math
{
    public class CCMath
    {
        public static int CapInt(int value, Func<int> f)
        {
            int res = f.Invoke();
            return res > value ? value : res;
        }

        public static float CapFloat(float value, Func<float> f)
        {
            float res = f.Invoke();
            return res > value ? value : res;
        }

        public static double CapDouble(double value, Func<double> f)
        {
            double res = f.Invoke();
            return res > value ? value : res;
        }

        public static decimal CapDecimal(decimal value, Func<decimal> f)
        {
            decimal res = f.Invoke();
            return res > value ? value : res;
        }

        public static double Round (double value, int precision)
        {
            int scale = (int)System.Math.Pow(10, precision);
            return System.Math.Round(value * scale) / scale;
        }

        public static float Round (float value, int precision)
        {
            int scale = (int)System.Math.Pow(10, precision);
            return (float)System.Math.Round(value * scale) / scale;
        }

        public static decimal Round(decimal value, int precision)
        {
            int scale = (int)System.Math.Pow(10, precision);
            return (decimal)System.Math.Round(value * scale) / scale;
        }

    }
}
