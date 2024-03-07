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
    class Presenter
    {
        IView view;
        IModel model;

        public Presenter(IView view)
        {
            this.view = view;
            model = new Repository();
        }
        public List<IAnimals> ResultGetAnimals()
        {
            view.animals = model.GetAnimals();
            return model.GetAnimals();
        }
    }
}
