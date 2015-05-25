namespace OpenMarket.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Shop
    {
        public Shop()
        {
            this.Items = new HashSet<Item>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Visits { get; set; }

        public string PictureUrl { get; set; }
        
        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
