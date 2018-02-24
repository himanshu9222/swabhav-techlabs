package studentdetail.test;

import static org.junit.Assert.*;

import java.io.IOException;
import java.util.ArrayList;

import org.junit.Test;

import studentdetail.components.Student;
import studentdetail.components.StudentDeserializer;

public class StudentDeserializerTest {
	ArrayList<Student> studentList = new ArrayList<Student>();
	Student student=new Student();
	StudentDeserializer deserialize=new StudentDeserializer();
	String name="Himanshu";
	
	
	@Test
	public void testdeserialization() throws ClassNotFoundException, IOException {
		studentList=deserialize.deserializeObject();
		student=studentList.get(0);
		//System.out.println(student.getName());
		assertTrue(student.getName().equals(name));
	}
	

}
