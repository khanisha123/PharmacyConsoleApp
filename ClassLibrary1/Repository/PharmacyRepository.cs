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
            throw new NotImplementedException();
        }

        public Pharmacy Get(Predicate<Pharmacy> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Pharmacy> GetAll(Predicate<Pharmacy> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pharmacy entity)
        {
            throw new NotImplementedException();
        }
    }

}   