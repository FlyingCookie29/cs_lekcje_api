namespace WFD.Model.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string MeasurementUnit { get; set; }
        //public List<string> Tags { get; set; }
        public string ExtraNotes { get; set; }
    }
}