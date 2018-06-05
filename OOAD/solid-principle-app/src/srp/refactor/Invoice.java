package srp.refactor;

public class Invoice {
	private int number;
	private String name;
	private double cost;
	private double percentDistcount;
	private final double GST=0.05;
	
	public Invoice(int number,String name,double cost,double percentDiscount){
		this.setNumber(number);
		this.setName(name);
		this.cost=cost;
		this.percentDistcount=percentDiscount;
	}
	
	
	public double calculateDiscount(){
		cost=cost-(cost*(percentDistcount/100));
		return cost;
	}
	
	public double calculateTax(){
		return (cost*(GST));
	}
	
	public double totalCost(){
		return calculateDiscount()+calculateTax();
	}


	public int getNumber() {
		return number;
	}

	public void setNumber(int number) {
		this.number = number;
	}


	public String getName() {
		return name;
	}


	public void setName(String name) {
		this.name = name;
	}
}
