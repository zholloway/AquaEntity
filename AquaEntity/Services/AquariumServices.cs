using AquaEntity.DataContext;
using AquaEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaEntity.Services
{
    public class AquariumServices
    {
        public AquaContext Database { get; set; }
        public AquariumServices (AquaContext database)
        {
            Database = database;
        }

        public List<Aquarium> GetAllAquariums()
        {
            List<Aquarium> list = Database.Aquariums.ToList();
            return list;
        }

        public Aquarium GetSingleAquarium(int id)
        {
            var aq = Database.Aquariums.First(f => f.ID == id);
            return aq;
        }

        public void CreateAquarium(Aquarium aq)
        {
            Database.Aquariums.Add(aq);
            Database.SaveChanges();
        }

        public void DeleteAquarium(int id)
        {
            Database.Aquariums.Remove(GetSingleAquarium(id));
            Database.SaveChanges();
        }

        public void UpdateAquarium(Aquarium aq)
        {
            Aquarium aquarium = Database.Aquariums.First(f => f.ID == aq.ID);
            aquarium.Name = aq.Name;
            aquarium.City = aq.City;
            Database.SaveChanges();
        }
    }
}