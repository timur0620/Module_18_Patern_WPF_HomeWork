using Module_18_Pattern_Console_HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Patern_WPF_HomeWork.Model.SaveToFile.Context
{
    class ContextAmphibians :DbContext
    {
        public ContextAmphibians() : base("DbConnectionAmphibians") { }
        public DbSet<Amphibians> Amphibians { get; set; }
    }
}
