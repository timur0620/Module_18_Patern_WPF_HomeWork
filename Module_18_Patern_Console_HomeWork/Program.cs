using Module_18_Pattern_Console_HomeWork.Model;
using Module_18_Pattern_Console_HomeWork.Model.SaveToFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repository = Repository.GetRepository(100);
           

            repository.Add(AnimalsFactory.GetAnimal("SomeAnimal", 0, 15, "SomeName", "SomeDescription"));

            List<IAnimals> animals = repository.GetAnimals();

            repository.PrintRepository();

            var saveToCsv = new KeeperCsv("nameFileAnimalCsv");
            var saveToTxt = new KeeperTxt("nameFileAnimalTxt");
            var saveToDocx = new KeeperDocX("nameFileAnimalDox");

            AnimalWriter aw = new AnimalWriter(saveToCsv);

            aw.SaveAll(animals);
            aw.Save();

            aw.Mode = saveToTxt;
            aw.SaveAll(animals);

            //aw.Mode = saveToDocx;
            //aw.Save();
        }
    }
}
