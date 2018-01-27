package assignment5;


import java.util.LinkedHashMap;
import java.util.Map;

public class LinkedHashMapDemo {

	public static void main(String[] args) {
		Map<Integer, String> linkedhashmap = new LinkedHashMap<>();
		print(linkedhashmap);
		// create
		linkedhashmap.put(1, "Himanshu");
		linkedhashmap.put(9, "Dominic");
		linkedhashmap.put(8, "Gevin");
		linkedhashmap.put(4, "Sanika");
		print(linkedhashmap);
		
		
		linkedhashmap.put(1, "Megha");// same key value

		// read
		print(linkedhashmap);
		System.out.println("Size of map is:- " + linkedhashmap.size());
		if (linkedhashmap.containsKey(8)) {
			String a = linkedhashmap.get(8);
			System.out.println("value for key 8 is:- " + a);
		}

		// update
		linkedhashmap.put(3, "Hello");
		linkedhashmap.remove(1);
		System.out.println("the updated list is");
		print(linkedhashmap);

		// delete
		linkedhashmap.clear();
		print(linkedhashmap);

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
