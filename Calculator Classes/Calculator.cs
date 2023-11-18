using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Classes
{
    public class Calculator:ICalculator
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private operator_enumeration op = operator_enumeration.None;
        public enum operator_enumeration
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            None
        }

        public decimal CurrentValue { get { return currentValue; } set { currentValue = value; } }
        public operator_enumeration Op { get { return op; } set { op = value; } }

        public Calculator()
        {
            currentValue = CurrentValue;
            op = Op;
        }               
        
        public void Add(decimal displayValue)
        {
            operand1 = displayValue;
            op = operator_enumeration.Add;
        }

        public void Subtract(decimal displayValue)
        {
            operand1 = displayValue;
            op = operator_enumeration.Subtract;
        }

        public void Multiply(decimal displayValue)
        {            
            operand1 = displayValue;
            op = operator_enumeration.Multiply;
        }

        public void Divide(decimal displayValue)
        {
            operand1 = displayValue;
            op = operator_enumeration.Divide;
        }

        public decimal Equals()
        {
            return performOperation();
        }

        public decimal Equals(decimal displayValue)
        {

            operand2 = displayValue;
            return performOperation();
            
        }

        public void Clear()
        {
            currentValue = default;
            operand1 = default;
            operand2 = default;
            op = operator_enumeration.None;
        }

        public string Back(string result_to_back)
        {
            if(result_to_back.Length > 0) {
            return result_to_back.Substring(0, result_to_back.Length - 1);
            }
            return result_to_back;
        }

        public decimal performOperation()
        {
            switch (op)
            {
                case operator_enumeration.Add:
                    operand1 = operand1 + operand2;
                    break;
                case operator_enumeration.Subtract:
                    operand1 = operand1 - operand2;
                    break;
                case operator_enumeration.Multiply:
                    operand1 = operand1 * operand2;
                    break;
                case operator_enumeration.Divide:
                    operand1 = operand1 / operand2;
                    break;
            }
            op = operator_enumeration.None;
            return operand1;            
        }
    }
}
