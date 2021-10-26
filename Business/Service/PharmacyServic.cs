using Business.Interface;
using DataAccess.Repository;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Untilies.Exceptions;

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
            catch (PharmacyException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex);
                return default;
            }
        }

        public Pharmacy Update(int Id,Pharmacy pharmacy)
        {
            try
            {
                Pharmacy dbPharmacy = pharmacyrepository.Get(s => s.Id == pharmacy.Id);
                if (dbPharmacy!=null)
                {
                    pharmacyrepository.Update(dbPharmacy,pharmacy);
                    return dbPharmacy;
                }
                else
                {
                    throw new MedicineException("There isn't such thing as a type");
                }
            }
            catch (PharmacyException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex.Message);
                return default; ;
            }
        }

        public Pharmacy Delete(int Id)
        {
            Pharmacy dbPharmacy = pharmacyrepository.Get(g=>g.Id==Id);
            try
            {
                if (dbPharmacy != null)
                {
                    pharmacyrepository.Delete(dbPharmacy);
                    return dbPharmacy;
                }
                else
                {
                    throw new MedicineException("There isn't such thing as a type");
                }
            }
            catch (PharmacyException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex.Message);
                return default; ;
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
            return pharmacyrepository.GetAll(); 
        }

        public List<Pharmacy> GetAll(int MaxPharmacyWareHouseSize)
        {
            return pharmacyrepository.GetAll(g => g.MaxPharmacyWareHouseSize == MaxPharmacyWareHouseSize);
        }
        public List<Pharmacy> GetAllWithPharmacyType(string PharmacyType)
        {
            return pharmacyrepository.GetAll(g => g.Type == PharmacyType);
        }
        

        
    }
}
