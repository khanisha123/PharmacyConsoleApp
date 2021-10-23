using Business.Interface;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

using DataAccess.Repository;

namespace Business.Service
{
    public class MedicineServicies : IMedicine
    {
        public MedicineRepository medicineRepository { get;}
        public PharmacyServic pharmacyService { get;}
        public static int count;
        public MedicineServicies()
        {
            medicineRepository = new MedicineRepository();
            pharmacyService = new PharmacyServic();
        }
        public Medicine Creat(Medicine medicine, string pharmacyName)
        {
            Pharmacy dbPharmacy = pharmacyService.Get(pharmacyName);
            if (dbPharmacy !=null)
            {
                medicine.Pharmacy = dbPharmacy;
                medicine.Id = count;
                medicineRepository.Creat(medicine);
                count++;
                return medicine;
            }
            else
            {
                return null;
            }
        }

        public Medicine Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Getall(string pharmacyName)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Getall()
        {
            throw new NotImplementedException();
        }

        public Medicine Updte(int Id, string pharmacyName)
        {
            throw new NotImplementedException();
        }
    }
}
