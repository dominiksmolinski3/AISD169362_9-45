using System.CodeDom.Compiler;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        static int Minimum(int[] tab, int startIndex)
        {
            int wynik = startIndex;
            for (int i=0; i < tab.Length; i++)
            {
                if (tab[i] < tab[wynik]) wynik = i;
            }
            return wynik;
        }
        

        static void SelectionSort(int[] tab)
        {
            int min;
            int temp;
            for (int i = 0; i < tab.Length-1; i++)
            {
                    min = Minimum(tab, i);
                    temp = tab[i];
                    tab[i] = tab[min];
                    tab[min] = temp;
            }
        }
    }
}