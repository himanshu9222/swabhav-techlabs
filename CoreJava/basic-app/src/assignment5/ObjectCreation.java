package assignment5;

public class ObjectCreation {

	public static void main(String[] args) throws InstantiationException,
			IllegalAccessException, ClassNotFoundException {
		Employee emp1 = new Employee();

		Employee emp2 = (Employee) emp1.clone();
		emp2.setName("Himanshu");

		System.out.println(emp2);

		Employee emp3 = (Employee) Class.forName("assignment5.Employee").newInstance();
		//Employee emp3 = Employee.class.newInstance();
		emp3.setName("Lal");
		
		System.out.println(emp3);
	}

}
