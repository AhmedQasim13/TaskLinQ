using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using TaskLinQ.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TaskLinQ.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            //1-Retrieve all categories from the production.categories table.

            //var categories =dbContext.Categories.ToList();
            //foreach (var category in categories)
            //{
            //    Console.WriteLine($"Category Id : {category.CategoryId}\n Category Name {category.CategoryName} ");
            //}
            //

            //2-Retrieve the first product from the production.products table.

            //var products = dbContext.Products.First();
            //Console.WriteLine($"Product Id: {products.ProductId}\n Product Name: {products.ProductName}");
            //

            //3-Retrieve a specific product from the production.products table by ID.

            //var SpecificProduct= dbContext.Products.Where(e=>e.ProductId==110);
            //foreach (var item in SpecificProduct)
            //{
            //    Console.WriteLine($"Product Id: {item.ProductId}\n Product Name: {item.ProductName}");
            //}
            //

            //4-Retrieve all products from the production.products table with a certain model year.
            //var yearofProduct= dbContext.Products.Where(e=>e.ModelYear==2017);
            //foreach (var item in yearofProduct)
            //{
            //    Console.WriteLine($"Product Id: {item.ProductId}\n\t Product Name: {item.ProductName}\n\t Product Year: {item.ModelYear}");
            //}
            //

            //5-Retrieve a specific customer from the sales.customers table by ID.
            //var customers= dbContext.Customers.Where(e=>e.CustomerId==5);
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"Customer ID : {customer.CustomerId} \t Customer name : {customer.FirstName + " " + customer.LastName}");
            //}
            //

            //6-Retrieve a list of product names and their corresponding brand names.
            //var ProductsWithBrand = dbContext.Products.Include(e => e.Brand)
            //    .Select(e => new { e.ProductName, e.Brand.BrandName });
            //foreach (var product in ProductsWithBrand)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}\n\t Brand Name:{product.BrandName}");
            //}
            //
            //7-Count the number of products in a specific category.
            //var products = dbContext.Products.Include(e => e.Category).Where(e=>e.Category.CategoryId==1);
            //Console.WriteLine($"The count of products in Category ID= 1 is : {products.Count()}");

            //8-Calculate the total list price of all products in a specific category.
            //var Products = dbContext.Products.Include(e=>e.Category).GroupBy(c => c.Category.CategoryId).Select(e => new
            //{
            //    CategoryId = e.Key,
            //    Total = e.Sum(e => e.ListPrice),
            //    MinProducts = e.Min(e => e.ListPrice),
            //    MaxProducts = e.Max(e => e.ListPrice),
            //    AvgProduct = e.Average(e => e.ListPrice),
            //    Count = e.Count()
            //});
            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"Category ID:  {item.CategoryId}\n Total List Price: {item.Total}\n MinProducts: {item.MinProducts} \n MaxProducts:{item.MaxProducts}\n AvgProduct: {item.AvgProduct}\n Count: {item.Count}");
            //}

            //9-Calculate the average list price of products.
            //var AvgProducts = dbContext.Products.Average(e => e.ListPrice);
            //Console.WriteLine($"The Avarage of Products is {AvgProducts}");
            //

            //10-Retrieve orders that are completed.
            var CompletedOrders =dbContext.Orders.Where(e => e.OrderStatus == 1);
            foreach (var item in CompletedOrders)
            {
                Console.WriteLine($"CompletedOrders:\n  ID: {item.OrderId}  Customer ID: {item.CustomerId} ");
                
            }
            Console.WriteLine($"Count of CompletedOrders :{CompletedOrders.Count()}");
            dbContext.SaveChanges();

        }
    }
}
