using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_P2
{
    class Racun
    {
        int idR;
        double cena;
        DateTime datIzdavanja;
        List<Artikal> listaA;

        public int IdR { get => idR; set => idR = value; }
        public double Cena { get => cena; set => cena = value; }
        public DateTime DatIzdavanja { get => datIzdavanja; set => datIzdavanja = value; }
        internal List<Artikal> ListaA { get => listaA; set => listaA = value; }

        public Racun( double cena, DateTime datIzdavanja, List<Artikal> listaA)
        {
            this.cena = cena;
            this.datIzdavanja = datIzdavanja;
            this.listaA = listaA;
        }

        public Racun()
        {
        }

        public override string ToString()
        {
            return idR + " datum izdavanja: " + datIzdavanja + " cena: " + cena;
        }
    }
}
