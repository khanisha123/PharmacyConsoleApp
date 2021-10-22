using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IMedicine
    {
        Medicine Creat(Medicine medicine);
        Medicine Update(int Id, Medicine medicine);
        Medicine Delete(int Id);
        Medicine Get(int Id);
        Medicine Get(string type);
        List<Medicine> GetAll();
        List<Medicine> GetAll(long MaximumSizeDrugHolding);
        List<Medicine> GetAll(int NumberOfWorkers);
    }
}
