using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Ejemplo1
{
    public class EmtyState: IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("The vending  machine is empty.Please restock.");
        }
        public void InsertPayment(int amount) 
        {
            Console.WriteLine("The vending machine is empty. No payment can be processed.");
        }
        public void SelectProduct(string product) 
        {
            Console.WriteLine("The vending machine is empty. please restock.");
        }
    }
}
