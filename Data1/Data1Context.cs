using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data1
{
    public class Data1Context : DbContext
    {
        public Data1Context() : base("GedeeldeDB")
        {

        }
        public DbSet<Data1Table1> Datas1 { get; set; }
    }
}
