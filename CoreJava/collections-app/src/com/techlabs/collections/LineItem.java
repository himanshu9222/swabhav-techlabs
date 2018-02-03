package com.techlabs.collections;


public class LineItem  implements Comparable<LineItem>{
	private int id;
	private String name;
	private int quantity;
	private double unitPrice;
	
	public LineItem(int id,String name,int quantity,double unitPrice){
		this.id=id;
		this.name=name;
		this.quantity=quantity;
		this.unitPrice=unitPrice;
	}
	
	public double calcTotalCost(){
		return quantity*unitPrice;
	}
	
	public double getTotalPrice(){
		return quantity*unitPrice;
	}
	
	public int getId(){
		return id;
	}
	
	public String getName(){
		return name;
	}
	
	@Override
	public String toString(){
		return "\nName = "+name+"\nId ="+id+"\nPrice ="+getTotalPrice();
	}

	@Override
	public int compareTo(LineItem o) {
		return (this.id-o.id);
	}
}
