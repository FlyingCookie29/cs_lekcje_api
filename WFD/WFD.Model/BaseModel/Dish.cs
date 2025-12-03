namespace WFD.Model.Model
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Expected Preparation Time in minutes
        /// </summary>
        public int ExpectedPreparationTime { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        //public List<string> Tags { get; set; }
        public string ExtraNotes { get; set; }
        public string Description { get; set; }
    }
}