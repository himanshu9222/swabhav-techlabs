package studentdetail.components;

//import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

public class SerializeStudent {
	public void serializeObject(ArrayList<Student> studentList) throws IOException{
		//File f=new File("student.txt");
		FileOutputStream fos=new FileOutputStream("student.txt");
		ObjectOutputStream oos=new ObjectOutputStream(fos);
		oos.writeObject(studentList);
		oos.close();
		
	}
	
	@SuppressWarnings("unchecked")
	public void deserializeObject(ArrayList<Student> studentList) throws IOException, ClassNotFoundException{
		FileInputStream fis=new FileInputStream("student.txt");
		ObjectInputStream ois=new ObjectInputStream(fis);
		studentList= (ArrayList<Student>) ois.readObject();
		ois.close();
	}
	

}
