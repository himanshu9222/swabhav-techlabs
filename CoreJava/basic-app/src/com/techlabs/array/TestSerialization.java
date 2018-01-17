package com.techlabs.array;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class TestSerialization {

	public static void main(String[] args) {
		
		Serialization name1=new Serialization("Himanshu","Lal");
		Serialization name2=new Serialization("Sarvesh","Singh");
		Serialization name3=new Serialization("Manish","Kali");
		
		try{
			FileOutputStream f1=new FileOutputStream("Name.ser",true);
			ObjectOutputStream file=new ObjectOutputStream(f1);
			file.writeObject(name1);
			file.writeObject(name2);
			file.writeObject(name3);
			file.close();
		}
		catch(Exception ex){
			ex.printStackTrace();
		}
		name1=null;
		name2=null;
		name3=null;
		
		try{
			FileInputStream f1=new FileInputStream("Name.ser");
			@SuppressWarnings("resource")
			ObjectInputStream file=new ObjectInputStream(f1);
			Serialization name1Restore=(Serialization) file.readObject();
			Serialization name2Restore=(Serialization) file.readObject();
			Serialization name3Restore=(Serialization) file.readObject();
			
			System.out.println(""+name1Restore.getFname());
			System.out.println(""+name1Restore.getLname());
			System.out.println(""+name2Restore.getFname());
			System.out.println(""+name2Restore.getLname());
			System.out.println(""+name3Restore.getFname());
			System.out.println(""+name3Restore.getLname());
			
			
		}
		catch(Exception ex){
			ex.printStackTrace();
		}

	}

}
