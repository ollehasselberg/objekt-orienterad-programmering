using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Counter
    {
        private int count = 0;
        public int getCount()
        {
            return count;
        }

        public void increase()
        {
            count = count + 1;
        }
    }
}
