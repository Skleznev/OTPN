using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    interface Animal_Interface
    {
        void Sustenance();
        string Description();
        void Feed(Animal.TypeOfFood food);

    }
}
