using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    abstract class Cell
    {
        public enum Size
        {
            Big,
            Medium,
            Small
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Сapacity { get; set; }
        public List<Animal> ListAnimal = new List<Animal>();
        public Cell(int id, string name, int capacity) { Id = id; Name = name; Сapacity = capacity; }


        public bool isEmpty()
        {
            return ListAnimal.Count == 0;
        }

        public bool isFull()
        {
            return ListAnimal.Count == this.Сapacity;
        }

        public void addAnimal(Animal animal)
        {
            if (!isFull())
            {
                ListAnimal.Add(animal);
            };
        }

        public void removeAnimal(Animal animal)
        {
            if (ListAnimal.Contains(animal))
            {
                ListAnimal.Remove(animal);
            }
        }
    }
}
