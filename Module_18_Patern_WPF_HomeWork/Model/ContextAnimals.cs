using Module_18_Pattern_Console_HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Patern_WPF_HomeWork.Model
{
    class ContextAnimals : DbContext
    {
        public ContextAnimals(): base("DbConnection") { }
        public DbSet<Birds> Birds { get; set; }
    }
}
    