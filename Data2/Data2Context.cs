using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data2
{
    public class Data2Context : DbContext

    {
        public Data2Context() : base("GedeeldeDB")
        {
        }
        public DbSet<Data2Table2> Datas2 { get; set; }


    }
}
