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
                
                a.Audits.Add(new Audit()
                    {                     
                        NewValue = "Console!"
                    });                

                context.Action1.Add(a);

                var b = new Action1() { Desc = Guid.NewGuid().ToString() };

                b.Audits.Add(new Audit()
                {
                    NewValue = "Console!"
                });

                context.Action1.Add(b);  

                context.SaveChanges();
            }
        }
    }
}
