package assignment5;

import java.util.LinkedHashSet;
import java.util.Set;

public class LinkedHashSetDemo {

	public static void main(String[] args) {
		Set<String> linkedhashset = new LinkedHashSet<String>();

		// create
		linkedhashset.add("A");
		linkedhashset.add("D");
		linkedhashset.add("C");
		linkedhashset.add("B");
		linkedhashset.add("E");
		linkedhashset.add("A");// adding existing element
		linkedhashset.add(null);

		// read
		System.out.println(linkedhashset);
		System.out.println("LinkedHashSet contains P :"
				+ linkedhashset.contains("P"));

		// update
		System.out.println("");
		linkedhashset.remove("C");
		linkedhashset.add("P");
		//linkedhashset.add("C");
		System.out.println("After removing C and adding P :" + linkedhashset);

		// delete
		linkedhashset.clear();
		System.out.println("\nAfter deleting elements");
		System.out.println(linkedhashset);

	}

}
