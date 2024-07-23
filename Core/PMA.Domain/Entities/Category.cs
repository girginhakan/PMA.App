using PMA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        ICollection<Plant>? Plants { get; set; }
    }
}
