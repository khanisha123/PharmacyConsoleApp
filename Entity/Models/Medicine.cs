using Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Medicine:IEntity
    {
        public int Id { get; set; }
        public string type { get; set; }
        public int EndDateForUsing{ get; set; }
        
    }
}
