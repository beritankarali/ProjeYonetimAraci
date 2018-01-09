using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımSınamaProje
{
    public class Proje
    {
        List<IsSureci> issureci = new List<IsSureci>();
        public List<IsSureci> isSureci
        {
            get { return issureci; }
        }
    }
}
