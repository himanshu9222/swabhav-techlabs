package com.techlabs;

public class AsyncThread implements Runnable{
	@Override
	public void run() {
		while(true)
	                System.out.println("Asychronous Thread");           
	}
}
