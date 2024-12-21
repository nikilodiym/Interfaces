using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class Array : ICalc2
    {
        private int[] data;

        public Array(int[] data)
        {
            this.data = data;
        }

        public int CountDistinct()
        {
            return data.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return data.Count(x => x == valueToCompare);
        }
    }

    public class HMTask3
    {
        public int CountDistinct()
        {
            throw new NotImplementedException();
        }

        public int EqualToValue(int v)
        {
            throw new NotImplementedException();
        }
    }
}
