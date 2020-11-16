using ED.STEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED.STEM.Domain.Concrete
{
   public class EFDbContext : DbContext
    {
        public DbSet<STEMProgram> STEMPrograms { get; set; }
    }
}
