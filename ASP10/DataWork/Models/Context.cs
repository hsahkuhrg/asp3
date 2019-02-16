using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataWork.Models
{
    public class Context : DbContext
    {
        public DbSet<Respons> Respons { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Teg> Tegs { get; set; }
    }
}
