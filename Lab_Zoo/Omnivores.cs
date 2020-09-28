using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    class Omnivores : Animal, Animal_Interface
    {
        public Omnivores(int id, string name, double countFood, TypeOfFood type) : base(id, name, countFood, type) { }
        public void Sustenance()
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
                case TypeOfFood.Cabbage:
                    CountFood *= 50;
                    break;
                case TypeOfFood.Carrot:
                    CountFood *= 100;
                    break;
                case TypeOfFood.Pumkin:
                    CountFood *= 150;
                    break;
                default:
                    CountFood *= 0;
                    break;
            }
            CountFood += 100;
        }

        public string Description()
        {
            return "Всеядные животные - это животные, которые могут употреблять как животный, так и растительный корм. ";
        }

        public void Feed(Animal.TypeOfFood food)
        {
            if (this.Type == food)
            {
                Console.WriteLine("Вы покормили животное");
            }
            else Console.WriteLine("Не тот тип еды");
        }

    }
}
