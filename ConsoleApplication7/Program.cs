using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
                
                 //This audit should insert an audit with EntityId = 3 and AffectedId = {primary key of the assiciated Action1}
                a.Audit("Console!");              
                //a.Audits.Add(new Audit()
                //    {                     
                //        NewValue = "Console!"
                //    });                

                context.Action1.Add(a);

                
                //var b = new Action2() { Desc = Guid.NewGuid().ToString() };
                
                // This audit should insert an audit with EntityId = 5 and AffectedId = {primary key of assiciated Action2}
                //b.Audits.Add(new Audit()
                //{
                //    NewValue = "Console!"
                //});

                //context.Action1.Add(b);  

                try
                {
                     context.SaveChanges();
                }                                 
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                
            }
        }
    }
}
