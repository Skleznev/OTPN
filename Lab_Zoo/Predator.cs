using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    internal class Predator : Animal, Animal_Interface
    {
        public Predator(int id, string name, double countFood, TypeOfFood type) : base(id, name, countFood, type) { }
        public void Sustenance()//Некая формула расчета 
        {
            switch (Type)
            {
                case TypeOfFood.Beef:
                    CountFood *= 200;
                    break;
                case TypeOfFood.Pork:
                    CountFood *= 100;
                    break;
                case TypeOfFood.Chicken:
                    CountFood *= 50;
                    break;
                default:
                    CountFood *= 0;
                    break;
            }
            CountFood += 200;

        }

        public string Description()
        {
            return "Животные, питающиеся преимущественно мясом";
        }

        public void Feed(Animal.TypeOfFood food)
        {
            if (this.Type == food)
            {
                Console.WriteLine("Вы покормили животное");
                Console.WriteLine("Вас укусил " + Name);
            }
            else Console.WriteLine("Не тот тип еды");
        }
    }
}
