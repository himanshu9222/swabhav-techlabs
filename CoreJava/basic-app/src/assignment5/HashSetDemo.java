package assignment5;

import java.util.HashSet;
import java.util.Set;

public class HashSetDemo {

	public static void main(String[] args) {
		// create
		Set<String> hashset = new HashSet<String>();
		hashset.add("A");
		hashset.add("D");
		hashset.add("C");
		hashset.add("B");
		hashset.add("E");
		hashset.add("A");// adding again
		hashset.add(null);

		// read
		System.out.println(hashset);
		System.out.println("List contain Z or Not:" + hashset.contains("Z"));

		// update
		System.out.println("");
		hashset.add("G");
		hashset.remove("E");
		System.out.println("List After Removing E and Adding G");
		System.out.println(hashset);

		// delete
		System.out.println("\nAfter Removing all the elements");
		hashset.clear();
		System.out.println(hashset);

	}

}
