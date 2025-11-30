using WFD.Model.Model;

namespace WFD.Repository
{
    public static class WFDContext
    {
        public static List<Dish> Dishes { get; set; } = new List<Dish>();
        public static List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    }
}