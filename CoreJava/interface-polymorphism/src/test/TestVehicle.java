package test;

import com.techlabs.vehicle.Bike;
import com.techlabs.vehicle.Car;
import com.techlabs.vehicle.IMovable;
import com.techlabs.vehicle.Truck;

public class TestVehicle {

	public static void main(String[] args) {
		IMovable[] abc={new Car(),new Truck(),new Bike(),new Bike()};
		startDriving(abc);
	}
	
	public static void startDriving(IMovable[] movable){
		//System.out.println("Start");
		//movable[0].move();
		//movable[1].move();
		//movable[2].move();
		//System.out.println("Stop\n");
		
		System.out.println("Start");
		for(IMovable move:movable){
			move.move();
		}
		System.out.println("Stop\n");
		
	}

}
