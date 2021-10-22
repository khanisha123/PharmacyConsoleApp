using Business.Service;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Untilies.Helper;

namespace PharmacyApp.Controller
{
    class MedicineController
    {
        public MedicineServic medicineServic { get; set; }

        public MedicineController()
        {
            medicineServic = new MedicineServic();
        }
        public void Creat() 
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Medicine Type:");
            string type = Console.ReadLine();
        EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter End Date For Using Medicine");
            string EndDateForUsing = Console.ReadLine();
            int MaxEndDateForUsing;
            bool isTrueEndDateForUsing = int.TryParse(EndDateForUsing, out MaxEndDateForUsing);
            if (isTrueEndDateForUsing)
            {
                Medicine medicine = new Medicine { type = type, EndDateForUsing = MaxEndDateForUsing };
                medicineServic.Creat(medicine);
                if (medicineServic.Creat(medicine) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{medicine.EndDateForUsing} Created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, $"Something happened wrong");
                    return;
                }

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter correct End Date For Using");
                goto EnterName;
            }
        }

        public void GetAllGroup() 
        {
            Helper.ChangeTextColor(ConsoleColor.Red, $"All medicine");
            foreach (var medicine in medicineServic.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Cyan, $"{medicine.Id} - {medicine.type}");

            }
        }
    }
}
