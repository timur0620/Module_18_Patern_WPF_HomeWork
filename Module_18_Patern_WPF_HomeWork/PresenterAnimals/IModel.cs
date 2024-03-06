using Module_18_Pattern_Console_HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_WPF_HomeWork.PresenterAnimals
{
    public interface IModel
    {
        void GetDataAnimals(string id, string count, string name, string description, string type);
        List<IAnimals> GetAllAnimals();
        List<IAnimals> Update();
        List<IAnimals> Create();
        List<IAnimals> Delete();
        List<IAnimals> GetAllMammals();
        List<IAnimals> GetAllBirds();
        List<IAnimals> GetAllAmphibians();


    }
}
