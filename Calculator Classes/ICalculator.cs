using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Classes
{
    public interface ICalculator
    {
        public abstract void Add(decimal displayValue);
        public abstract void Subtract(decimal displayValue);
        public abstract void Multiply(decimal displayValue);
        public abstract void Divide(decimal displayValue);

        public abstract decimal Equals();
        public abstract decimal Equals(decimal displayValue);
        public abstract void Clear();
    }
}
