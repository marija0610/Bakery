using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_P2
{
    class Artikal
    {
        int id;
        String naziv;
        double cena;
        int popust;
        int id_g;
        
        public Artikal()
        {
        }

        public Artikal(string naziv, double cena, int popust, int id_g)
        {
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
            this.id_g = id_g;
        }

        public double vratiCenuPopust()
        {
            double cenaPopust = cena*(100 - popust)/100.0;
            return cenaPopust;
        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }
        public int Popust { get => popust; set => popust = value; }
        public int Id_g { get => id_g; set => id_g = value; }

        public override string ToString()
        {
            return naziv + " " + vratiCenuPopust().ToString() +" din";
        }

    }
}
