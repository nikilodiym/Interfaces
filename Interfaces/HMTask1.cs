using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class HMTask1 : ICalc
    {
        private int[] array;

        public HMTask1(int[] array)
        {
            this.array = array;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
