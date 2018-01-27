package assignment5;

import java.util.HashSet;
import java.util.Set;

public class TestHashSet {

	public static void main(String[] args) {
		Set<Student> set=new HashSet<Student>();
		Student s1=new Student(1,"himanshu",20);
		set.add(s1);
		Student s2=new Student(1,"himanshu",20);
		set.add(s2);
		Student s3=new Student(1,"himanshu",20);
		set.add(s3);
		
		System.out.println(set);
		
		
		//override hashcode and equals in this
		
		//public 
	}
	
	

}
