using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Lib.Rand
{
    public static class RandomUtils
    {
        static Random r = new Random();

        public static int Range(int min, int max, int except)
        {
            int random = r.Next(min, max);
            if (random >= except)
                random = (random + 1) % max;
            return random;
        }

        public static int RandomExcept(int min, int max, int except)
        {
            int random = r.Next(min, max);
            if (random >= except)
                random = (random + 1) % max;
            return random;
        }
        
        public static int[] RandomRange(int length, int minVal, int maxVal)
        {
            return Enumerable.Repeat(0, length).Select(i => r.Next(minVal, maxVal)).ToArray();
        }


    }
}
