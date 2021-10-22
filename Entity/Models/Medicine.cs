using Entity.Interface;


namespace Entity.Models
{
    public class Medicine:IEntity
    {
        public int Id { get; set; }
        public int MaximumSizeDrugHolding  { get; set; }
        public int NumberOfWorkers { get; set; }
        public string Type { get; set; }
    }
}
