﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Perro : Animal
    {
        public string Raza { get; set; }

        public override string comunicarse()
        {
            return "GUAU";
        }
    }
}
