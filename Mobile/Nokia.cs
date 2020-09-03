using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Nokia : Mobile
    {
        public override string BrendsName { get => "Nokia"; }
        public override string OgtagortsoxeriQanak { get => "150 Mln Users"; }
        public Nokia()
        {

        }
        public override string ToString()
        {
            return BrendsName + " - " + OgtagortsoxeriQanak;

        }
    }
}
