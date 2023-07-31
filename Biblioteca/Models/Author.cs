
namespace Biblioteca.Models
{
	[Table("Authors")]
	public class Author
	{
		public int Id { get; set; }
		[Required]
		[StringLength(using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
50)]
		[Column("AuthorName")]
		public string? Name { get; set; }
	}
}
