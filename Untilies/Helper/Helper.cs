using System;
using System.Collections.Generic;
using System.Text;

namespace Untilies.Helper
{
    public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        
        public enum Menu 
        {
            Exit,
            CreatPharmacy,
            UpdatePharmacy,
            DeletePharmacy,
            GetPharmacyWithId,
            GetPharmacyWithName,
            GetAllPharmacy,
            GetPharmacyWareHouseWithSize,
            CreatMedicine,
            GetAllMedicineWithPharmacy,

        }
    }
}
