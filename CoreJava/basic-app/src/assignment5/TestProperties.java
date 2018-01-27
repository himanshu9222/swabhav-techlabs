package assignment5;

import java.util.Iterator;
import java.util.Properties;
import java.util.Set;

public class TestProperties {

	public static void main(String[] args) {
		Properties name=new Properties();
		@SuppressWarnings("rawtypes")
		Set fName;
		String str;
		
		name.put("Himanshu", "Lal");
		name.put("Dominic", "Lopes");
		name.put("Megha", "");
		name.put("Nirmiti", "Sangale");
		name.put("Ashwini", "Rathod");
		
		fName=name.keySet();
		@SuppressWarnings("rawtypes")
		Iterator itr=fName.iterator();
		
		while(itr.hasNext()){
			str= (String) itr.next();
			System.out.println("The Name of Student:"+str+"  Surname:"+name.getProperty(str));
		}
		System.out.println("\n");
		
		str=name.getProperty("Himanshu", "Not Found");
		System.out.println("The Sirname of Himanshu is:"+str);
		
		str=name.getProperty("Pravin", "Not Found");
		System.out.println("The Sirname of Pravin is  :"+str);

	}

}
