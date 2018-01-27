package assignment5;

public class Employee implements Cloneable{
	private String name;

    public Employee() {
        System.out.println("Employee Constructor Called...");
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
	
	@Override
    public String toString() {
        return "Employee name = " + name;
    }

    @Override
    public Object clone() {

        Object obj = null;
        try {
            obj = super.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        return obj;
    }
}
