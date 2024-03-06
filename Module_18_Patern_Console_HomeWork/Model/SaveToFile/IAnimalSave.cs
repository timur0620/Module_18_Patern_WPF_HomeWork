using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model.SaveToFile
{
    interface IAnimalSave
    {
        void SaveAnimalPages(string Pages);
        void SaveAllAnimals(List<IAnimals> animals);
    }
}
