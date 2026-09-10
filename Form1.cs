namespace GradeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int grade = int.Parse(textBox1.Text);
            if (grade >= 75)
            {
                label2.Text = "Passed";

            }
            else
            {
                label2.Text = "Failed";
            }
        }
    }
}
