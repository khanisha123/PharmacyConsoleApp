using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IMedicine
    {
        Medicine Creat(Medicine entity, string pharmacyName);
        Medicine Delete(int Id);
        Medicine Updte(int Id,string pharmacyName);
        Medicine Get(int Id);
        List<Medicine>Get(string name);
        List<Medicine>Getall(string pharmacyName);
        List<Medicine>Getall();
        
    }
}
