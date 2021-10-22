using Entity.Models;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public static class DBContent
    {
        public static List<Medicine> Medicines { get;}
        public static List<Pharmacy> Pharmacies { get;}


        static DBContent()
        {
            Medicines = new List<Medicine>();
            Pharmacies = new List<Pharmacy>();
        }
    }
}
