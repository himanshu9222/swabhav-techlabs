package shopping.components;

import java.util.ArrayList;

public class Customer {
	private static int totalNumberOfid;

	private int id;
	private String name;
	private ArrayList<Order> orders = new ArrayList<Order>();

	public Customer(String name) {
		this.name = name;
		id = generateId();
	}

	public void addCustomer(Order order) {
		orders.add(order);
	}
	
	public ArrayList<Order> getOrderList(){
		return (ArrayList<Order>) orders;
	}

	static {
		totalNumberOfid = 0;
	}

	public int generateId() {
		return (++totalNumberOfid);
	}

	public String getCustomerName() {
		return name;
	}

	public int getCustomerId() {
		return id;
	}
}
