﻿using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "André Baltieri",
            //     Slug = "andrebaltieri",
            //     Email = "andre@balta.io",
            //     Bio = "9x Microsoft MVP",
            //     Image = "https://balta.io",
            //     PasswordHash = "123098457"
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo valor aprender EF Core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .ToList();

            // foreach (var post in posts)
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}"); // sempre utilizar nullsafe em subconjuntos

            var post = context
                .Posts
                // .AsNoTracking()
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x => x.LastUpdateDate)
                .FirstOrDefault(); // pegando o primeiro item

            post.Author.Name = "Teste";
            
            context.Posts.Update(post);
            context.SaveChanges();

        }
    }
}
