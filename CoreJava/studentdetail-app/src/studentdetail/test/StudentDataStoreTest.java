package studentdetail.test;

import static org.junit.Assert.*;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

import studentdetail.components.Student;
import studentdetail.components.StudentDataStore;
import studentdetail.components.StudentNotFoundException;

public class StudentDataStoreTest {
	ArrayList<Student> studentList = new ArrayList<Student>();
	StudentDataStore store = new StudentDataStore();

	@Test
	public void testShouldAddStudent() {
		int beforeAdding;
		int afterAdding;

		Student student = new Student();
		beforeAdding = store.getAllStudentList().size();

		store.addStudent(student);
		afterAdding = store.getAllStudentList().size();

		equals(beforeAdding < afterAdding);
	}

	@Test
	public void testShouldGetAllStudent() {
		int beforeAdding;
		int afterAdding;

		Student student = new Student();
		store.addStudent(student);
		store.addStudent(student);
		beforeAdding = store.getAllStudentList().size();
		afterAdding = store.getAllStudentList().size();

		equals(beforeAdding == afterAdding);
	}

	@Test
	public void testShouldRemoveStudent() {
		int beforeRemoving;

		Student student = new Student();
		student.setId();
		student.setName("Himanshu");
		student.setEmail("himanshulal65@gmail.com");
		store.addStudent(student);
		ArrayList<Student> students=store.getAllStudentList();
		beforeRemoving = students.size();
		System.out.println(beforeRemoving);

		boolean Boolean = store.removeStudent(student.getId().toString());

		assertTrue(Boolean==true);
	}

	@Test(expected = StudentNotFoundException.class)
	public void testRemoveShouldThrowStudentNotFoundExceptionForInvalidId() {
		int beforeRemoving;
		int afterRemoving;

		Student student = new Student();
		student.setId();
		student.setName("Himanshu");
		student.setEmail("himanshulal65@gmail.com");
		store.addStudent(student);
		studentList=store.getAllStudentList();
		beforeRemoving = studentList.size();
		// System.out.println(beforeRemoving);

		store.removeStudent("abc");
		afterRemoving = studentList.size();
		// System.out.println(afterRemoving);

		assertTrue(beforeRemoving > afterRemoving);
	}

	@Test
	public void testShouldSearchStudent() {
		Student student = new Student();
		student.setId();
		student.setName("Himanshu");
		student.setEmail("himanshulal65@gmail.com");
		store.addStudent(student);
		studentList=store.getAllStudentList();
		ArrayList<Student> matchingStudent = store.searchStudent("h");
		assertTrue(studentList.equals(matchingStudent));
	}

	@Test(expected = StudentNotFoundException.class)
	public void testSearchShouldThrowStudentNotFoundExceptionForInvalidSearchKeyword() {
		Student student = new Student();
		student.setId();
		student.setName("Himanshu");
		student.setEmail("himanshulal65@gmail.com");
		studentList.add(student);
		ArrayList<Student> matchingStudent = store.searchStudent("k");
		assertFalse(studentList.equals(matchingStudent));
	}
	
	@Test
	public void testShouldSaveStudent() throws IOException{
		Student student=new Student();
		student.setId();
		student.setName("Himanshu");
		student.setEmail("himanshulal65@gmail.com");
		store.addStudent(student);
		studentList=store.getAllStudentList();
		store.save(studentList);
		File file = new File("src//studentdetail//components//student123456.txt");
		 
		BufferedReader br = new BufferedReader(new FileReader(file));
		String st,content="";
		  while ((st = br.readLine()) != null)
		    content=content+st;
		  
		assertTrue(content!=null);
	}

}
