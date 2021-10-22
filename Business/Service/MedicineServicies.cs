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
        private static int count { get; set; }
        public MedicineRepository medicineRepository { get; set; }

        public MedicineServicies()
        {

            medicineRepository = new MedicineRepository();

        }
        public Medicine Creat(Medicine medicine)
        {
            try
            {
                medicine.Id = count;
                Medicine isExit = medicineRepository.Get(g => g.Type.ToLower() == medicine.Type.ToLower());
                if (isExit != null)
                    return null;
                medicineRepository.Creat(medicine);
                count++;
                return medicine;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Medicine Update(int Id, Medicine medicine)
        {
            throw new NotImplementedException();
        }

        public Medicine Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(string type)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll(long MaximumSizeDrugHolding)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll(int NumberOfWorkers)
        {
            throw new NotImplementedException();
        }
    }
}
