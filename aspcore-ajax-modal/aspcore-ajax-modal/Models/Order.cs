using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aspcore_ajax_modal.Models
{
	public class Order
	{
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
