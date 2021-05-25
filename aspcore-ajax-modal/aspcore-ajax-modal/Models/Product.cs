using System;
using System.ComponentModel.DataAnnotations;

namespace aspcore_ajax_modal.Models
{
	public class Product
	{
		public Guid Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; }
	}
}
