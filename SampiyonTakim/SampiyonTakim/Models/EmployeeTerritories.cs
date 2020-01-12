using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampiyonTakim.Models
{
    public class EmployeeTerritories
    {
        public int EmployeeId { get; set; }
        [Required, MaxLength(20)]
        public string TerritoryId { get; set; }
    }

}
