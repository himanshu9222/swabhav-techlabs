package assignment5;

import java.util.Map;
import java.util.TreeMap;

public class TreeMapDemo {

	public static void main(String[] args) {
		Map<Integer, String> treemap = new TreeMap<>();
		print(treemap);
		// create
		treemap.put(1, "Himanshu");
		treemap.put(9, "Dominic");
		treemap.put(8, "Gevin");
		treemap.put(4, "Sanika");
		print(treemap);
		
		treemap.put(1, "Megha");// same key value
		print(treemap);
		
		// read
		print(treemap);
		System.out.println("Size of map is:- " + treemap.size());
		if (treemap.containsKey(8)) {
			String a = treemap.get(8);
			System.out.println("value for key 8 is:- " + a);
		}

		// update
		treemap.put(3, "Hello");
		treemap.remove(1);
		System.out.println("the updated list is");
		print(treemap);

		// delete
		treemap.clear();
		print(treemap);

	}

	public static void print(Map<Integer, String> map) {
		if (map.isEmpty()) {
			System.out.println("\nmap is empty");
		}

		else {
			System.out.println("\n" + map);
		}
	}
}
