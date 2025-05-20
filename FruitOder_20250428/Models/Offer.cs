namespace FruitOder_20250428.Models
{
    public class Offer
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public string BgColor { get; set; }
        
        //public Color BackgroundColor => Color.FromHex(BgColor);

        //public Offer(string title, string description, Color bgColor, string code)
        //{
        //    Title = title;
        //    Description = description;
        //    Code = code;
        //    BgColor = bgColor;
        //}

        //private static readonly string[] _lightColors = new string[]
        //{
        //    "#FF8282", "#DBFFCB", "#BEE4D0", "#E195AB", "#9694FF", "#A1D6CB", "#D76C82"
        //};

        //private static Color RandomColor => Color.FromHex(_lightColors.OrderBy(c => Guid.NewGuid()).First());

        //public static IEnumerable<Offer> GetOffers()
        //{
        //    yield return new Offer("Upto 30% OFF", "Enjoy upto 30% off on all fruits", RandomColor, "FRT30");
        //    yield return new Offer("Green Veg Big sale 50% OFF", "Enjoy our big offer 50% off", RandomColor, "50OFF");
        //    yield return new Offer("Flat 100 OFF", "Flat 100 off all exotic fruits", RandomColor, "EXT100");
        //    yield return new Offer("25% OFF on Seasonal Fruits", "Enjoy 25% off on seasonal fruits", RandomColor, "FRT25");
        //}
    }
}
