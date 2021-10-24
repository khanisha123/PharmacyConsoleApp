using Entity.Interface;


namespace Entity.Models
{
    public class Medicine:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
