using System;
using System.ComponentModel.DataAnnotations;

namespace aspcore_ajax_modal.Models
{
	public class OrderDetail
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        [StringLength(200)]
        [Required]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
