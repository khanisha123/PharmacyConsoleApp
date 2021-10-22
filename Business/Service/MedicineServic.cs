using Business.Interface;
using DataAccess.Repository;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Service
{
    public class MedicineServic : IMedicine
    {
        private static int count { get; set; }
        public MedicineRepository medicinerepository { get; set; }
        public MedicineServic()
        {
            medicinerepository = new MedicineRepository();
        }
        public Medicine Creat(Medicine medicine)
        {
            try
            {
                medicine.Id = count;
                Medicine isExit = medicinerepository.Get(g => g.type.ToLower() == medicine.type.ToLower());
                if (isExit != null)
                    return null;
                medicinerepository.Creat(medicine);
                count++;
                return medicine;
            }
            catch (Exception)
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

        public Medicine Get(string type)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll()
        {
            return medicinerepository.GetAll();
        }

        public List<Medicine> GetAll(int EndDateForUsing)
        {
            throw new NotImplementedException();
        }

        public Medicine Update(int Id, Medicine medicine)
        {
            throw new NotImplementedException();
        }
    }
}
