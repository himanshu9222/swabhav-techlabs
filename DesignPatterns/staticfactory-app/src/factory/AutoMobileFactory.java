package factory;

import automobile.Audi;
import automobile.AutoType;
import automobile.Bmw;
import automobile.IAutomobable;
import automobile.Tesla;

public class AutoMobileFactory {
 public static IAutomobable make(AutoType type){
	 if(type.equals("BMW")){ 
		 return new Bmw();
	 }
	 else if(type.equals("AUDI")){
		 return new Audi();
	 }
	 else{
		 return new Tesla();
	 }
 }
}
//this faces voilation of open close principle so new project factorymethodapp