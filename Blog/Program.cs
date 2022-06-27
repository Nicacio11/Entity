using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new BlogDataContext();
            // var tag = context.Tags.FirstOrDefault( x => x.Id == 2);
            // // tag.Name = ".NET updated";
            // // tag.Slug = "dotnet";
            // // context.SaveChanges();
            // context.Remove(tag);
            // context.SaveChanges();

            // var user = new User()
            // {
            //     Name = "Vítor Nicácio dos Santos",
            //     Slug = "vitornicacio",
            //     Email = "vitornicacio@hotmail.com",
            //     Bio = "Dev",
            //     Image = "https://www.google.com/logos/google.jpg",
            //     PasswordHash = "password"
            // };

            // var category = new Category()
            // {
            //     Name = "BackEnd",
            //     Slug= "backend"
            // };

            // var post = new Post
            // { 
            //     Author = user, 
            //     Category = category,
            //     Body = "<p> Hello World</p>",
            //     Slug = "estudando-ef-core",
            //     Summary = "Começando com EF Core",
            //     Title = "Estudando EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // var posts = context.Posts
            // .Include(x => x.Author)
            // .Include(x => x.Category)
            // .OrderBy(x => x.LastUpdateDate)
            // .ToList();

            // var posts = context.Posts.AsNoTracking()
            // .Include(x => x.Author)
            // .Include(x => x.Category)
            // .OrderBy(x => x.LastUpdateDate)
            // .ToList();

            var posts = GetPosts(context);

            foreach(var post in posts)
                Console.WriteLine($"{post.Title} escrito por {post.Author.Name}");
        }


        public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 1000)
        {
            var posts = context.Posts
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToList();

            return posts;
        }
    }
}
