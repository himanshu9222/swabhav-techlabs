package assignment4;

public class TestInterface{
	
	public static void main(String[] args){
		Bike run=new Bike();
		run.changeGear(5);
		run.speedUp(8);
		run.applyBrake(3);
		run.display();	
	}
}
