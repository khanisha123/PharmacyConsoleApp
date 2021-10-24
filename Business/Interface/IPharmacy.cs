using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IPharmacy
    {
        Pharmacy Creat(Pharmacy pharmacy);
        Pharmacy Update(int Id, Pharmacy pharmacy);
        Pharmacy Delete(int Id);
        Pharmacy Get(int Id);
        Pharmacy Get(string name);
        List<Pharmacy> GetAll();
        List<Pharmacy> GetAll(int MaxWareHouseSize);
        List<Pharmacy> GetAllWithPharmacyType(string GetPharmacyWithtype);
        
    }
}
