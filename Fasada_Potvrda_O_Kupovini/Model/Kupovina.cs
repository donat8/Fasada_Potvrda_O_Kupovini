using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada_Potvrda_O_Kupovini.Model
{
    public class Kupovina
    {
        public int IdKupovine { get; set; }
        public int IdKupca { get; set; }
        public List<int> IdKupljenihProizvoda { get; set; }
    }
}
