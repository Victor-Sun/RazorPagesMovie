using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
	public class Movie
	{
		public int ID { get; set; }

		[StringLength(60, MinimumLength = 3)]
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Release Date")]
		public DateTime ReleaseDate { get; set; }
		
		[Range(1,100)]
		[DataType(DataType.Currency)]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

		[Required]
		[StringLength(30)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
		public string Genre { get; set; }

		[Required]
		[StringLength(5)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
		public string Rating { get; set; }
	}
}