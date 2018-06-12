package studentprofessor.test;

import static org.junit.Assert.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import org.junit.Test;
import studentprofessor.components.EBranch;
import studentprofessor.components.Student;

public class StudentTest {
	Student student;
	EBranch branch;

	@SuppressWarnings("static-access")
	@Test
	public void testGetterOfStudent() throws Exception {

		student = new Student("Himanshu", "Nallasopara", new SimpleDateFormat(
				"yyyy/MM/dd").parse("1996/02/23"), branch.Computer);
		assertEquals("Himanshu", student.getName());
		assertNotNull(student.getId());
		assertEquals("Nallasopara", student.getAddress());
		assertEquals("1996/02/23", student.getDate());

		Calendar dob = Calendar.getInstance();
		dob.setTime(new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"));
		int age = student.getAge(dob);
		int expectedage = 22;

		assertEquals(expectedage, age);
		System.out.println(age);
	}

	@SuppressWarnings("static-access")
	@Test
	public void testSetterOfStudent() throws ParseException {
		student = new Student("", "",
				new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"),
				branch.Computer);
		student.setName("Himanshu");
		student.setAddress("Nallasopara");
		student.setBranch(branch.Computer);
		student.setId();
		student.setDob(new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"));

		assertEquals("Himanshu", student.getName());
		assertNotNull(student.getId());
		assertEquals("Nallasopara", student.getAddress());
		assertEquals("1996/02/23", student.getDate());
	}

}
