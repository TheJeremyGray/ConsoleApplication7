using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication7.Models;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new yunoworkContext())
            {
                var a = new Action1() {Desc = Guid.NewGuid().ToString()};
                a.Audit("Console!");
                // This audit should insert an audit with EntityId = 3 and AffectedId = {primary key of the assiciated Action1}
                //a.Audits.Add(new Audit()
                //    {
                //        NewValue = "Console!"
                //    });                

                context.Action1.Add(a);              

                context.SaveChanges();
            }
        }
    }
}
