using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Ejemplo1
{
    public class VendingMachine
    {
        private IVendingMachineState _state;
        public VendingMachine()
        {
            _state = new WaitingForProductSelectionState();
        }
        public void SetState(IVendingMachineState state) 
        {
            _state = state;
        }
        public void SelectProduct(string product)
        {
            _state.SelectProduct(product);
        }
        public void InsertPayment(int amount)
        {
            _state.InsertPayment(amount);
        }
        public void DispenseProduct() 
        {
            _state.DispenseProduct();
        }
    }
}
