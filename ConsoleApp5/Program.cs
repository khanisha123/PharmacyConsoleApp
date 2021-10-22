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
            MedicineController medicineController = new MedicineController();
            Helper.ChangeTextColor(ConsoleColor.Green, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu,out menu);
                if (isTrue && menu>0 && menu<8)
                {
                    switch (menu)
                    {
                        case(int) Helper.Menu.CreatANewMedicineType:
                            medicineController.Creat();
                               break;
                        case (int) Helper.Menu.UpdateMedicine:
                            break;
                        case(int) Helper.Menu.DeleteMedicine:
                            break;
                        case (int) Helper.Menu.GetMedicineWithId:
                            break;
                        case(int) Helper.Menu.GetMedicineWithType:
                            break;
                        case 6:
                            medicineController.GetAllGroup();
                            break;
                        case(int) Helper.Menu.GetMedicineWithSize:
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
                    "1-Creat a New Medicine Type,2-Update Medicine,3-Delete Medicine,4-Get MEdicine with Id" +
                    "5-Get MEdicine with type,6-All Medicine,7-Get Medicine with Size,0-Exit");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Select Option");
        }
    }
}
