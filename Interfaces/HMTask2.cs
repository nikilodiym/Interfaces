using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    public class HMTask2 : IOutput2
    {
        private int[] array;

        public HMTask2(int[] array)
        {
            this.array = array;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even numbers");
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd numbers");
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
