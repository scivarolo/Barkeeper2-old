using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barkeeper2.Models {
    class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int Size { get; set; }
        public string Unit { get; set; }
        public int CreatedById { get; set; }

        [ForeignKey ("CreatedById")]
        public ApplicationUser CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}