using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_P2
{
    class Grupa
    {
        int id;
        String naziv;

        public Grupa(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }

        public Grupa()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
