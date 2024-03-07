using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model.SaveToFile
{
    class KeeperDocX : IAnimalSave
    {
        private string nameOfFile;
        public KeeperDocX (string nameOfFile)
        {
            this.nameOfFile = nameOfFile;
        }
        private string CreateDocX(string Pages)
        {
            return Pages;
        }
        public void SaveAnimalPages(string Pages)
        {
            using(StreamWriter sw = new StreamWriter($"{nameOfFile}.docx")) 
            {
                sw.WriteLine(CreateDocX(Pages));
            }
        }
        public void SaveAllAnimals(List<IAnimals> animals)
        {
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.docx"))
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    sw.WriteLine($"{animals[i].id}|{animals[i].Count}{animals[i].Name}|{animals[i].Type}|{animals[i].Description}|");
                }
            }
        }
    }
}
