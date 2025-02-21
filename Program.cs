using demo.contexts;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

            #region read-retrive-select
            //read -retrive-select



            //var res = context.Employees.Where(e => e.Id == 90).FirstOrDefault();

            ////    Console.WriteLine(res.Name);
            ////    Console.WriteLine(res.Id);

            //Console.WriteLine(context.Entry(res).State);//unchanged
            //res.Name = "Ali";
            //Console.WriteLine(context.Entry(res).State);//modified
            //*****************************************************
            //var res01 = context.Employees.ToList();
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //var res01 = context.Employees.Select(e => e.Name);
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //} 


            #endregion

            #region update
            //update


            //var res = context.Employees.FirstOrDefault(e => e.Id == 80);
            //Console.WriteLine(context.Entry(res).State);//unchanged

            //res.Name = "rahma ahmed";


            //context.Update(res);
            //Console.WriteLine(context.Entry(res).State);//modified

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(res).State);//unchanged

            #endregion

            #region Delete


            //var res = context.Employees.FirstOrDefault(e => e.Id == 70);
            //Console.WriteLine(context.Entry(res).State);//unchanged
            //context.Employees.Remove(res);
            //Console.WriteLine(context.Entry(res).State);//deleted

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(res).State);//deatched
            #endregion

        }
    }
}
