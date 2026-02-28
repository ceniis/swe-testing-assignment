namespace Quick_Calc
{
    public partial class Form : System.Windows.Forms.Form
    {
        string operation = string.Empty;
        string firstNum, secondNum;
        bool enterValue = false;
        int result = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

            if (textDisplay2.Text == "0" || enterValue)
                textDisplay2.Text = "";

            enterValue = false;
            textDisplay2.Text += button.Text;
        }

        private void Btn_MathOp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

            if (textDisplay2.Text == "") return;

            if (result != 0)
                buttonEqual.PerformClick();
            else
                result = int.Parse(textDisplay2.Text);

            operation = button.Text;
            enterValue = true;

            textDisplay1.Text = result + " " + operation;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textDisplay2.Text == "" || operation == "") return;

            secondNum = textDisplay2.Text;
            textDisplay1.Text = $"{result} {operation} {secondNum} =";

            int second = int.Parse(secondNum);

            switch (operation)
            {
                case "+":
                    result = result + second;
                    break;

                case "-":
                    result = result - second;
                    break;

                case "×":
                    result = result * second;
                    break;

                case "÷":
                    if (second == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result = result / second;
                    break;
            }

            textDisplay2.Text = result.ToString();
            operation = string.Empty;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay2.Text = "0";
            textDisplay1.Clear();
            result = 0;
            operation = string.Empty;
        }
    }
}
