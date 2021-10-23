using Business.Interface;
using DataAccess.Repository;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Service
{
    public class PharmacyServic : IPharmacy
    {
        private static int count { get; set; }
        public PharmacyRepository pharmacyrepository { get; set; }
        public PharmacyServic()
        {
            pharmacyrepository = new PharmacyRepository();
        }
        public Pharmacy Creat(Pharmacy pharmacy)
        {
            try
            {
                pharmacy.Id = count;
                Pharmacy isExit = pharmacyrepository.Get(g => g.Name.ToLower() == pharmacy.Name.ToLower());
                if (isExit != null)
                    return null;
                pharmacyrepository.Creat(pharmacy);
                count++;
                return pharmacy;
                
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Pharmacy Update(int Id, Pharmacy pharmacy)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Delete(int Id)
        {
            Pharmacy dbPharmacy = pharmacyrepository.Get(g=>g.Id==Id);
            if (dbPharmacy!=null)
            {
                pharmacyrepository.Delete(dbPharmacy);
                return dbPharmacy;
            }
            else
            {
                return null;
            }
        }

        public Pharmacy Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Get(string Name)
        {
            return pharmacyrepository.Get(g=>g.Name.ToLower()==Name.ToLower());
        }

        public List<Pharmacy> GetAll()
        {
            throw new NotImplementedException(); 
        }

        public List<Pharmacy> GetAll(int MaxPharmacyWareHouseSize)
        {
            return pharmacyrepository.GetAll(g => g.MaxPharmacyWareHouseSize == MaxPharmacyWareHouseSize);
        }
      
        

    }
}
