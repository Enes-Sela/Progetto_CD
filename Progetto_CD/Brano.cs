using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_CD
{
    internal class Brano
    {
        public string titolo { get; set; }
        public string autore { get; set; } 
        public int durata { get; set; }

        internal Brano(string Titolo,string Autore,int Durata) 
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.durata = Durata;
        }

        internal string toString() 
        {
            return "Autore : " + autore + "Titolo : " + titolo + "Durata : " + durata;
        }

        internal bool shortSong(int d) 
        {
            if (durata < d)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
