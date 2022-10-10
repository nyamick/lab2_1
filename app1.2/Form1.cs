namespace app1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumber.Text = Properties.Settings.Default.number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
    public class Logic
    {
        public static int Calculate(int number)
        {
            var maxNumber = number / 10 % 10;

            if (number / 100 > maxNumber)
            {
                maxNumber = number / 100;
            }
            if (number % 10 > maxNumber)
            {
                maxNumber = number % 10;
            }

            return maxNumber;
        }

    }

}