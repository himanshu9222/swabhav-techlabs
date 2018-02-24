package shopping.components.testcomponent;

import shopping.components.LineItem;
import shopping.components.Product;

public class TestLineItem {
	
	public static void main(String[] args) {
	Product p=new Product("Himanshu", 10000, 10);
	Product q=new Product("Anshu", 50000, 10);
	LineItem l=new LineItem(p,5);
	LineItem n=new LineItem(q,5);
	System.out.println(l);
	System.out.println(n);
	
	
	}
}
