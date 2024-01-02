using System.Diagnostics.CodeAnalysis;

namespace algorytm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf g = new Graf(4);
            g.dodajPo³¹czenia(0, 1, 2, 3);
            g.dodajPo³¹czenia(1, 2);
            Console.WriteLine("Nie istniej¹ krawêdzie:");
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 4; j++)
                    if (!g.sprawdŸKrawêdŸ(i, j))
                        Console.WriteLine("{0} z {1}", i, j);
            Console.ReadKey();
        }



    }

    // algorytm prima kruskala
    // konstruktor oparty na krawedzi
    // metoda sprawdz zwraca integera przyjmuje za parametr krawedz
    // jezeli lewy wierzcholek jest to ++ jezeli prawy wierzcholek jest to ++
    // metoda dodaj
    // finalna wersja to na samym koncu jeden graf
    




    class Graf
    {
        private List <Wierzcho³ek> wierzcho³ki = new List<Wierzcho³ek>();
        public Graf(int ile)
        {
            while (ile-- > 0)
                wierzcho³ki.Add(new Wierzcho³ek());
        }
        public void dodajPo³¹czenia(int id, params int[] po³¹czenia)
        {
            foreach (int krawêdŸ in po³¹czenia)
                wierzcho³ki[id].dodajKrawêdŸ(krawêdŸ);
        }
        public bool sprawdŸKrawêdŸ(int start, int koniec)
        {
            if (start > koniec)
                return sprawdŸKrawêdŸ(koniec, start);
            return wierzcho³ki[start].sprawdŸPo³¹czenie(koniec);
        }


    }


    class Wierzcho³ek
    {
        private List<int> po³¹czenia = new List<int>();
        public bool sprawdŸPo³¹czenie(int cel)
        {
            return po³¹czenia.IndexOf(cel) != -1;
        }
        public bool dodajKrawêdŸ(int cel)
        {
            if (sprawdŸPo³¹czenie(cel))
            {
                return false;
            }
            else
            {
                po³¹czenia.Add(cel);
                return true;
            }
        }
    }



}