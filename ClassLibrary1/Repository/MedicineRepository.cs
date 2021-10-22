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
            try
            {
                DBContent.Medicines.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Medicine Get(Predicate<Medicine> filter = null)
        {
            try
            {

                return filter == null ? DBContent.Medicines[0]
                    : DBContent.Medicines.Find(filter);

                //if (filters==null)
                //{
                //    return DBContent.Medicines[0];
                //}
                //else
                //{
                //    return DBContent.Medicines.Find(filters);     
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medicine> GetAll(Predicate<Medicine> filter = null)
        {
            try
            {
                return filter == null ? DBContent.Medicines
                    : DBContent.Medicines.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Medicine entity)
        {
            try
            {
                Medicine dbMedicinies = Get(s=>s.Id == entity.Id);
                dbMedicinies = entity;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
