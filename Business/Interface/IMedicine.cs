using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IMedicine
    {
        Medicine Creat(Medicine medicine, string pharmacyName);
        Medicine Delete(int Id);
        Medicine Updte(Medicine medicine,string pharmacyName);
        Medicine Get(int Id);
        List<Medicine>Get(string type);
        List<Medicine>Getall(string pharmacyName);
        List<Medicine>Getall();
        
    }
}
