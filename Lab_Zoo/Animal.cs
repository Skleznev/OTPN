using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    abstract class Animal
    {
        public enum TypeOfFood
        {
            Cabbage,
            Carrot,
            Pumkin,
            Pork,
            Beef,
            Chicken
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double CountFood { get; set; }
        public TypeOfFood Type { get; set; }
        bool inCase = false;
                
        public override string ToString()
        {
            return string.Format($"{Id} { Name} { CountFood} {Type}");
        }

        public Animal(int id, string name, double countFood, TypeOfFood type) { Id = id; Name = name; CountFood = countFood; Type = type; }

        public void addInCase()
        {
            inCase = true;
        }

        public void removeFromCase()
        {
            inCase = false;
        }
        
        public bool getInCase()
        {
            return inCase;
        }

    }
}
