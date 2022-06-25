using System;
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
            var user = new User
            {
                Bio = "a",
                Email = "a@a.com",
                GitHub = "andrebaltieri",
                Image = "https://",
                Name = "André Baltieri",
                PasswordHash = "123",
                Slug = "andre-baltieri"
            };

            using var context = new BlogDataContext();
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
