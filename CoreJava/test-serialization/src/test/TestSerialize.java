package test;

import java.io.IOException;
import java.util.ArrayList;

import components.SerializeStudent;
import components.Student;;

public class TestSerialize {
	public static void main(String[] args) throws IOException, ClassNotFoundException{
	ArrayList<Student> studentList = new ArrayList<Student>();
	/*Student s1 = new Student("1", "him", "himanshulal1233@gmail.com");
	Student s2 = new Student("2", "ans", "anshulal1233@gmail.com");

	studentList.add(s1);
	studentList.add(s2);
	System.out.println(studentList.size());*/

	SerializeStudent ss = new SerializeStudent();
	//ss.serializeObject(studentList);

	studentList = null;

	studentList=ss.deserializeObject();
	
	//System.out.println(s1.getEmail());
	System.out.println(studentList.size());
}
}

