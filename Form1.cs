namespace Calc
{
    public partial class Form1 : Form
    {

        double Answer = 0;
        string Operation = string.Empty;
        string Num1, Num2;

        bool EnterVal = false;
        bool Equal = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDelChar_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length > 0)
            {
                TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1, 1);
            }

        }

        private void buttonDelAll_Click(object sender, EventArgs e)
        {
            TextBox2.Text = string.Empty;
            TextBox1.Text = string.Empty;
            Answer = 0;
        }

        private void buttonDelLast_Click(object sender, EventArgs e)
        {
            TextBox2.Text = string.Empty;
            TextBox1.Text = string.Empty;
        }

        private void ButtonNumClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (TextBox2.Text == "0" && !(button.Text == ",")) TextBox2.Text = string.Empty;

            if (Equal == true)
            {
                TextBox2.Text = string.Empty;
            }

            if (button.Text == ",")
            {
                if (!TextBox2.Text.Contains(",") && TextBox2.Text != string.Empty)
                {
                    TextBox2.Text += ",";
                }
            }
            else
            {
                TextBox2.Text = TextBox2.Text + button.Text;
            }
            EnterVal = true;
            Equal = false;

        }

        private void ButtonMathOper(object sender, EventArgs e)
        {
            Equal = false;
            if (Answer != 0) ButtonEqual.PerformClick();
            else Answer = double.Parse(TextBox2.Text);

            Button button = (Button)sender;
            Operation = button.Text;

            if (TextBox2.Text != "0")
            {
                TextBox1.Text = Num1;
                TextBox1.Text = $"{Answer} {Operation}";
                TextBox2.Text = string.Empty;
            }

        }

        private void ButtonSelfOper(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = button.Text;

            switch (Operation)
            {
                case "⅟x":
                    TextBox1.Text = $"1/({TextBox2.Text})";
                    TextBox2.Text = (1.0 / Double.Parse(TextBox2.Text)).ToString();
                    break;
                case "x^2":
                    TextBox1.Text = $"sqr({TextBox2.Text})";
                    TextBox2.Text = (Math.Pow(Double.Parse(TextBox2.Text), 2)).ToString();
                    break;
                case "√x":
                    TextBox1.Text = $"sqrt({TextBox2.Text})";
                    TextBox2.Text = (Math.Sqrt(Double.Parse(TextBox2.Text))).ToString();
                    break;
                case "%":
                    TextBox1.Text = $"%({TextBox2.Text})";
                    TextBox2.Text = (Double.Parse(TextBox2.Text) / 100).ToString();
                    break;
                case "±":
                    TextBox1.Text = $"±({TextBox2.Text})";
                    TextBox2.Text = (Double.Parse(TextBox2.Text) * -1).ToString();
                    break;

            }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            Equal = false;

            Num2 = TextBox2.Text;
            TextBox1.Text = $"{TextBox1.Text} {TextBox2.Text} = ";
            if (TextBox2.Text != string.Empty)
            {
                if (TextBox2.Text == "0") TextBox1.Text = string.Empty;

                switch (Operation)
                {
                    case "+":
                        TextBox2.Text = (Answer + Double.Parse(TextBox2.Text)).ToString();
                        break;

                    case "−":
                        TextBox2.Text = (Answer - Double.Parse(TextBox2.Text)).ToString();
                        break;

                    case "×":
                        TextBox2.Text = (Answer * Double.Parse(TextBox2.Text)).ToString();
                        break;

                    case "÷":
                        TextBox2.Text = (Answer / Double.Parse(TextBox2.Text)).ToString();
                        break;
                    default:
                        TextBox1.Text = $"{TextBox2.Text}";
                        break;

                }
                Answer = Double.Parse(TextBox2.Text);
                Operation = string.Empty;
                Equal = true;
            }

        }

        private void ButtonExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonFull(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ButtonCollapse(object sender, EventArgs e)
        {
            this.WindowState ^= FormWindowState.Minimized;
        }
    }
}