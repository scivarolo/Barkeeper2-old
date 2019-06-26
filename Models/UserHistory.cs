using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barkeeper2.Models {
    class UserHistory {
        public int Id { get; set; }
        public int CocktailId { get; set; }
        public Cocktail Cocktail { get; set; }
        public int UserId { get; set; }

        [ForeignKey ("UserId")]
        public ApplicationUser User { get; set; }
        public DateTime Timestamp { get; set; }
    }
}