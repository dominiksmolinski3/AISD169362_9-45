namespace BTS
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

        
    }

    public class DrzewoBinarne
    {
        public Wezel3 korzeñ;
        public DrzewoBinarne(int liczba)
        {
            this.korzeñ = new Wezel3(liczba);
        }

        public void Add(int liczba)
        {
            Wezel3 rodzic = this.znajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        public Wezel3 znajdzRodzica(int liczba)
        {
            var w = this.korzeñ;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko == null)
                    {
                        return w;
                    }
                    else w = w.leweDziecko;
                }

                else
                {
                    if (w.praweDziecko == null) {
                        return w;

                    }
                    else w = w.praweDziecko;
                }

            }
        }

        public Wezel3 znajdzMin (Wezel3 w)
        {
            while (w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }
            return w;
        }

        public Wezel3 znajdzMax (Wezel3 w)
        {
            while (w.praweDziecko != null)
            {
                w = w.praweDziecko;
            }
            return w;
        }

        public Wezel3 Znajdz(int liczba)
        {
            var w = this.korzeñ
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko != null)
                    {
                        w = w.leweDziecko;
                    }
                    else return null;
                }
                else return null;
            }

        }

        public Wezel3 Nastepnik (Wezel3 w)
        {
            if (w.praweDziecko != null)
            {
                return this.znajdzMin(w.praweDziecko);
            }

            while (w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                {
                    return w.rodzic;
                }
                w = w.rodzic;
            }
            return null;
                
        }

        public Wezel3 Poprzednik (Wezel3 w)
        {
            if (w.leweDziecko != null)
            {
                return this.znajdzMax(w.leweDziecko);

            }

            while (w.rodzic != null)
            {
                if (w.rodzic.praweDziecko == w)
                {
                    return w.rodzic;

                }
                w = w.rodzic;
            }
            return null;
        }

        public Wezel3 Remove(Wezel3 w)
        {
            switch (w.getLiczbaDzieci())
            {
                case 0:
                    return w = this.RemoveWhen0(w);
                    break;
                case 1:
                    w = this.RemoveWhen1(w);
                    break;
                case 2:
                    w = this.RemoveGdy2(w);

            }
            return w;
        }

        public Wezel3 RemoveWhen0 (Wezel3 w)
        {
            if (w.rodzic == null)
            {
                this.korzeñ = null;
                return w;
            }

            if (w.rodzic.leweDziecko == w)
            {
                w.rodzic.leweDziecko = null;

            }
            else w.praweDziecko = null;

            w.rodzic = null;
            return w;
        }

        public Wezel3 RemoveWhen1 (Wezel3 w)
        {
            Wezel3 dziecko = null;

            if (w.leweDziecko != null)
            {
                dziecko = w.leweDziecko;
                w.leweDziecko = null;
            }
            else dziecko = w.praweDziecko;
            w.praweDziecko = null;
            dziecko.rodzic = w.rodzic;

            if (w.rodzic == null)
            {
                this.korzeñ = dziecko;
            }
            else
            {
                if (w.rodzic.leweDziecko == w)
                {
                    w.rodzic.leweDziecko = dziecko;
                }
                else w.rodzic.praweDziecko = dziecko;
            }
            w.rodzic = null;
            return w;

        }

    }




    public class Wezel3
    {
        public int wartosc;
        public Wezel3 rodzic;
        public Wezel3 leweDziecko;
        public Wezel3 praweDziecko;


        public Wezel3(int liczba)
        {
            this.wartosc = liczba;
        }

        public override string ToString()
        {
            return this.wartosc.ToString();
        }

        public void Add(int liczba)
        {
            var dziecko = new Wezel3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartosc)
            {
                this.leweDziecko = dziecko;
            }
            else this.praweDziecko = dziecko;


        }


        public int getLiczbaDzieci()
        {
            int wynik = 0;
            if (this.leweDziecko != null)
            {
                wynik++;
            }
            if (this.praweDziecko != null)
            {
                wynik++;
            }
            return wynik;
        }
        


        
    }

}