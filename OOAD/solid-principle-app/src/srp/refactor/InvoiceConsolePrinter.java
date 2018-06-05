package srp.refactor;

public class InvoiceConsolePrinter{
	public void printDetail(srp.refactor.Invoice invoice){
		System.out.println("Number =" + invoice.getNumber() + "\tName = " + invoice.getName()
				+ "\tTotal Cost =" + invoice.totalCost());
	}
}

