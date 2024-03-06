using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_18_Pattern_Console_HomeWork;
using Module_18_Pattern_Console_HomeWork.Model;
namespace Module_18_Patern_WPF_HomeWork.PresenterAnimals
{
    internal interface IView
    {
        int  id {  get; set; }
        string Type { get; set; }
        int Count { get;}
        string Name { get; set; }
        string Description { get; set; }    
        List<IAnimals> animals { get; set; }    

        
    }
}
