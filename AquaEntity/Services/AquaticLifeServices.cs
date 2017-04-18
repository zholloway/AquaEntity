using AquaEntity.DataContext;
using AquaEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaEntity.Services
{
    public class AquaticLifeServices
    {
        public AquaContext Database { get; set; }
        public AquaticLifeServices(AquaContext database)
        {
            Database = database;
        }

        public IQueryable<string> GetFishFromAquarium(int aquariumID)
        {
            var list = Database.AquaticLife
                .Where(w => w.AquariumID == aquariumID)
                .Select(s => s.Name);

            return list;
        }
    }
}