package assignment4;

public class Bike implements Vehicle{
	int gear;
	int speed;
	
	public void changeGear(int change){
		gear=gear+change;
	}
	
	public void speedUp(int increment){
		speed=speed+increment;
	}
	
	public void applyBrake(int decrement){
		speed=speed-decrement;
	}
	
	public void display(){
		System.out.println("Gear="+gear+"\tSpeed="+speed);
	}

}
