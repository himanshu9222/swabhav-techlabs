package studentdetail.components;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.util.ArrayList;

public class StudentDeserializer {
	private String path = "src//studentdetail//components//";

	@SuppressWarnings("unchecked")
	public ArrayList<Student> deserializeObject() throws IOException,
			ClassNotFoundException {
		File file = new File(path + "student123456.txt");
		FileInputStream fileinputStream = new FileInputStream(file);
		ObjectInputStream objectOutputStream = new ObjectInputStream(
				fileinputStream);
		ArrayList<Student> studentList = (ArrayList<Student>) objectOutputStream
				.readObject();
		objectOutputStream.close();
		fileinputStream.close();
		return studentList;
	}
}
