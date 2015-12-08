using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom1.Models
{
    public class Info
    {
        [System.ComponentModel.DataAnnotations.DisplayAttribute()]
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
