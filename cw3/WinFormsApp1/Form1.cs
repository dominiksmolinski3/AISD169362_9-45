using System.Xml.Linq;

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
            var w1 = new W�zel(5);
            var w2 = new W�zel(1);
            var w3 = new W�zel(2);
            var w4 = new W�zel(3);
            var w5 = new W�zel(8);
            var w6 = new W�zel(4);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w2.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w3.dzieci.Add(w6);
            MessageBox.Show(w1.wartosc.ToString());
            A(w1);
        }

        void A(W�zel w)
        {
            foreach (var element in w.dzieci)
            {
                MessageBox.Show(element.wartosc.ToString());
                A(element);
            }
        }
    }
}