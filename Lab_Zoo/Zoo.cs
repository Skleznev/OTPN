using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Zoo
{
    class Zoo
    {
        List<Cell> cells = new List<Cell>();
        List<Animal> animals = new List<Animal>();

        public void createCell(Cell.Size size, int id, string name, int capacity)
        {
            switch (size)
            {
                case Cell.Size.Big:
                    Big_Cell big_Cell = new Big_Cell(id, name,capacity);
                    cells.Add(big_Cell);
                    break;
                case Cell.Size.Medium:
                    Medium_Cell medium_Cell = new Medium_Cell(id, name, capacity);
                    cells.Add(medium_Cell);
                    break;
                case Cell.Size.Small:
                    Small_Cell small_Cell = new Small_Cell(id, name, capacity);
                    cells.Add(small_Cell);
                    break;
                default:
                    break;
            }
        }
        public void createPredator(Animal animal)
        {

        }
        public void addAnimalInCell(int id, Animal animal)
        {
            cells.ElementAt(id).addAnimal(animal);
            animal.addInCase();
        }
        public void removeAnimalFromCell(int id, Animal animal)
        {
            cells.ElementAt(id).removeAnimal(animal);
            animal.removeFromCase();
        }

        public void getAnimalWithoutCase() {
            foreach(Animal animal in animals){
                if (animal.getInCase()) Console.WriteLine(animal.ToString());
            }
        }
    }
}
