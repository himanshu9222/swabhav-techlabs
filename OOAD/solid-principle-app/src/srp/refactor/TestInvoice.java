package srp.refactor;


public class TestInvoice {
	public static void main(String[] args) {
	Invoice invoice = new Invoice(1, "Himanshu", 1000, 10);
	invoice.calculateDiscount();
	invoice.calculateTax();
	InvoiceConsolePrinter icp=new InvoiceConsolePrinter();
	icp.printDetail(invoice);
	}
}
