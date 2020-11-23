using ED.STEM.Domain.Concrete;
using ED.STEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED.STEM.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    var programs = new STEMProgram()
                    {
                        Name = $"Art_{i}",
                        Price = 212.34m,
                        Description = "This is a science program",
                        Category = "Art"
                    };
                    ctx.STEMPrograms.Add(programs);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
