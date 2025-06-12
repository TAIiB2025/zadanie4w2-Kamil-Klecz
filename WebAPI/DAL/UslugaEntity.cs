using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UslugaEntity
    {

        public int numer { get; set; }
        public required string nazwa { get; set; }
        public required string wykonawca { get; set; }
        public required string rodzaj { get; set; }
        public int rok { get; set; }
    }
}
