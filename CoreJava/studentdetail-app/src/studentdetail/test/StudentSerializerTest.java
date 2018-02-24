package studentdetail.test;

import static org.junit.Assert.*;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

import org.junit.Test;

import studentdetail.components.Student;
import studentdetail.components.StudentSerializer;

public class StudentSerializerTest {
	ArrayList<Student> studentList = new ArrayList<Student>();
	StudentSerializer serialize=new StudentSerializer();;
	Student student=new Student();
	String content="";
	private BufferedReader br;
	
	
	@Test
	public void setUp() throws IOException {
		student.setId();
		student.setName("Himanshu");
		student.setEmail("himanshulal65@gmail.com");
		studentList.add(student);
		serialize.serializeObject(studentList);
		File file = new File("src//studentdetail//components//student123456.txt");
		 
		br = new BufferedReader(new FileReader(file));
		String st;
		  while ((st = br.readLine()) != null)
		    content=content+st;
		  
	}
	
	@Test
	public void teststudentShouldSerialize() {
		assertTrue(content!=null);
	}

}
