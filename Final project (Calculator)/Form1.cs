using Calculator_Classes;
namespace Final_project__Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();
        MemoryCalculator memCalc = new MemoryCalculator();

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEqual.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutputResult.Text = String.Empty;
            calc.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                calc.CurrentValue = calc.Equals(calc.CurrentValue);
                txtOutputResult.Text = calc.CurrentValue.ToString();
            }
            catch (DivideByZeroException)
            {
                txtOutputResult.Text = "You can not divide by zero";
                calc.Clear();
            }
        }

        private void UpdateCurrentValue_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            string resultBefore = txtOutputResult.Text;
            if (resultBefore.Contains(".") || resultBefore.Contains("0") && resultBefore.Length > 1 ||
                resultBefore.Contains("1") || resultBefore.Contains("2") || resultBefore.Contains("3") ||
                resultBefore.Contains("4") ||
                resultBefore.Contains("5") || resultBefore.Contains("6") || resultBefore.Contains("7") ||
                resultBefore.Contains("8") || resultBefore.Contains("9") || resultBefore.Contains("-1") ||
                resultBefore.Contains("-2") || resultBefore.Contains("-3") || resultBefore.Contains("-4") ||
                resultBefore.Contains("-5") || resultBefore.Contains("-6") || resultBefore.Contains("-7") ||
                resultBefore.Contains("-8") || resultBefore.Contains("-9"))
            {                
                string result = txtOutputResult.Text += button.Text;
                calc.CurrentValue = decimal.Parse(result);
                txtOutputResult.Text = result;                                
            }

            else
            {
                calc.CurrentValue = decimal.Parse(button.Text);
                txtOutputResult.Text = button.Text;                                
            }
            
        }

        private void UpdateCurrentOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (calc.Op != Calculator.operator_enumeration.None)
            {
                calc.CurrentValue = calc.Equals(calc.CurrentValue);
                txtOutputResult.Text = calc.CurrentValue.ToString();
            }

            switch (button.Text)
            {
                case "+":
                    calc.Add(calc.CurrentValue);
                    calc.Op = Calculator.operator_enumeration.Add;
                    txtOutputResult.Text = button.Text;
                    break;

                case "-":
                    calc.Subtract(calc.CurrentValue);
                    calc.Op = Calculator.operator_enumeration.Subtract;
                    txtOutputResult.Text = button.Text;
                    break;

                case "*":
                    calc.Multiply(calc.CurrentValue);
                    calc.Op = Calculator.operator_enumeration.Multiply;
                    txtOutputResult.Text = button.Text;
                    break;

                case "/":
                    calc.Divide(calc.CurrentValue);
                    calc.Op = Calculator.operator_enumeration.Divide;
                    txtOutputResult.Text = button.Text;
                    break;


            }
                        
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                UpdateCurrentValue_Click(btnOne, EventArgs.Empty);
            }
            else if (e.KeyChar == '2')
            {
                UpdateCurrentValue_Click(btnTwo, EventArgs.Empty);
            }
            else if (e.KeyChar == '3')
            {
                UpdateCurrentValue_Click(btnThree, EventArgs.Empty);
            }
            else if (e.KeyChar == '4')
            {
                UpdateCurrentValue_Click(btnFour, EventArgs.Empty);
            }
            else if (e.KeyChar == '5')
            {
                UpdateCurrentValue_Click(btnFive, EventArgs.Empty);
            }
            else if (e.KeyChar == '6')
            {
                UpdateCurrentValue_Click(btnSix, EventArgs.Empty);
            }
            else if (e.KeyChar == '7')
            {
                UpdateCurrentValue_Click(btnSeven, EventArgs.Empty);
            }
            else if (e.KeyChar == '8')
            {
                UpdateCurrentValue_Click(btnEight, EventArgs.Empty);
            }
            else if (e.KeyChar == '9')
            {
                UpdateCurrentValue_Click(btnNine, EventArgs.Empty);
            }
            else if (e.KeyChar == '0')
            {
                UpdateCurrentValue_Click(btnZero, EventArgs.Empty);
            }
            else if (e.KeyChar == '+')
            {
                UpdateCurrentOperator_Click(btnPlus, EventArgs.Empty);
            }
            else if (e.KeyChar == '-')
            {
                UpdateCurrentOperator_Click(btnMinus, EventArgs.Empty);
            }
            else if (e.KeyChar == '*')
            {
                UpdateCurrentOperator_Click(btnMultiply, EventArgs.Empty);
            }
            else if (e.KeyChar == '/')
            {
                UpdateCurrentOperator_Click(btnSlash, EventArgs.Empty);
            }
            else if (e.KeyChar == '.')
            {
                btnDot_Click(btnDot, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnEqual_Click(btnEqual, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                btnBack_Click(btnBack, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Delete)
            {
                btnClear_Click(btnClear, EventArgs.Empty);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (!txtOutputResult.Text.Contains(".") && txtOutputResult.Text != "")
            {
                txtOutputResult.Text += ".";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string newResult = calc.Back(txtOutputResult.Text);
            txtOutputResult.Text = newResult;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memCalc.MemoryClear();
            txtOutputM.Text = "";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memCalc.MemoryStore(calc.CurrentValue);
            txtOutputM.Text = "M";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            memCalc.MemoryRecall(calc);
            txtOutputResult.Text = calc.CurrentValue.ToString();
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memCalc.MemoryAdd(calc.CurrentValue);
            txtOutputM.Text = "M";
        }

        private void btnEqual_Leave(object sender, EventArgs e)
        {
            btnEqual.Focus();
        }

        private void btnPlusSlashMinus_Click(object sender, EventArgs e)
        {
            string val = calc.CurrentValue.ToString();
            decimal newValue;
            if (val.Contains("-"))
            {
                newValue = calc.CurrentValue = decimal.Parse(val.Substring(1));
            }
            else
            {
                newValue = calc.CurrentValue = decimal.Parse("-" + val);
            }
            txtOutputResult.Text = newValue.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(Convert.ToDouble(calc.CurrentValue));
            txtOutputResult.Text = sqrt.ToString();
            calc.CurrentValue = decimal.Parse(sqrt.ToString());
        }

        private void btnOneSlashX_Click(object sender, EventArgs e)
        {
            decimal oneToX = 1 / calc.CurrentValue;
            calc.CurrentValue = oneToX;
            txtOutputResult.Text = calc.CurrentValue.ToString();
        }
    }
}