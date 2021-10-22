using Business.Interface;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

using DataAccess.Repository;

namespace Business.Service
{
    public class PharmacyServicies : IPharmacy
    {
        private static int count { get; set; }
        public PharmacyRepository pharmacyRepository { get; set; }

        public PharmacyServicies()
        {

            pharmacyRepository = new PharmacyRepository();

        }
        public Pharmacy Creat(Pharmacy pharmacy)
        {
            try
            {
                pharmacy.Id = count;
                Pharmacy isExit = pharmacyRepository.Get(g => g.Name.ToLower() == pharmacy.Name.ToLower());
                if (isExit != null)
                    return null;
                pharmacyRepository.Creat(pharmacy);
                count++;
                return pharmacy;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Pharmacy Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Get(string type)
        {
            throw new NotImplementedException();
        }

        public List<Pharmacy> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Pharmacy> GetAll(long MaximumSizeDrugHolding)
        {
            throw new NotImplementedException();
        }

        public List<Pharmacy> GetAll(int NumberOfWorkers)
        {
            throw new NotImplementedException();
        }

        public Pharmacy Update(int Id, Pharmacy pharmacy)
        {
            throw new NotImplementedException();
        }
    }
}
