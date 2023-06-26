namespace C_Sharp_Calc__Short_Version_
{
    public partial class Form1 : Form
    {
        private double previousStorage = 0;
        private string arithmeticOp = "";
        private bool operatorSelected = false;
        private double result;

        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {
            operatorSelected = true;

            if (arithmeticOp == "+")
            {
                result = previousStorage + Convert.ToDouble(resultBox.Text);
                resultBox.Text = result.ToString();
            }
            else if (arithmeticOp == "-")
            {
                result = previousStorage - Convert.ToDouble(resultBox.Text);
                resultBox.Text = result.ToString();
            }
            else if (arithmeticOp == "*")
            {
                result = previousStorage * Convert.ToDouble(resultBox.Text);
                resultBox.Text = result.ToString();
            }
            else if (arithmeticOp == "/")
            {
                result = previousStorage / Convert.ToDouble(resultBox.Text);
                resultBox.Text = result.ToString();
            }
            else if (arithmeticOp == ".")
            {
                result = previousStorage;
            }
            previousStorage = 0; //clears the previous storage so that the next operation can be performed. Otherwise it would just keep adding to the previous result
        }

        private void num_click(object sender, EventArgs e)
        {
            Button numBtn = (Button)sender;
            if (resultBox.Text == "0")
            {
                resultBox.Text = numBtn.Text;
                if (!operatorSelected)
                {
                    displayBox.Text += numBtn.Text;
                }
                else
                {
                    displayBox.Text += " " + numBtn.Text;
                }
            }
            else if (resultBox.Text == Convert.ToString(result))
            {
                resultBox.Text = numBtn.Text;
            }
            else if (resultBox.Text != "0" && arithmeticOp != "")
            {
                resultBox.Text += numBtn.Text;
                displayBox.Text += numBtn.Text;
            }
            else
            {
                resultBox.Text += numBtn.Text;
                if (!operatorSelected)
                {
                    displayBox.Text += numBtn.Text;
                }
                else
                {
                    displayBox.Text += " " + arithmeticOp + " " + numBtn.Text;
                }
            }
            operatorSelected = false;
        }

        private void decimal_btn_Click(object sender, EventArgs e)
        {
            if (!resultBox.Text.Contains("."))
            {
                resultBox.Text += ".";
                displayBox.Text += ".";
            }
        }

        private void add_click(object sender, EventArgs e)
        {
            displayBox.Text += " + ";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "+";
            previousStorage = Convert.ToDouble(resultBox.Text);
            resultBox.Clear();
        }

        private void sub_click(object sender, EventArgs e)
        {
            displayBox.Text += " - ";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "-";
            previousStorage = Convert.ToDouble(resultBox.Text);
            resultBox.Clear();
        }

        private void mult_click(object sender, EventArgs e)
        {
            displayBox.Text += " * ";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "*";
            previousStorage = Convert.ToDouble(resultBox.Text);
            resultBox.Clear();
        }

        private void div_click(object sender, EventArgs e)
        {
            displayBox.Text += " / ";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "/";
            previousStorage = Convert.ToDouble(resultBox.Text);
            resultBox.Clear();
        }

        private void eq_btn_Click(object sender, EventArgs e)
        {
            Calculate();
            //displayBox.Text += " = "; //works but not needed and makes the displaybox look weird
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (resultBox.Text != "")
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.TextLength - 1);
                displayBox.Text = displayBox.Text.Substring(0, displayBox.TextLength - 1);
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            displayBox.Clear();
            resultBox.Clear();
            previousStorage = 0;
            arithmeticOp = "";
        }
    }
}