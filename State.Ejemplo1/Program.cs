// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using State.Ejemplo1;

VendingMachine vendingMachine = new VendingMachine();

vendingMachine.SelectProduct("candy");
vendingMachine.SetState(new WaitingForPaymentState());

vendingMachine.InsertPayment(50);
vendingMachine.SetState(new DispensingProductState());

vendingMachine.DispenseProduct();
vendingMachine.SetState(new EmtyState());

vendingMachine.SelectProduct("Soda");
