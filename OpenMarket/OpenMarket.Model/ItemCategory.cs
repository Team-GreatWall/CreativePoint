namespace OpenMarket.Model
{
    using System.Collections.Generic;

    public class ItemCategory
    {
        public ItemCategory()
        {
            this.Items = new HashSet<Item>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public virtual ICollection<Item> Items { get; set; } 
    }
}
