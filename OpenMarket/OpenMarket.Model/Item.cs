namespace OpenMarket.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string Discription { get; set; }

        public string PictureUrl { get; set; }

        public int Visits { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ItemCategory Category { get; set; }
      
        public string AutorId { get; set; }

        [ForeignKey("AutorId")]
        public virtual User Autor { get; set; }

        public int? ShopId { get; set; }

        [ForeignKey("ShopId")]
        public virtual Shop Shop { get; set; }
    }
}
