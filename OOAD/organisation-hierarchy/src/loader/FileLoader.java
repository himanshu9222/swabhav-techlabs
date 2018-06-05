package loader;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class FileLoader implements ILoadable {

	private final String path = "src//components//";
	private FileReader fileReader;
	private BufferedReader bufferedReader;

	@Override
	public String loadFile() throws IOException {
		fileReader = new FileReader(path + "dataFile.txt");
		bufferedReader = new BufferedReader(fileReader);
		String currentLine = "";
		String finalString = "";

		while ((currentLine = bufferedReader.readLine()) != null) {
			finalString = finalString + currentLine + "/";
		}
		return finalString;
	}

}
