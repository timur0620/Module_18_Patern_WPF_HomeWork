using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model
{
     public interface IAnimals
    {  
        int id { get; set; }
        string Type { get; set; }
        int Count { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        
    }
}
