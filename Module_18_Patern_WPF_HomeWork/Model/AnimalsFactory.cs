using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model
{
    internal class AnimalsFactory
    {
        public static IAnimals GetAnimal(string Type, int id,  int Count, string Name, string Description)
        {
            switch (Type)
            {
                case "Birds": return new Birds(Type, id, Count, Name, Description);
                case "Mammals": return new Mammals(Type, id, Count, Name, Description);
                case "Amphibians": return new Amphibians(Type, id, Count, Name, Description);

                default: return new NullAnimals();
            }
        }
    }
}
