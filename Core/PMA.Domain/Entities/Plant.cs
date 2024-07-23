using PMA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Domain.Entities
{
    public class Plant:BaseEntity
    {
        public int CategoryId { get; set; }
        public string PlantName { get; set; }
        public string? ImageName { get; set; }
        public int WaterFrequency { get; set; }
        public string LightRequirement { get; set; }
        public string CareInstructions { get; set; }
        public Category Category { get; set; }
    }
}
