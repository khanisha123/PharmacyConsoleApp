using Business.Service;
using Entity.Models;
using PharmacyApp.Controller;
using System;
using Untilies.Helper;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            PharmacyController pharmacyController = new PharmacyController();
            MedicineController medicineController = new MedicineController();
            Helper.ChangeTextColor(ConsoleColor.Green, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu,out menu);
                if (isTrue && menu>=1 && menu<=10)
                {
                    switch (menu)
                    {
                        case(int) Helper.Menu.CreatPharmacy:
                            pharmacyController.Creat();
                               break;
                        case (int) Helper.Menu.UpdatePharmacy:
                            pharmacyController.Update();
                            break;
                        case(int) Helper.Menu.DeletePharmacy:
                            pharmacyController.Delete();
                            break;
                        case (int) Helper.Menu.GetPharmacyWithId:
                            break;
                        case(int) Helper.Menu.GetPharmacyWithName:
                            break;
                        case (int)Helper.Menu.GetAllPharmacy:
                            pharmacyController.GetAll();
                            break;
                        case(int) Helper.Menu.GetPharmacyWareHouseWithSize:
                            pharmacyController.GetPharmacyWithSize();
                            break;
                        case (int)Helper.Menu.CreatMedicine:
                            pharmacyController.GetAll();
                            medicineController.Creat();
                            break;
                        case (int)Helper.Menu.GetAllMedicineWithPharmacy:
                            pharmacyController.GetAll();
                            medicineController.GetAllMedicineWithPharmacy();
                            break;
                        case (int)Helper.Menu.GetAllPharmacyWithType:
                            pharmacyController.GetPharmacyWithtype();
                            break;

                    }
                }
                else if (menu==0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Good Bye");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please Select Correct Menu");
                }

            }
        }
        static void ShowMenu() 
        {
            Helper.ChangeTextColor(ConsoleColor.Blue,
                    "1-Creat a New Pharmacy with Name,2-Update Pharmacy,3-Delete Pharmacy,4-Get Pharmacy with Id" +
                    "5-Get Pharmacy with Name,6-All Pharmacy,7-Get Pharmacy Ware House With Size, 8-Creat Medicine,9-Get All Medicine With Pharmacy," +
                    "10-Get All Pharmacy With Type,0-Exit");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Select Option");
        }
    }


}
