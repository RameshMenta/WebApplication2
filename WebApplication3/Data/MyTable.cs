using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data
{
    public class MyTable
    {
        public int id { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string name { get; set; }
    }
}
