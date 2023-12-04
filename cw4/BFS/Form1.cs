namespace BFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(5);
            var w2 = new Wezel2(1);
            var w3 = new Wezel2(2);
            var w4 = new Wezel2(3);
            var w5 = new Wezel2(8);
            var w6 = new Wezel2(4);
            w1.sasiedzi.Add(w2);
            w2.sasiedzi.Add(w4);
            w2.sasiedzi.Add(w5);
            w4.sasiedzi.Add(w6);
            w6.sasiedzi.Add(w3);
            w5.sasiedzi.Add(w3);
            


            //Przeszukiwanie wszerz
            List<Wezel2> odwiedzone = new List<Wezel2>() { w1 };
            BFS(odwiedzone);

        }
        void BFS(List<Wezel2> odwiedzone)
        {

            for (int i = 0; i < odwiedzone.Count; i++)
            {
                var w = odwiedzone[i];
                MessageBox.Show(w.wartosc.ToString());
                foreach (var s¹siad in w.sasiedzi)
                {
                    if (!odwiedzone.Contains(s¹siad))
                    {
                        odwiedzone.Add(s¹siad);
                    }
                }

            }
        }





    }
    public class Wezel2
    {
        public int wartosc;
        public List<Wezel2> sasiedzi = new List<Wezel2>();

        public Wezel2(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}