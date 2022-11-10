//Mosè Barbieri, autore 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_CD
{
    internal class CD : brano 
    {
        List<brano> brani = new List<brano>(/*titolo, autore, durata*/);
        
        internal string titolo { get; set; }
        internal string autore { get; set; }

        internal CD( string brani, string autore, string titolo) 
        {
            this.brani = brani;
            this.autore = getAutore();
            this.titolo = getTitolo();
        }

        internal override void toString()
        {
            return brano.Items.toString();
        }

        internal virtual void Durata()
        {
            
        } 
    }
}
