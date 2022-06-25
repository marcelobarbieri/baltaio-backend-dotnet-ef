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

            var posts = context
                .Posts
                .Include(x => x.Author)
                    .ThenInclude(x => x.Roles) // roles do autor, subselect
                .Include(x => x.Category);
            foreach (var post in posts)
            {
                foreach (var tag in post.Tags)
                {

                }
            }

            Console.WriteLine("Teste");
        }
    }
}
