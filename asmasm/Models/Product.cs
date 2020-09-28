using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace asmasm.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[DisplayName("Product Name")]
		public string Name { get; set; }

		[Required]
		[DisplayName("Product Price")]
		public double Price { get; set; }
		[Required]
		public int CategoryId { get; set; }
		public ApplicationUser Author { get; set; }
	}
}