using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake.models
{
    [Serializable]
    class Wall : Drawer
    {
        public Wall() { }

        public Wall(char _sign, ConsoleColor _color) : base(_sign, _color) { }

    }
}
