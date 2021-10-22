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
                DBContent.Pharmacies.Add(entity);
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
                DBContent.Pharmacies.Remove(entity);
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

                return filter == null ? DBContent.Pharmacies[0]
                    : DBContent.Pharmacies.Find(filter);

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
                return filter == null ? DBContent.Pharmacies
                    : DBContent.Pharmacies.FindAll(filter);
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
                Pharmacy dbPharmacies = Get(s=>s.Id == entity.Id);
                dbPharmacies = entity;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
