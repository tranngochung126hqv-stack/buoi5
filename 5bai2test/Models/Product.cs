using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Models
{
	[Table("Product")]
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public decimal Price { get; set; }
	}
}