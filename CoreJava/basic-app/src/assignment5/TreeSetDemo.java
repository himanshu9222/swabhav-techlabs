package assignment5;

import java.util.Set;
import java.util.TreeSet;

public class TreeSetDemo {

	public static void main(String[] args) {
		Set<String> treeset=new TreeSet<String>();
		
		treeset.add("K");
		treeset.add("Hello");
		treeset.add("D");
		treeset.add("Z");
		treeset.add("O");
		treeset.add("Welcome");
		treeset.add("K");// inserted again
		
		//read
		System.out.println(treeset);
		
		//update
		treeset.add("Dog");
		treeset.remove("O");
		System.out.println("\n After inserting Dog and removing O :"+treeset);
		
		//delete
		treeset.clear();
		System.out.println("\nAfter deleting all elements :"+treeset);
		

	}

}
