package isp.voilation.test;

import isp.refactor.IWorkable;
import isp.refactor.IEatable;
import isp.refactor.Manager;
import isp.refactor.Robot;

public class TestISPRefactor {
	public static void main(String[] args) {
		Manager m=new Manager();
		Robot r=new Robot();
		atTheWorkStaion(m);
		atTheWorkStaion(r);
		
		atTheCafeteria(m);
		//atTheCafeteria(r);
		
	}
	
	public static void atTheWorkStaion(IWorkable obj){
		System.out.println("At the Work Station");
		obj.startWork();
		obj.stopWork();
	}
	
	public static void atTheCafeteria (IEatable obj){
		System.out.println("At the Cafeteria");
		obj.startEating();
		obj.stopEating();
	}
}
