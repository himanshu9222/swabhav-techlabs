package looselycouplingexample;

public class TestLCE {
	public static void main(String[] args) {

		A obja=new A();
		InterfaceClass objb=new B();    //B objb=new B(); both the ways it works 
		obja.display(objb);		//Calling display of A class with object of B class 
		
	}
}
