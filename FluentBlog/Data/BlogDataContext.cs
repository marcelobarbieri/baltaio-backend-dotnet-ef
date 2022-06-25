using System;
using Blog.Data.Mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PostWithTagsCount> PostWithTagsCount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e4r@#$");

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new CategoryMap());
            modelbuilder.ApplyConfiguration(new UserMap());
            modelbuilder.ApplyConfiguration(new PostMap());

            modelbuilder.Entity<PostWithTagsCount>(x =>
            {
                x.ToSqlQuery(@"
                    SELECT 
                        [Title] AS [Name],  
                        SELECT COUNT([Id]) FROM [Tags] WHERE [PostId] = [Id]
                            AS [Count]
                    FROM 
                        [Posts]");
            });
        }
    }
}