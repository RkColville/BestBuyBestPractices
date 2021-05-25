using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BestBuyBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            //var repo = new Department_Repo(conn);

            

            var repo = new DapperProductRepository(conn);
            var products = repo.GetAllProducts();
            
            //var departments = repo.GetAllDepartments();
            //foreach (var d in departments)
            //{
            //    Console.WriteLine(d.DepartmentID);
            //    Console.WriteLine(d.Name);

            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //var department = repo.GetDepartment(3);
            //Console.WriteLine(department.Name);

            //repo.InsertDepartment("Dapper Demo Test Name");

            //repo.UpdateDepartment(5, "BlahBlahBlah");

            //repo.DeleteDepartment(5);

            //productrepo.CreateProduct("My Cool TV", 20, 1);
                                    
            //var products = productrepo.GetAllProduct();


            //foreach (var prod in products)
            //{
            //    Console.WriteLine($"{prod.ProductID} {prod.Name}");
            //    Console.ReadLine();
            //}
            
            
        }
    }
}
