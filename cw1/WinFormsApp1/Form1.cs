namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            int a = fib(n);
            label1.Text = a.ToString();
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            int a = fib(n);
            label1.Text = a.ToString();
        }

        static int fib(int n)
        {

            int[] tab = new int[n + 2];

            int i;

            tab[0] = 0;
            tab[1] = 1;

            for (i = 2; i <= n; i++)
            {
                tab[i] = tab[i - 1] + tab[i - 2];
            }

            return tab[n];
        }

    }
}