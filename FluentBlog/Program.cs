using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            // Lazy Loading (virtual)
            // Models/Post.cs
            // public virtual List<Tag> Tags { get; set; }
            var posts1 = context.Posts;
            foreach (var post in posts1) // SELECT * FROM posts
            {
                foreach (var tag in post.Tags) // SELECT * FROM tags
                {

                }
            }

            // Eager Loading (include)
            // Models/Post.cs
            // public virtual List<Tag> Tags { get; set; }
            var posts2 = context.Posts.Include(x => x.Tags)
                .Select(x => new { Id = x.Id }); // seleciona somente as propriedade desejadas dentro de um novo objeto
            foreach (var post in posts2) // SELECT * FROM posts INNER JOIN tags
            {
                foreach (var tag in post.Tags)
                {

                }
            }

            Console.WriteLine("Teste");
        }
    }
}
