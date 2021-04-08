using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Models
{
    public class CityName
    {
        [Required]
        public string Name { get; set; }
    }
}
