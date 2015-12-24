using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data2
{
    public class Data2Table2
    {
        [Key]
        public int Id2 { get; set; }

        public string Remarks { get; set; }

        public string Description { get; set; }
        public int Eentelling { get; set; }

    }
}
