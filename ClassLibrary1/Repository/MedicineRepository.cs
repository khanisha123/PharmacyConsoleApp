using ClassLibrary1;
using DataAccess.Interfaces;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class MedicineRepository : IRepository<Medicine>
    {
        public bool Creat(Medicine entity)
        {
            try
            {
                DBContent.Medicines.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Medicine entity)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(Predicate<Medicine> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll(Predicate<Medicine> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Medicine entity)
        {
            throw new NotImplementedException();
        }
    }

}   