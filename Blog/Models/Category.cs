using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")] // se não for informado, será utilizado o nome da propriedade existente no DbSet
    public class Category
    {
        [Key] // explicitar o entendimento do EF
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // identidade, o banco de dados gerará um valor quando o registro for inserido
        public int Id { get; set; } // o EF entende que "Id" é uma chave primária
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}