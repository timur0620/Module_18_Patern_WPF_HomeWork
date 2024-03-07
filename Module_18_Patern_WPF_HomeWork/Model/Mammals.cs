using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Module_18_Pattern_Console_HomeWork.Model
{
    public class Mammals : IAnimals
    {   
        public int id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Mammals() { }
        public Mammals( string Type, int id, int Count, string Name, string Description)
        {   
            this.id = id;
            this.Count = Count;
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
        }
        public override string ToString()
        {
            return $"{id} {Count} {Name} {Description} {Type}";
        }
    }
}
