using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Classes
{
    public class MemoryCalculator :Calculator
    {

        public MemoryCalculator() { }

        private decimal memoryValue;
        public void MemoryStore(decimal display)
        {
            memoryValue = display;
        }

        public void MemoryRecall(Calculator c)
        {
            c.CurrentValue = memoryValue;
        }

        public void MemoryAdd(decimal display)
        {
            memoryValue += display;
        }

        public void MemoryClear()
        {
            memoryValue = 0;
        }

    }
}
