using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public interface IModel
    {
        string ModelsName { get; }
        ConsoleColor Color { set; get; }
        Memory Memory { set; get; }
    }
}
