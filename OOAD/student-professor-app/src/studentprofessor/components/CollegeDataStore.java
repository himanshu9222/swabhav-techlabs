package studentprofessor.components;

import java.util.ArrayList;

public class CollegeDataStore {
	ArrayList<Student> studentlist=new ArrayList<Student>();
	ArrayList<Professor> professorlist=new ArrayList<Professor>();
	
	public void addStudent(Student student){
		studentlist.add(student);
	}
	
	public ArrayList<Student> getAllStudent(){
		return studentlist;
	}
	
	public void addProfessor(Professor professor){
		professorlist.add(professor);
	}
	
	public ArrayList<Professor> getAllProfessor(){
		return professorlist;
	}
	
}
