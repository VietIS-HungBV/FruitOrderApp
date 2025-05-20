using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitOder.Api.Data.Entities
{
    [Table(nameof(Offer))]
    public class Offer
    {

        [Key]
        public long Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }

        [Required, MaxLength(10)]
        public string Code { get; set; }

        [Required, MaxLength(10)]
        public string BgColor { get; set; }
        public bool IsActive { get; set; }

        public Offer(int id, string title, string description, string bgColor, string code) : this()
        {
            Id = id;
            Title = title;
            Description = description;
            Code = code;
            BgColor = bgColor;
        }

        public Offer() { }

        private static readonly string[] _lightColors = new string[]
        {
            "#FF8282", "#DBFFCB", "#BEE4D0", "#E195AB", "#9694FF", "#A1D6CB", "#D76C82"
        };

        private static string RandomColor => _lightColors.OrderBy(c => Guid.NewGuid()).First();
        public static IEnumerable<Offer> GetInitialData() =>
            new List<Offer>()
            {
                new Offer(1,"Upto 30% OFF", "Enjoy upto 30% off on all fruits", "#FF8282", "FRT30"),
                new Offer(2,"Green Veg Big sale 50% OFF", "Enjoy our big offer 50% off", "#DBFFCB", "50OFF"),
                new Offer(3,"Flat 100 OFF", "Flat 100 off all exotic fruits", "#BEE4D0", "EXT100"),
                new Offer(4,"25% OFF on Seasonal Fruits", "Enjoy 25% off on seasonal fruits", "#E195AB", "FRT25"),
            };
    }
}
