using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    public class Elephant : IMammal
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }
        public bool CanRun { get; set; }

        public int TrumpetLenghtInCentimetres {get; set;}
    }
}
