using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaEntity.Models
{
    public class AquaticLife
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public DateTime DateAddedToTank { get; set; }
        public bool IsInQuarantine { get; set; }

        public int? AquariumID { get; set; }
        public Aquarium Aquarium { get; set;}

        public int? OceanID { get; set; }
        public Ocean Ocean { get; set; }
    }
}