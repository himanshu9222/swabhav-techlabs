package com.techlabs.collections.sort;

import java.util.ArrayList;
import java.util.Collections;

import com.techlabs.collections.LineItem;

public class TestLineItemSort{

	public static void main(String[] args) {
		ArrayList<LineItem> item=new ArrayList<LineItem>();
		item.add(new LineItem(1, "Book", 3, 40));
		item.add(new LineItem(2, "pen", 1, 10));
		item.add(new LineItem(3, "pencil", 2, 5));
		item.add(new LineItem(4, "eraser", 5, 2));
		
		Collections.sort(item);
		print(item);
		
		Collections.sort(item, new SortByNameComparator());
		print(item);
	}

	public static void print(Iterable<LineItem> items){
		for(LineItem item:items){
			System.out.println(item);
		}
		
	}

	
}
