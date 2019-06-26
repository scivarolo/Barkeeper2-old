using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barkeeper2.Models {
    class UserProduct {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double AmountAvailable { get; set; }
        public int UserId { get; set; }

        [ForeignKey ("UserId")]
        public ApplicationUser User { get; set; }
    }
}