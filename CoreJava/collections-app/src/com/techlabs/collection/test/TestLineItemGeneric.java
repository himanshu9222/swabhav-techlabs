package com.techlabs.collection.test;

import java.util.ArrayList;
import java.util.Iterator;

import com.techlabs.collections.LineItem;

public class TestLineItemGeneric {

	public static void main(String[] args) {
		ArrayList<LineItem> cart=new ArrayList<LineItem>();
		cart.add(new LineItem(1, "Book", 3, 40));
		cart.add(new LineItem(2, "pen", 1, 10));
		cart.add(new LineItem(3, "pencil", 2, 5));
		cart.add(new LineItem(4, "eraser", 5, 2));
		//cart.add("hello");
		
		//for(Iterator<LineItem> item=cart.iterator();item.hasNext();){
			//LineItem itemss= (LineItem) item.next();
			//System.out.println(itemss);
		//}
		print(cart);
	}
	
	public static void print(Iterable<LineItem> items){
		for(LineItem item:items){
			System.out.println(item);
		}
		
	}

	
	

}
