using System.Linq;
using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // não possui acompanhamento (tracking)
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" }; 
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // rehidratação: ler o item do banco novamente
                // propriedades + metadados
                var tag = context.Tags.FirstOrDefault(t => t.Id == 1);
                tag.Name = ".NET";
                tag.Slug = "dotnet";
                context.Update(tag);
                context.SaveChanges();
            }
        }
    }
}
