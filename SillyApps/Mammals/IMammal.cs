using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    public interface IMammal
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }
        public bool CanRun { get; set; }
    }
}
