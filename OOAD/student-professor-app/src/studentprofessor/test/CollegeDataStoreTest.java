package studentprofessor.test;

import static org.junit.Assert.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;

import org.junit.Test;

import studentprofessor.components.CollegeDataStore;
import studentprofessor.components.EBranch;
import studentprofessor.components.Professor;
import studentprofessor.components.Student;

public class CollegeDataStoreTest {
	Student student;
	Professor professor;
	EBranch branch;
	CollegeDataStore cds = new CollegeDataStore();

	@SuppressWarnings("static-access")
	@Test
	public void testAddStudent() throws ParseException {
		int beforeAdding, afterAdding;

		student = new Student("Himanshu", "Nallasopara", new SimpleDateFormat(
				"yyyy/MM/dd").parse("1996/02/23"), branch.Computer);
		beforeAdding = cds.getAllStudent().size();
		cds.addStudent(student);
		afterAdding = cds.getAllStudent().size();
		assertTrue("Not Working", beforeAdding<afterAdding);
	}

	@Test
	public void testAddProfessor() throws ParseException {
		int beforeAdding, afterAdding;

		professor = new Professor("Himanshu", "Nallasopara",
				new SimpleDateFormat("yyyy/MM/dd").parse("1996/02/23"), 10000);
		beforeAdding = cds.getAllProfessor().size();
		cds.addProfessor(professor);
		afterAdding = cds.getAllProfessor().size();
		System.out.println(beforeAdding+"   "+afterAdding);
		assertTrue("Not Working", beforeAdding<afterAdding);
	}

}
