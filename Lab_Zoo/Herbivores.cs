using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    class Herbivores : Animal , Animal_Interface
    {
        public Herbivores(int id, string name, double countFood, TypeOfFood type) : base(id, name, countFood, type) { }
        public void Sustenance()
        {
            switch (Type)
            {
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
        }

        public string Description()
        {
            return "Травоядные - животные, которые едят растения.";
        }

        public void Feed(Animal.TypeOfFood food)
        {
            if (this.Type == food)
            {
                Console.WriteLine("Вы покормили животноеs");
            }
            else Console.WriteLine("Не тот тип еды");
        }

       
    }
}
