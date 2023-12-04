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
            Wezel w1 = new Wezel(1);
            Wezel w2 = new Wezel(2);
            Wezel w3 = new Wezel(3);
            Wezel w4 = new Wezel(7);
            Wezel w5 = new Wezel(4);
            Wezel w6 = new Wezel(5);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            w5.dzieci.Add(w4);

            DFS(w1);
        }

        List<Wezel> odwiedzone = new List<Wezel>();
        void DFS(Wezel w)
        {
            MessageBox.Show(w.wartosc.ToString());
            odwiedzone.Add(w);
            foreach (var element in w.dzieci)
            {
                if (!odwiedzone.Contains(element))
                {
                    DFS(element);
                }
            }
        }
    }



    public class Wezel
    {
        public int wartosc;
        public List<Wezel> dzieci = new List<Wezel>();

        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}