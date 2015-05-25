namespace OpenMarket.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class FavoritShop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int ShopId { get; set; }

        [ForeignKey("ShopId")]
        public virtual Shop Shop { get; set; }
    }
}
