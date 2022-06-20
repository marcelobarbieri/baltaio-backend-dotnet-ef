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
            using (var context = new BlogDataContext())
            {
                // C - CREATE
                // não possui acompanhamento (tracking)
                // var tag1 = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                // context.Tags.Add(tag1);
                // context.SaveChanges();
                // var tag2 = new Tag { Name = ".NET", Slug = "dotnet" };
                // context.Tags.Add(tag2);
                // context.SaveChanges();

                // R - READ

                // ToList()
                //var tags = context.Tags; // referência, não executa no banco 
                // foreach (var tag in tags) // executa no banco
                // {
                //     Console.WriteLine(tag.Name);
                // }
                // var tags = context
                //     .Tags
                //     .Where(t => t.Name.Contains("ASP"))
                //     .ToList(); // executa no banco e retorna uma lista, utilizar ao final do método (performance)
                // foreach (var tag in tags) // executa no banco
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // AsNoTracking()
                // var tags = context
                //     .Tags
                //     .AsNoTracking() // desabilita o acompanhamento (metadados)
                //     .ToList();
                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // First, Single
                var tag = context
                    .Tags
                    .AsNoTracking()

                    //.Single(t => t.Id == 3); 
                    // executa no banco
                    // exibe exceção se não encontrar
                    // se houver mais de um resultado exibe exceção

                    //.SingleOrDefault(t => t.Id == 3); houver mais de um resultado exibe exceção
                    // executa no banco
                    // (default) retorna nulo se não existir ao invés de exceção
                    // se houver mais de um resultado exibe exceção

                    //.First(t => t.Id == 3); 
                    // executa no banco, exibe exceção se não encontrar

                    .FirstOrDefault(t => t.Id == 3)
                    // executa no banco
                    // (default) retorna nulo se não existir ao invés de exceção
                    ;

                Console.WriteLine(tag?.Name); // nullsafe, se existir tag imprime o nome, caso contrário não imprime nada

                // U - UPDATE
                // rehidratação: ler o item do banco novamente
                // propriedades + metadados
                // var tag = context.Tags.FirstOrDefault(t => t.Id == 1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context
                //     .Tags
                //     .AsNoTracking() // não utilizar em UPDATE e DELETE, os erros geralmente ocorrem em tempo de execução com o cliente
                //     .FirstOrDefault(t => t.Id == 3);
                // tag.Name = "Ponto NET";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                // D - DELETE
                // var tag = context.Tags.FirstOrDefault(t => t.Id == 1);
                // context.Remove(tag);
                // context.SaveChanges();
            }
        }
    }
}
