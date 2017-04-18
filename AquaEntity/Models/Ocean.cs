using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaEntity.Models
{
    public class Ocean
    {
        public int ID { get; set; }
        public int AverageTemperature { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AquaticLife> AquaticLife { get; set; }
    }
}