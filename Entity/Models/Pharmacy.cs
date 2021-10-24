using Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Pharmacy: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxPharrmacyType { get; set; }
        public int PharmacyWareHouse{ get; set; }
        public int MaxPharmacyWareHouseSize{ get; set; }
        
    }
}
