using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string RequiredAttrinute Description { get; set; }
    }
}
