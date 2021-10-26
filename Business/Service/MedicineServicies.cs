using Business.Interface;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

using DataAccess.Repository;
using Untilies.Exceptions;

namespace Business.Service
{
    public class MedicineServicies : IMedicine
    {
        public MedicineRepository medicineRepository { get;}
        public PharmacyServic pharmacyService { get;}
        private static int count;
        public MedicineServicies()
        {
            medicineRepository = new MedicineRepository();
            pharmacyService = new PharmacyServic();
        }
        public Medicine Creat(Medicine medicine, string pharmacyName)
        {
            Pharmacy dbPharmacy = pharmacyService.Get(pharmacyName);
            try
            {
                
                if (dbPharmacy != null)
                {
                    medicine.Pharmacy = dbPharmacy;
                    medicine.Id = count;
                    medicineRepository.Creat(medicine);
                    count++;
                    return medicine;
                }
                else
                {
                    throw new MedicineException("There isn't such thing as a type");
                }
            }
            catch (MedicineException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex);
                return default;
            }
        }

        public Medicine Delete(int Id)
        {
            Medicine dbMedicine = medicineRepository.Get(m => m.Id == Id);
            try
            {
                if (dbMedicine != null)
                {
                    medicineRepository.Delete(dbMedicine);
                    return dbMedicine;
                }
                else
                {
                    throw new MedicineException("There isn't such thing as a type");
                }
            }
            catch (MedicineException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex.Message);
                return default; 
            }
        }

        public Medicine Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Get(string type)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll(string pharmacyName)
        {
            Pharmacy dbpharmacy = pharmacyService.Get(pharmacyName);
            try
            {
                if (dbpharmacy != null)
                {
                    return medicineRepository.GetAll(m => m.Pharmacy.Name == dbpharmacy.Name);
                }
                else
                {
                    throw new MedicineException("There isn't such thing as a type");
                }
            }
            catch (MedicineException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex);
                return default;
            }

        }

        public List<Medicine> Getall()
        {
            throw new NotImplementedException();
        }

        public Medicine Updte(int Id, string pharmacyName)
        {
            throw new NotImplementedException();
        }

        public Medicine Update(Medicine medicine, string pharmacyName)
        {
            Medicine dbMedicine = medicineRepository.Get(m => m.Id == medicine.Id);
            try
            {
                if (dbMedicine!=null)
                {
                    medicineRepository.Update(medicine);
                    return medicine;
                }
                else
                {
                    throw new MedicineException("There isn't such thing as a type");
                }
            }
            catch (MedicineException ex)
            {

                Console.WriteLine("There isn't such thing as a type", ex);
                return default; 
            }
        }
    }
}
