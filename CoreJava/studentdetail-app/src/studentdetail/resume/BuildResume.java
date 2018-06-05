package studentdetail.resume;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

import studentdetail.components.Student;

public class BuildResume {
	private final String path = "src//studentdetail//resume//";
	FileReader fileReader;
	BufferedReader bufferedReader;

	public void buildResume(ArrayList<Student> studentList) throws IOException {
		for (Student studentDetails : studentList) {
			fileReader = new FileReader(path + "index.html");
			bufferedReader = new BufferedReader(fileReader);
			String currentLine = "";
			String resumeHtml = "";

			while ((currentLine = bufferedReader.readLine()) != null) {
				resumeHtml += currentLine;
			}

			resumeHtml = resumeHtml.replace("$name", studentDetails.getName());
			resumeHtml = resumeHtml.replace("$id", studentDetails.getId()
					.toString());
			resumeHtml = resumeHtml
					.replace("$email", studentDetails.getEmail());

			String fileName = studentDetails.getName() + ".html";
			FileWriter fileWriter = new FileWriter(path + fileName);
			fileWriter.write(resumeHtml);
			fileWriter.close();
			bufferedReader.close();

		}
	}
}
