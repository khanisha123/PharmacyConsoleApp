using Entity.Models;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public static class DBContext
    {
        public static List<Medicine> Medicines { get;}
        public static List<Pharmacy> Pharmacies { get;}


        static DBContext()
        {
            Medicines = new List<Medicine>();
            Pharmacies = new List<Pharmacy>();
        }
    }
}
