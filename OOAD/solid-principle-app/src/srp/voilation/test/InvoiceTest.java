package srp.voilation.test;

import srp.voilation.Invoice;

public class InvoiceTest {

	public static void main(String[] args) {
		Invoice invoice = new Invoice(1, "Himanshu", 1000, 10);
		invoice.totalCost();
		invoice.printInvoice();

	}

}
