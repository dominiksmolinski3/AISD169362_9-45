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
            g.dodajPo��czenia(0, 1, 2, 3);
            g.dodajPo��czenia(1, 2);
            Console.WriteLine("Nie istniej� kraw�dzie:");
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 4; j++)
                    if (!g.sprawd�Kraw�d�(i, j))
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
        private List <Wierzcho�ek> wierzcho�ki = new List<Wierzcho�ek>();
        public Graf(int ile)
        {
            while (ile-- > 0)
                wierzcho�ki.Add(new Wierzcho�ek());
        }
        public void dodajPo��czenia(int id, params int[] po��czenia)
        {
            foreach (int kraw�d� in po��czenia)
                wierzcho�ki[id].dodajKraw�d�(kraw�d�);
        }
        public bool sprawd�Kraw�d�(int start, int koniec)
        {
            if (start > koniec)
                return sprawd�Kraw�d�(koniec, start);
            return wierzcho�ki[start].sprawd�Po��czenie(koniec);
        }


    }


    class Wierzcho�ek
    {
        private List<int> po��czenia = new List<int>();
        public bool sprawd�Po��czenie(int cel)
        {
            return po��czenia.IndexOf(cel) != -1;
        }
        public bool dodajKraw�d�(int cel)
        {
            if (sprawd�Po��czenie(cel))
            {
                return false;
            }
            else
            {
                po��czenia.Add(cel);
                return true;
            }
        }
    }



}