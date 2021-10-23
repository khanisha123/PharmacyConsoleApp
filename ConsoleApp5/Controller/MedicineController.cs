using System;
using System.Collections.Generic;
using System.Text;
using Business.Service;
using Entity.Models;
using Untilies.Helper;

namespace PharmacyApp.Controller
{
    public class MedicineController
    {
        public MedicineServicies medicineServicies { get;}
        public MedicineController()
        {
            medicineServicies = new MedicineServicies();
        }

        public void Creat()
        {
            Helper.ChangeTextColor(ConsoleColor.White, "Select Convenient Pharmacy ");
            string pharmacyName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter medicine type:");
            string type = Console.ReadLine();
            Medicine medicine = new Medicine{Type = type};
            Medicine newMed = medicineServicies.Creat(medicine, pharmacyName);

            if (newMed !=null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green,$"New Medicine Created {newMed.Type} ");
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Couldn't find such as Pharmacy {pharmacyName} ");

        }
        public void GetAllMedicineWithPharmacy() 
        {
            Helper.ChangeTextColor(ConsoleColor.White, "Select Convenient Pharmacy ");
            string pharmacyName = Console.ReadLine();
            List<Medicine> medicines = medicineServicies.Getall(pharmacyName);
            if (medicines != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Pharmacy {pharmacyName}:");
                foreach (var item in medicines)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green,
                        $" {item.Type}- {item.Id} ");
                }
                
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Couldn't find such as Pharmacy {pharmacyName} ");

        }
    }

}
