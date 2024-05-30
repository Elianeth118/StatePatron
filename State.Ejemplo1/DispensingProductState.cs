using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Ejemplo1
{
    public class DispensingProductState:IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine($"Dispensing product now...");
        }
        public void InsertPayment(int amount)
        {
            Console.WriteLine("Please wait! Dispensing in progress");
        }
        public void SelectProduct(string product)
        {
            Console.WriteLine("Please wait! Dispensing in progress");
        }
    }
}
