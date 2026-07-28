namespace Assignment_4._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Basic Clear and Exit button controls
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Instance of the MyMath class and declared variables
        private ICalculator calculator = new MyMath();
        private double num1;
        private double num2;

        // Operator button instructions
        private void AddBtn_Click(object sender, EventArgs e)
        {
            double.TryParse(Num1.Text, out num1);
            double.TryParse(Num2.Text, out num2);

            ResultDisplay.Text = (calculator.Add(num1, num2).ToString());
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            double.TryParse(Num1.Text, out num1);
            double.TryParse(Num2.Text, out num2);

            ResultDisplay.Text = (calculator.Subtract(num1, num2).ToString());
        }

        private void TimesBtn_Click(object sender, EventArgs e)
        {
            double.TryParse(Num1.Text, out num1);
            double.TryParse(Num2.Text, out num2);

            ResultDisplay.Text = (calculator.Multiply(num1, num2).ToString());
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            double.TryParse(Num1.Text, out num1);
            double.TryParse(Num2.Text, out num2);

            ResultDisplay.Text = (calculator.Divide(num1, num2).ToString());
        }
    }

    // Create Interface
    public interface ICalculator
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);

    }

    // Create class that will inherit the interface
    public class MyMath : ICalculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (num1 / num2);
        }
    }
}
