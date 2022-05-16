using System;
using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new BlogDataContext();
            var tag = new Tag() { Name = "ASP.NET", Slug = "ASP.NET" };
            context.Add(tag);  
            context.SaveChanges();

        }
    }
}
