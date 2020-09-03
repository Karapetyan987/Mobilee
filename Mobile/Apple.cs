using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Apple : Mobile
    {
        public override string BrendsName { get => "Apple"; }
        public override string OgtagortsoxeriQanak { get => "209.1 Mln Users"; }
        public Apple()
        {

        }
        public override string ToString()
        {
            return BrendsName + " - " + OgtagortsoxeriQanak;
        }

    }
}
