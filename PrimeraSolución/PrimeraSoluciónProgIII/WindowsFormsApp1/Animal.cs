﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        public virtual string comunicarse()
        {
            return "GRRRR";
        }
    }
}
