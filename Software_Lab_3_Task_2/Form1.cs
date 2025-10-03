namespace Software_Lab_3_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Calculate(double x, double y, double z)
        {
            double yRad = y * Math.PI / 180;
            double p1 = z * Math.Cos(yRad);
            double p2 = Math.Sqrt(Math.Exp(1) * 7);
            double p3 = Math.Abs(Math.Cos(yRad));
            return p1 + p2 - p3;
        }
        private void CalculateExpression()
        {
            try
            {
                double x = Convert.ToDouble(ForX.Text);
                double y = Convert.ToDouble(ForY.Text);
                double z = Convert.ToDouble(ForZ.Text);
                double result = Calculate(x, y, z);
                Text = Convert.ToString($" Результат: {result:F4}");
            }
            catch (Exception)
            {
                Text = " ERROR";
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ForX.Text = Convert.ToString(e.X);
            ForY.Text = Convert.ToString(e.Y);
            CalculateExpression();
        }
        private void ForZ_TextChanged(object sender, EventArgs e)
        {
            CalculateExpression();
        }
    }
}
