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
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Pharmacy Name:");
            string name = Console.ReadLine();
           EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Pharmacy Ware House Max Size");
            string size = Console.ReadLine();
           EnterType: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Pharmacy Type:");
            string type = Console.ReadLine();

          

            int maxSize;
            bool isTrueSize = int.TryParse(size,out maxSize);
            if (isTrueSize)
            {
                Pharmacy pharmacy = new Pharmacy { Name = name, MaxPharmacyWareHouseSize = maxSize,Type=type };
                if (pharmacyServic.Creat(pharmacy) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{pharmacy.Name} Created");
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
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter correct Size");
                goto EnterName;
            }

           
            


        }
        public void Update()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter pharmacy Id Which Do you want to Update ");
            string input = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Add A New Pharmacy Name ");
            string input1 = Console.ReadLine();
            int Id;
            bool isTrueU = int.TryParse(input,out Id);
            if (isTrueU)
            {
                Pharmacy pharmacy = new Pharmacy {Name=input1};
                if (pharmacyServic.Update(Id,pharmacy)!=null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, "Name is Changed");
                    return;

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please Enter Correct Format");
                }

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Please select corect format");
            }
            
        }    

        public void GetAll() 
        {
            Helper.ChangeTextColor(ConsoleColor.Red, $"All Pharmacy");
            foreach (Pharmacy pharmacy in pharmacyServic.GetAll())
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
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please select correct format");
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
        public void GetPharmacyWithtype() 
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Ener pharmacy Type:");
            string input = Console.ReadLine();
            
            //string maxType;
           
           
            
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Pharmacy which type is {input}");
                foreach (var item in pharmacyServic.GetAllWithPharmacyType(input))
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, item.Name);
                }
                return;

            
           

        }
    }
}
