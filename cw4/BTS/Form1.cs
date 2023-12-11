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


    }

}