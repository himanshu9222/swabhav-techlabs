package test;

import components.Student;
import components.SwabhavQ;

public class Test {

	public static void main(String[] args) {
		SwabhavQ<Student> q=new SwabhavQ<Student>();
		
		Student s1=new Student("Himanshu","himanshu@gmail.com");
		Student s2=new Student("Pratik","pratik123@gmail.com");
		Student s3=new Student("Krishna","krish@gmail.com");
		
		q.enqueue(s1);
		q.enqueue(s2);
		q.enqueue(s3);
		
		System.out.println(q.size());
		
		//System.out.println(q.dequeue());
		
		for(Student s: q){
			System.out.println(s);
		}
	}

}
