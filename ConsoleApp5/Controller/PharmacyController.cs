using Business.Service;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Untilies.Helper;

namespace PharmacyApp.Controller
{
    public class PharmacyController
    {
        public PharmacyServic pharmacyServic { get;}

        public PharmacyController()
        {
            pharmacyServic = new PharmacyServic();
        }
        public void Creat() 
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Medicine Type:");
            string name = Console.ReadLine();
           EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter End Date For Using Medicine");
            string PharmacyWareHouse = Console.ReadLine();
            int MaxPharmacyWareHouse;
            bool isTruePharmacyWareHouse = int.TryParse(PharmacyWareHouse, out MaxPharmacyWareHouse);
            if (isTruePharmacyWareHouse)
            {
                Pharmacy pharmacy = new Pharmacy { Name = name, PharmacyWareHouse = MaxPharmacyWareHouse };
                pharmacyServic.Creat(pharmacy);
                if (pharmacyServic.Creat(pharmacy) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{pharmacy.PharmacyWareHouse} Created");
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

        public void GetAll() 
        {
            Helper.ChangeTextColor(ConsoleColor.Red, $"All Pharmacy");
            foreach (var pharmacy in pharmacyServic.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Cyan, $"{pharmacy.Id} - {pharmacy.Name}");

            }
        }
        public void Delete() 
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter pharmacy Id Which Do you want to delete");
            string input = Console.ReadLine();
            int pharmacyId;
            bool isTrue = int.TryParse(input, out pharmacyId);
            if (isTrue)
            {

                if (pharmacyServic.Delete(pharmacyId)!=null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "pharmacy was deleted");
                    return;

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{pharmacyId} is not find");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please select corret format");
            }

           
            
        }
        public void GetPharmacyWithSize() 
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Ener pharmacy ware house size:");
            string input = Console.ReadLine();
            int MaxSize;
            bool isTrue = int.TryParse(input, out MaxSize);
            if (isTrue)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Phaemacy which size is {MaxSize}:");

                foreach (var item in pharmacyServic.GetAll(MaxSize))
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan,item.Name );

                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Please select correct format");
        }
    }
}
