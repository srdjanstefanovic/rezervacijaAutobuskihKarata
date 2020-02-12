using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string nazivTabele { get; }
        string primarniKljuc { get; }

        //uslov vezan za primarni kljuc
        string uslovPrimarni { get; } 

        //uslov za ostale atribute; rad sa vise redova u tabeli
        string uslovOstalo { get; }
        
        //update
        string izmena { get; } 
        //insert
        string unos { get; }

        OpstiDomenskiObjekat Procitaj(DataRow red);

    }
}
