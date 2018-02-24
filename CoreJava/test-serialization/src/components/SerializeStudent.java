package components;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class SerializeStudent {
	private String path="src//components//";
	public void serializeObject(ArrayList<Student> studentList) throws IOException{
		
		File file=new File(path+"student12345.txt");
		FileOutputStream fileOutputStream=new FileOutputStream(file);
		ObjectOutputStream objectOutputStream=new ObjectOutputStream(fileOutputStream);
		objectOutputStream.writeObject(studentList);
		objectOutputStream.close();
		fileOutputStream.close();
		System.out.println("Object has been serailized");
	}
	
	@SuppressWarnings("unchecked")
	public ArrayList<Student> deserializeObject() throws IOException, ClassNotFoundException{
		File file=new File(path+"student12345.txt");
		FileInputStream fileinputStream=new FileInputStream(file);
		ObjectInputStream objectOutputStream=new ObjectInputStream(fileinputStream);
		ArrayList<Student> studentList= (ArrayList<Student>) objectOutputStream.readObject();
		objectOutputStream.close();
		fileinputStream.close();
		System.out.println("Object has been deserailized");
		return studentList;
	}
}
