package com.techlabs.array;
//"http://www.Swabhavtechlabs.com?student=himanshu"
public class StringTest {

	public static void main(String[] args) {
		String name="http://www.Swabhavtechlabs.com?student=himanshu";
		int limit=4;
		System.out.println(name.substring(limit));
		System.out.println(name.substring(limit,10));
		
		String[] names= name.split("\\.");
		for(String n: names){
			System.out.println(n);
		}
         		
		String[] namess= name.split("\\.", 3);
		for(String n: namess){
			System.out.println(n);
		}
	}

}
