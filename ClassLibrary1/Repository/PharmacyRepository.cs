using ClassLibrary1;
using DataAccess.Interfaces;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class PharmacyRepository : IRepository<Pharmacy>
    {
        public bool Creat(Pharmacy entity)
        {
            try
            {
                DBContext.Pharmacies.Add(entity);
                return true;
            }   
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Pharmacy entity)
        {
            try
            {
                DBContext.Pharmacies.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Pharmacy Get(Predicate<Pharmacy> filter = null)
        {
            try
            {

                return filter == null ? DBContext.Pharmacies[0]
                    : DBContext.Pharmacies.Find(filter);

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

        public List<Pharmacy> GetAll(Predicate<Pharmacy> filter = null)
        {
            try
            {
                return filter == null ? DBContext.Pharmacies
                    : DBContext.Pharmacies.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Pharmacy entity)
        {
            try
            {
                Pharmacy dbPharmacie = Get(m=>m.Id == entity.Id);
                dbPharmacie = entity;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
