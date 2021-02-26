using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class MyTable
    {
        public int id { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string name { get; set; }
    }
}
