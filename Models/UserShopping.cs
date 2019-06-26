using System.ComponentModel.DataAnnotations.Schema;

namespace Barkeeper2.Models {
    class UserShopping {
        public int Id { get; set; }
        public int? IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }

        [ForeignKey ("UserId")]
        public ApplicationUser User { get; set; }
    }
}