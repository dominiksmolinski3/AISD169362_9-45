using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Węzel
    {
        public int wartosc;
        public List<Węzel> dzieci = new();
        
        public Węzel (int liczba)
        {
            this.wartosc = liczba;

        }


    }
}
