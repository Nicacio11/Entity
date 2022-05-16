using System;
using System.Linq;
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
            var tag = context.Tags.FirstOrDefault( x => x.Id == 2);
            // tag.Name = ".NET updated";
            // tag.Slug = "dotnet";
            // context.SaveChanges();
            context.Remove(tag);
            context.SaveChanges();

        }
    }
}
