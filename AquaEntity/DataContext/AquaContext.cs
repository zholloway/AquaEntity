using AquaEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AquaEntity.DataContext
{
    public class AquaContext :DbContext
    {
        public AquaContext():base() { }

        public DbSet<Aquarium> Aquariums { get; set; }
        public DbSet<AquaticLife> AquaticLife { get; set; }
        public DbSet<Ocean> Oceans { get; set; }
    }
}