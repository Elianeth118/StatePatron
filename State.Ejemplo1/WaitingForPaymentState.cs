using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Ejemplo1
{
    public class WaitingForPaymentState:IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine($"Please insert payment first.");
        }
        public void InsertPayment(int amount)
        {
            Console.WriteLine($"Inserted payment of {amount}.");
        }
        public void SelectProduct(string product)
        {
            Console.WriteLine($"Product '{product}' hasalready been selected, waiting for payment.");
        }
    }
}
