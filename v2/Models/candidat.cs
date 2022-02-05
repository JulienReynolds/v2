using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace v2.Models
{
    public class candidat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<offre> Offres { get; }
    }
}
