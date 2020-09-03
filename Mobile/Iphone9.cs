using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Iphone9 : Apple, IModel
    {
        public Iphone9(ConsoleColor c = ConsoleColor.Black, Memory m = Memory.less)
        {
            memory = m;
            color = c;
        }
        ConsoleColor color = ConsoleColor.Black;
        Memory memory = Memory.less;

        public ConsoleColor Color { get => color; set => color = value; }
        public Memory Memory { get => memory; set => memory = value; }
        public string ModelsName { get => "Iphone9"; }

        public override string ToString()
        {
            return base.ToString() + $", Model - {ModelsName} , Color - {color} , Memory - {memory}({(int)memory}GB)";
        }
    }
}
