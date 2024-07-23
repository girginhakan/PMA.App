using PMA.Application.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Application.Dtos.Concrete
{
    public class CategoryDto:BaseDto
    {
        public string CategoryName { get; set; }

        ICollection<PlantDto> PlantDtos { get; set; }

    }
}
