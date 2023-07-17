namespace Летняя_практика_22_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector b = new Vector(Convert.ToDouble(textBox_x1.Text), Convert.ToDouble(textBox_y1.Text), Convert.ToDouble(textBox_z1.Text));
            Vector c = new Vector(Convert.ToDouble(textBox_x2.Text), Convert.ToDouble(textBox_y2.Text), Convert.ToDouble(textBox_z2.Text));
            double len_b = Vector.Vect_length(b.X, b.Y, b.Z);
            double skal = Vector.Skal_pr(b, c);
            List<double> vec = Vector.Vekt_pr(b, c);
            double koef = len_b / skal;
            //double answer = len_b / (skal * vec);
            label11.Text += "{ " + Convert.ToString(vec[0] * koef) + " ; " + Convert.ToString(vec[1] * koef) + " ; " + Convert.ToString(vec[2] * koef) + " }";
            //label11.Text += Convert.ToString(answer);
        }
    }
}