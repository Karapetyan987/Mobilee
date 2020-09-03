using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Samsung : Mobile
    {
        public override string BrendsName { get => "Samsung"; }
        public override string OgtagortsoxeriQanak { get => "295 Mln Users"; }
        public Samsung()
        {

        }
        public override string ToString()
        {
            return BrendsName + " - " + OgtagortsoxeriQanak;

        }
    }
}
