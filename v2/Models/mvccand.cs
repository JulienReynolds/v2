using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace v2.Models
{
    public class mvccand : DbContext
    {
        public mvccand(DbContextOptions<mvccand> options)
            : base(options)
        {

        }
        public DbSet<candidat> Candidats { get; set; }
        public DbSet<offre> Offres { get; set; }




    }
}
