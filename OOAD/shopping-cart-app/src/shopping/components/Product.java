package shopping.components;

public class Product {
	private static int totalNumberOfId;
	
	private int id;
	private String name;
	private double price;
	private double discountPercent;
	
	
	static{
		totalNumberOfId=100;
	}
	public Product(String name,double price,double discountPercentage){
		this.name=name;
		this.price=price;
		this.discountPercent=discountPercentage;
		id=generateId();
	}
	
	public int generateId(){
		return (++totalNumberOfId);
	}
	
	public double calcDiscountCost(){
		
		return (price-(price*(discountPercent*0.01)));
	}
	
	public String getName(){
		return name;
	}
	
	public int getProductId(){
		return id;
	}
	
	public String toString(){
		return "Product Id ="+getProductId()+"\nName of product = "+getName()+"\nPrice = "+calcDiscountCost();
	}
}
