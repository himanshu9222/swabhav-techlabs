package shopping.components.testcomponent;

import java.util.Date;

import shopping.components.Customer;
import shopping.components.LineItem;
import shopping.components.Order;
import shopping.components.Product;

public class TestCustomer {
	public static void main(String[] args) {
		Product p = new Product("Himanshu", 10000, 10);
		Product q = new Product("Anshu", 50000, 10);
		Product r = new Product("Dominic", 10000, 10);
		Product s = new Product("Gevin", 50000, 10);

		LineItem l = new LineItem(p, 5);
		LineItem n = new LineItem(q, 5);
		LineItem o = new LineItem(r, 5);
		LineItem i = new LineItem(s, 5);

		Order obj1 = new Order(new Date());
		obj1.addLineItem(o);
		obj1.addLineItem(i);
		obj1.addLineItem(i);

		Order obj2 = new Order(new Date());
		obj2.addLineItem(l);
		obj2.addLineItem(n);

		Customer customer1 = new Customer("hello");
		customer1.addCustomer(obj1);

		Customer customer2 = new Customer("hiiiii");
		customer2.addCustomer(obj2);
		printDetails(customer1);
		printDetails(customer2);
	}

	public static void printDetails(Customer customer) {
		System.out.println("\nCustomer Name = " + customer.getCustomerName()
				+ "\nCustomer Id = " + customer.getCustomerId());
		for (Order order : customer.getOrderList()) {
			System.out.print("Order Id = " + order.getOrderId()
					+ "\nCheckOutPrice = " + order.checkOutPrice() + "\nDate"
					+ order.getDate());
			for (LineItem lineItem : order.getLineItemsList()) {
				System.out.print("\nLineItems id = " + lineItem.getLineItemId()
						+ "\nLine Item Cost = " + lineItem.getLineItemCost()
						+ "\nLineItem Quantity = "
						+ lineItem.getLineItemQuantity()+"\n");
				System.out.println("Product Name = "+lineItem.getProduct().getName()+"\nProduct Id = "+lineItem.getProduct().getProductId());
					
				}
			}
		}
	}

