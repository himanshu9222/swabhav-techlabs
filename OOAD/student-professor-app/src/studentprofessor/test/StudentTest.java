package studentprofessor.test;

import static org.junit.Assert.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;


import org.junit.Test;

import studentprofessor.components.EBranch;
import studentprofessor.components.Student;

public class StudentTest {
	Student student;
	EBranch branch;
	@Test
	public void testGetterOfStudent() throws ParseException {
		
		student=new Student("Himanshu", "Nallasopara",new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"), branch.Computer);
		assertEquals("Himanshu", student.getName());
		assertNotNull(student.getId());
		System.out.println(student.setDate());
		
	}

}
