package shopping.components;

public class LineItem {
	private static int totalNumberOfid;
	
	private int id;
	Product product;
	private int quantity;

	static {
		totalNumberOfid = 0;
	}

	public LineItem(Product product, int quantity) {
		this.product = product;
		this.quantity = quantity;
		id=generateId();
	}
	
	public int generateId(){
		return (++totalNumberOfid);
	}

	public double calcItemCost() {
		return product.calcDiscountCost() * quantity;
	}

	public double getLineItemCost() {
		return calcItemCost();
	}

	public int getLineItemId() {
		return id;
	}

	public int getLineItemQuantity() {
		return quantity;
	}
	
	public Product getProduct(){
		return product;
	}
	
	public void addQuantity(int quantity){
		this.quantity+=quantity;
	}

	public String toString() {
		return product.toString() + "\nLineItem Id =" + getLineItemId()
				+ "\nLineItem cost =" + getLineItemCost() + " For Quantity = "+getLineItemQuantity();
	}

}
