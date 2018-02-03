package looselycouplingexample;

public class A {
	void display(InterfaceClass obji)
	{
		obji.display();
		System.out.println(obji.getVar());
		//obji.setVar("hELLO");       //Gives us an error since not defined in Interfaceclass 
	}
}
