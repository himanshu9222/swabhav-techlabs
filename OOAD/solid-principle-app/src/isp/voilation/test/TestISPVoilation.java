package isp.voilation.test;

import isp.voilation.IWorker;
import isp.voilation.Manager;
import isp.voilation.Robot;

public class TestISPVoilation {

	public static void main(String[] args) {
		Manager m=new Manager();
		Robot r=new Robot();
		atTheWorkStaion(m);
		atTheWorkStaion(r);
		
		atTheCafeteria(m);
		atTheCafeteria(r);
		
	}
	
	public static void atTheWorkStaion(IWorker obj){
		System.out.println("At the Work Station");
		obj.startWork();
		obj.stopWork();
	}
	
	public static void atTheCafeteria (IWorker obj){
		System.out.println("At the Cafeteria");
		obj.startEating();
		obj.stopEating();
	}

}
