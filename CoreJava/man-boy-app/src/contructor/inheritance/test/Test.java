package contructor.inheritance.test;

import constructor.inheritance.B;

public class Test {
	public static void main(String[] args){
		B b1;
		b1=new B();
		B b2;
		b2=new B(100);
		System.out.println(""+b1.getFoo());
		System.out.println(""+b2.getFoo());
	}
}
