package com.techlabs;

import java.text.SimpleDateFormat;
import java.util.Date;

public class SyncThread implements Runnable{
	
	public void run(){
		SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy HH:mm:ss");
		Date date = new Date();
		System.out.println(formatter.format(date));
		int j=20;
		for(int i=0;i<j;i++){
			System.out.println(formatter.format(date));
			j++;
		}
	}
}
