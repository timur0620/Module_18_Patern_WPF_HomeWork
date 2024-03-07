using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_18_Pattern_Console_HomeWork;
using Module_18_Pattern_Console_HomeWork.Model;
namespace Module_18_Patern_WPF_HomeWork.PresenterAnimals
{
     interface IView
    {
        //string  id {  get; set; }
        //string Type { get; set; }
        //string Count { get; set; }
        //string Name { get; set; }
        //string Description { get; set; }    
        List<IAnimals> animals { get; set; }    

        
    }
}
