package shopping.components.testcomponent;

import java.util.Date;

import shopping.components.LineItem;
import shopping.components.Order;
import shopping.components.Product;

public class TestOrder {

	public static void main(String[] args) {
		
		Product p=new Product("Himanshu", 10000, 10);
		Product q=new Product("Anshu", 50000, 10);
		
		LineItem l=new LineItem(p,5);
		LineItem n=new LineItem(q,5);
		
		Order obj=new Order(new Date()); 
		obj.addLineItem(l);
		obj.addLineItem(n);
		System.out.println(obj.checkOutPrice());
		System.out.println(obj.getDate());

	}

}
