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
        List<IAnimals> GetAnimals();
    }
}
