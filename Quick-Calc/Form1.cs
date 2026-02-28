namespace Quick_Calc
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        string operation = string.Empty;
        string secondNum;
        bool enterValue = false;
        int result = 0;

        /// <summary>
        /// Display the numbers
        /// </summary>
        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textDisplay2.Text == "0" || enterValue)
                textDisplay2.Text = "";

            enterValue = false;
            textDisplay2.Text += button.Text;
        }

        /// <summary>
        /// Display the first number and the operation
        /// </summary>
        private void Btn_MathOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textDisplay2.Text == "") return;

            result = int.Parse(textDisplay2.Text);
            operation = button.Text;
            enterValue = true;

            textDisplay1.Text = result + " " + operation;
        }

        /// <summary>
        /// Count the result of the operation and display it 
        /// </summary>
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textDisplay2.Text == "" || operation == "") return;

            secondNum = textDisplay2.Text;
            textDisplay1.Text = $"{result} {operation} {secondNum} =";

            int second = int.Parse(secondNum);

            switch (operation)
            {
                case "+":
                    result += second;
                    break;

                case "-":
                    result -= second;
                    break;

                case "×":
                    result *= second;
                    break;

                case "÷":
                    if (second == 0) // div by zero check
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result /= second;
                    break;
            }

            textDisplay2.Text = result.ToString();
            operation = string.Empty;
            enterValue = true;
        }

        /// <summary>
        /// Clear all text boxes and reset variables to default values
        /// </summary>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay2.Text = "0";
            textDisplay1.Clear();
            result = 0;
            operation = string.Empty;
            enterValue = false;
        }
        /// <summary>
        /// Block keyboard input tp text boxes
        /// </summary>
        private void textDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
