namespace C_Sharp_Calculator
{
    public partial class Form1 : Form
    {
        private double previousStorage = 0;
        private string arithmeticOp = "";
        private bool operatorSelected = false;

        public void Calculate()
        {
            operatorSelected = true;
            double result;
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
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "1";
                operatorSelected = false;
                displayBox.Text += "1";
            }
            else
            {
                resultBox.Text += "1";
                displayBox.Text += "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "2";
                operatorSelected = false;
                displayBox.Text += "2";
            }
            else
            {
                resultBox.Text += "2";
                displayBox.Text += "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "3";
                operatorSelected = false;
                displayBox.Text += "3";
            }
            else
            {
                resultBox.Text += "3";
                displayBox.Text += "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "4";
                operatorSelected = false;
                displayBox.Text += "4";
            }
            else
            {
                resultBox.Text += "4";
                displayBox.Text += "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "5";
                operatorSelected = false;
                displayBox.Text += "5";
            }
            else
            {
                resultBox.Text += "5";
                displayBox.Text += "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "6";
                operatorSelected = false;
                displayBox.Text += "6";
            }
            else
            {
                resultBox.Text += "6";
                displayBox.Text += "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "7";
                operatorSelected = false;
                displayBox.Text += "7";
            }
            else
            {
                resultBox.Text += "7";
                displayBox.Text += "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "8";
                operatorSelected = false;
                displayBox.Text += "8";
            }
            else
            {
                resultBox.Text += "8";
                displayBox.Text += "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operatorSelected == true)
            {
                resultBox.Text = "9";
                operatorSelected = false;
                displayBox.Text += "9";
            }
            else
            {
                resultBox.Text += "9";
                displayBox.Text += "9";
            }
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (resultBox.Text != "0" || operatorSelected == true)
            {
                resultBox.Text = "0";
                operatorSelected = false;
                displayBox.Text += "0";
            }
            else
            {
                resultBox.Text += "0";
                displayBox.Text += "0";
            }
        }

        private void decimal_btn_Click(object sender, EventArgs e)
        {
            if (!resultBox.Text.Contains("."))
            {
                resultBox.Text += ".";
                displayBox.Text += ".";
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            displayBox.Text += " +";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "+";
            previousStorage = Convert.ToDouble(resultBox.Text);
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            displayBox.Text += " -";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "-";
            previousStorage = Convert.ToDouble(resultBox.Text);
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            displayBox.Text += " *";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "*";
            previousStorage = Convert.ToDouble(resultBox.Text);
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            displayBox.Text += " /";
            if (arithmeticOp != "")
            {
                Calculate();
            }
            operatorSelected = true;
            arithmeticOp = "/";
            previousStorage = Convert.ToDouble(resultBox.Text);
        }

        private void eq_btn_Click(object sender, EventArgs e)
        {
            Calculate();
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