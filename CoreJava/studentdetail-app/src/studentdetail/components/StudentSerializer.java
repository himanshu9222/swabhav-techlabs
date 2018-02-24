package studentdetail.components;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class StudentSerializer {
	private String path = "src//studentdetail//components//";

	public void serializeObject(ArrayList<Student> studentList)
			throws IOException {

		File file = new File(path + "student123456.txt");
		FileOutputStream fileOutputStream = new FileOutputStream(file);
		ObjectOutputStream objectOutputStream = new ObjectOutputStream(
				fileOutputStream);
		objectOutputStream.writeObject(studentList);
		objectOutputStream.close();
		fileOutputStream.close();
		System.out.println("Object has been serailized");
	}

}
