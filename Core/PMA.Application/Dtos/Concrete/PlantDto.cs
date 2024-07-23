using PMA.Application.Dtos.Abstract;
using PMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Application.Dtos.Concrete
{
    public class PlantDto:BaseDto
    {
        public int CategoryId { get; set; }
        public string PlantName { get; set; }
        public string? ImageName { get; set; }
        public int WaterFrequency { get; set; }
        public string LightRequirement { get; set; }
        public string CareInstructions { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
