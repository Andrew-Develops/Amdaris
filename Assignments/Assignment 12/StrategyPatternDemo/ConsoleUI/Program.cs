
PaymentService service1 = new PaymentService();
service1.SetPaymentBehaviour(new PayByCreditCard());
service1.ProcessOrder();

PaymentService service2 = new PaymentService();
service2.SetPaymentBehaviour(new PayByPayPal());
service2.ProcessOrder();

Console.ReadLine();
class PaymentService
{
	public PaymenyBehaviour Payment { get; set; }
	
	public void SetPaymentBehaviour(PaymenyBehaviour paymenyBehaviour)
	{
		Payment = paymenyBehaviour;
	}
	public void ProcessOrder()
	{
		Payment.Pay();
	}
}
interface PaymenyBehaviour
{
	void Pay();
}

class PayByCreditCard : PaymenyBehaviour
{
	public void Pay()
	{
		Console.WriteLine("Pay by credit card");
	}
}
class PayByPayPal : PaymenyBehaviour
{
	public void Pay()
	{
		Console.WriteLine("Pay by PayPal");
	}
}
