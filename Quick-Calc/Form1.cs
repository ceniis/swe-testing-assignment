namespace Quick_Calc
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Calculator calc = new Calculator();
        private string operation = string.Empty;
        private bool enterValue = false;

        public Form()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Display the numbers
        /// </summary>
        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textDisplay1.Text == "0" || enterValue)
                textDisplay1.Text = "";

            string newText = textDisplay1.Text + button.Text;

            // block input if number > 100000
            if (int.TryParse(newText, out int newNumber) && newNumber > 100_000)
            {
                MessageBox.Show("Maximum input is 100000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            enterValue = false;
            textDisplay1.Text = newText;
        }


        /// <summary>
        /// Display the first number and the operation
        /// </summary>
        private void Btn_MathOp_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "") return;
            calc.Result = int.Parse(textDisplay1.Text);
            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            textDisplay2.Text = $"{calc.Result} {operation}";
        }

        /// <summary>
        /// Count the result of the operation and display it 
        /// </summary>
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "" || string.IsNullOrEmpty(operation)) return;
            int second = int.Parse(textDisplay1.Text);
            try
            {
                calc.Result = calc.Calculate(calc.Result, second, operation);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textDisplay1.Text = calc.Result.ToString();
            textDisplay2.Text += $" {second} =";
            operation = string.Empty;
            enterValue = true;
        }

        /// <summary>
        /// Clear all text boxes and reset variables to default values
        /// </summary>
        private void buttonC_Click(object sender, EventArgs e)
        {
            calc.Clear();
            textDisplay1.Text = "0";
            textDisplay2.Clear();
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
