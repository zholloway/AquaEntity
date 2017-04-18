using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaEntity.Models
{
    public class Aquarium
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public virtual ICollection<AquaticLife> AquaticLife { get; set; }
    }
}