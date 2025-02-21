using demo.contexts;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud operations:
            //update,delete,insert(insert)

            using CompanyDbContext context = new CompanyDbContext();

            #region create -insert
            //create -insert

            //var emps = new Employee()
            //{
            //    Name = "ahmed",
            //    salary = 1200,
            //    Address = "egypt",
            //    Age = 20
            //};

            //  emps.Name = "khaled";
            //  Console.WriteLine(context.Entry(emps).State);//deatached

            //  context.Employees.Add(emps);
            //  Console.WriteLine(context.Entry(emps).State);//added

            //var res=  context.SaveChanges();
            //  Console.WriteLine(context.Entry(emps).State);//unchanged

            //  emps.Name = "omar";
            //  Console.WriteLine(context.Entry(emps).State);//modified
            //  Console.WriteLine(res);


            //context.Employees.Add(emps);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(emps).State);//deatached
            //context.Entry(emps).State = EntityState.Added;
            //Console.WriteLine(context.Entry(emps).State);//added
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(emps).State);//unchanged


            #endregion
        }
    }
}
