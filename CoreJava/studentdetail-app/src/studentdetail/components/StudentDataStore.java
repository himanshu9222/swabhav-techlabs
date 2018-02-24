package studentdetail.components;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;

public class StudentDataStore {

	ArrayList<Student> studentList = new ArrayList<Student>();
	StudentSerializer serialize = new StudentSerializer();
	StudentDeserializer deserialize = new StudentDeserializer();
	
	public void load() throws ClassNotFoundException, IOException{
		studentList=deserialize.deserializeObject();
	}

	public void addStudent(Student studentlist) {
		studentList.add(studentlist);
	}

	public ArrayList<Student> getAllStudentList() {
		return studentList;
	}

	public void save(ArrayList<Student> studentList) throws IOException {
		serialize.serializeObject(studentList);
	}

	public ArrayList<Student> searchStudent(String keyword) {
		ArrayList<Student> matchingStudent=new ArrayList<Student>();
		for (Iterator<Student> i = studentList.iterator(); i.hasNext();) {
			Student student = (Student) i.next();
			if (student.getName().toLowerCase().startsWith(keyword.toLowerCase())) {
				matchingStudent.add(student);
			}
		}
		if(matchingStudent.isEmpty()){
			throw new StudentNotFoundException("No Such Student Found with starting letter  "+keyword);
		}
		else{
			return matchingStudent;
		}
	}
	

	public boolean removeStudent(String id) {
		for (int i = 0; i < studentList.size(); i++) {
			Student student = studentList.get(i);
			if (student.getId().toString().equals(id)) {
				studentList.remove(student);
				// i--;
				return true;
			}
		}
		throw new StudentNotFoundException("No Such Student Present in the List with Id  "+id);
	}

}
