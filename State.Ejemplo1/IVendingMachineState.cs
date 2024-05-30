using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Ejemplo1
{
    public interface IVendingMachineState
    {
        void SelectProduct(string product);
        void InsertPayment(int amount);
        void DispenseProduct();
    }
}
