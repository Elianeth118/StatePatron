using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Ejemplo1
{
   public class WaitingForProductSelectionState:IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine($"Please select a product first.");
        }
        public void InsertPayment(int amount)
        {
            Console.WriteLine($"Please select a product first.");
        }
        public void SelectProduct(string product)
        {
            Console.WriteLine($"Product '{product}' has been selected.");
        }
    }
}
