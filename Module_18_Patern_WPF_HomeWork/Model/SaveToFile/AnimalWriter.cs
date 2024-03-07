using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model.SaveToFile
{
    class AnimalWriter
    {
        public IAnimalSave Mode { get; set; }
        public string Pages { get; set; }
        public List<IAnimals> animals { get; set; }
        public AnimalWriter( IAnimalSave Method) 
        {
            this.Mode = Method;
        }
        private void AnyPages()
        {
            this.Pages = "SomePages";
        }
        private void AnyListPages()
        {   
            Repository rep = new Repository();
            animals = rep.GetAnimals();
        }
        
        public void Save()
        {
            this.AnyPages();
            Mode.SaveAnimalPages(Pages);
        }
        public void SaveAll(List<IAnimals> list)
        {
            this.AnyListPages();
            Mode.SaveAllAnimals(list);
        }
    }
}
