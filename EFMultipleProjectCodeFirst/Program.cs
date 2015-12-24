using Data1;
using Data2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMultipleProjectCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data1
            using (var db = new Data1Context())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Data1: ");
                var name = Console.ReadLine();

                var data1 = new Data1Table1 {Id = 1, Name = name };
                db.Datas1.Add(data1);
                db.SaveChanges();

                // Display all data1 from the database 
                var query = from b in db.Datas1
                            orderby b.Name
                            select b;

                Console.WriteLine("All Data1 in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            //Data1
            using (var db = new Data2Context())
            {
                // Create and save a new Blog 
                Console.Write("Enter a remark for a new Data2: ");
                var remark = Console.ReadLine();

                var data2 = new Data2Table2 { Id2 = 1, Remarks = remark };
                db.Datas2.Add(data2);
                db.SaveChanges();

                // Display all data1 from the database 
                var query = from b in db.Datas2
                            orderby b.Remarks
                            select b;

                Console.WriteLine("All Data2 in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Remarks);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
