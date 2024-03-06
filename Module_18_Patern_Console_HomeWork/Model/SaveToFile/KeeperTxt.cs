using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model.SaveToFile
{
    class KeeperTxt : IAnimalSave
    {
        private string nameOfFile;
        public KeeperTxt(string nameOfFile)
        {
            this.nameOfFile = nameOfFile;
        }
        private string CreateTxt(string Pages)
        {
            return Pages;
        }
        public void SaveAnimalPages(string Pages)
        {
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.txt"))
            {
                sw.WriteLine(CreateTxt(Pages));
            }
        }
        public void SaveAllAnimals(List<IAnimals> animals)
        {
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.txt"))
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    sw.WriteLine($"{animals[i].id}|{animals[i].Count}{animals[i].Name}|{animals[i].Type}|{animals[i].Description}|");
                }
            }
        }

    }
}
