using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Gato : Animal
    {
        public int MyProperty { get; set; }
        Duenio _duenio = new Duenio();

        public override string comunicarse()
        {
            return "MIAU";
        }
    }
}
