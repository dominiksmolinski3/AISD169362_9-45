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

        private Wezel3 znajdzRodzica(int liczba)
        {
            throw new NotImplementedException();
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

        internal void Add(int liczba)
        {
            throw new NotImplementedException();
        }
    }

}