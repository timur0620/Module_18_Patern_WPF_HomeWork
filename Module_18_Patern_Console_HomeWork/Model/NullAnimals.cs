using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Pattern_Console_HomeWork.Model
{
    class NullAnimals : IAnimals
    {
        public int id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public NullAnimals()
        {
            this.id = id;
            this.Count = 0;
            this.Name = "Not Determined";
            this.Description = "Not Determined";
            this.Type = "Not Determined";
        }
        public override string ToString()
        {
            return $"{Count} {Name} {Description} {Type}";
        }
    }
}
