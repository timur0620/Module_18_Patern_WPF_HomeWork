using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_18_Pattern_Console_HomeWork;
using Module_18_Pattern_Console_HomeWork.Model;
using Module_18_Pattern_WPF_HomeWork.PresenterAnimals;

namespace Module_18_Patern_WPF_HomeWork.PresenterAnimals
{   
    class Presenter :IModel
    {
        Repository repository;
        IAnimals animals;
        public List<IAnimals> GetAllAnimals()
        {   
           
            return   repository.GetAnimals().ToList();
        }
        public List<IAnimals> GetAllMammals()
        {
            return repository.GetAnimalsConcert("Mammals").ToList();
        }
        public List<IAnimals> GetAllBirds()
        {
            return repository.GetAnimalsConcert("Birds").ToList();
        }
        public List<IAnimals> GetAllAmphibians()
        {
            return repository.GetAnimalsConcert("Amphibians").ToList();
        }
        public void Update()
        {
            repository.Update(animals);
            
        }
        public void Create()
        {
            repository.Create(animals);
        }
        public void Delete()
        {
            repository.Delete(animals);
        }
    }
}
