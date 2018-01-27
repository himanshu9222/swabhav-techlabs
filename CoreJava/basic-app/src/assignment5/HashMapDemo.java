package assignment5;

import java.util.HashMap;
import java.util.Map;

public class HashMapDemo {

	public static void main(String[] args) {
		Map<Integer, String> hashmap = new HashMap<>();
		print(hashmap);
		// create
		hashmap.put(1, "Himanshu");
		hashmap.put(9, "Dominic");
		hashmap.put(8, "Gevin");
		hashmap.put(4, "Sanika");
		print(hashmap);
		
		hashmap.put(1, "Megha");// same key value

		// read
		print(hashmap);
		System.out.println("Size of map is:- " + hashmap.size());
		if (hashmap.containsKey(8)) {
			String a = hashmap.get(8);
			System.out.println("value for key 8 is:- " + a);
		}

		// update
		hashmap.put(3, "Hello");
		hashmap.remove(1);
		System.out.println("the updated list is");
		print(hashmap);

		// delete
		hashmap.clear();
		print(hashmap);

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
