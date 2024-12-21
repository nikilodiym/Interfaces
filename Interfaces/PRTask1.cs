using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }
}
