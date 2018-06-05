package studentprofessor.test;

import static org.junit.Assert.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import org.junit.Test;

import studentprofessor.components.Professor;

public class ProfessorTest {
	Professor professor;
	
	@Test
	public void testGetterOfProfessor() throws Exception {
		professor = new Professor("Himanshu", "Nallasopara",
				new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"), 10000);
		assertEquals("Himanshu", professor.getName());
		assertNotNull(professor.getId());
		assertEquals("Nallasopara",professor.getAddress());
		assertEquals("1996/02/23",professor.getDate());
		
		Calendar dob=Calendar.getInstance();
		dob.setTime(new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"));
		int age= professor.getAge(dob);
		int expectedage=22;
		
		assertEquals(expectedage, age);
		System.out.println(age);
	}
	
	@Test
	public void testSetterOfStudent() throws ParseException{
		professor=new Professor("", "",new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"), 10000);
		professor.setName("Himanshu");
		professor.setAddress("Nallasopara");
		professor.setId();
		professor.setDob(new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"));
		
		assertEquals("Himanshu", professor.getName());
		assertNotNull(professor.getId());
		assertEquals("Nallasopara",professor.getAddress());
		assertEquals("1996/02/23",professor.getDate());
	}

}
