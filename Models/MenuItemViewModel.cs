namespace PizzaRemySofia.Models
{
    public class MenuItemViewModel
    {
        public CategoryViewModel Category { get; set; }

        public string NameBg { get; set; }

        public string NameEn { get; set; }

        public int Weight { get; set; }

        public double Price { get; set; }

        public string DescriptionBg { get; set; }

        public string DescriptionEn { get; set; }
    }
}