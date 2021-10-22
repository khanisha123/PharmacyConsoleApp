using Entity.Interface;


namespace Entity.Models
{
    public class Pharmacy:IEntity
    {
        public int Id { get; set; }
        public int MaximumSizeDrugHolding  { get; set; }
        public int NumberOfWorkers { get; set; }
        public string Name { get; set; }
    }
}
