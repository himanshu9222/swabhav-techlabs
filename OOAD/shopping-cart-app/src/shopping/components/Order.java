package shopping.components;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;


public class Order {
	private static int totalNumberOfid;
	private int id;
	private List<LineItem> items=new ArrayList<LineItem>();
	Date date=new Date();
	private double totalPrice=0;
	LineItem lineItem;
	Product product;
	
	static{
		totalNumberOfid=0;
	}
	
	public Order(Date date){
		this.date=date;
		id=generateId();
	}
	
	public void addLineItem(LineItem item){
		for(LineItem lineItem:items){
			if(lineItem.getProduct().getProductId()==item.getProduct().getProductId()){
				lineItem.addQuantity(item.getLineItemQuantity());
			}
		}
		items.add(item);
	}
	
	public ArrayList<LineItem> getLineItemsList(){
		return (ArrayList<LineItem>) items;
	}
	
	public double checkOutPrice(){
		//LineItem lineItem=new LineItem();
		for(LineItem item:items){
			totalPrice+= item.getLineItemCost();
		}
		return totalPrice;
	}
	
	public int generateId(){
		return (++totalNumberOfid);
	}
	
	public int getOrderId(){
		return id;
	}
	
	public Date getDate(){
		return date;
	}
	
}
