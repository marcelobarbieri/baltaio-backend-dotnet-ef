using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new BlogDataContext();
            var post = await context.Posts.FirstOrDefaultAsync(x => x.Id == 1);

            var posts1 = await context.Posts.ToListAsync();
            var tags = await context.Users.ToListAsync();

            var posts2 = await GetPosts(context);

            Console.WriteLine("Teste");
        }

        public static async Task<List<Post>> GetPosts(BlogDataContext context)
        {
            return await context.Posts.ToListAsync();
        }
    }
}
