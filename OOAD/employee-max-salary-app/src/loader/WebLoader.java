package loader;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;

public class WebLoader implements ILoadable{
	URL urlReader;
	BufferedReader bufferedReader;
	
	@Override
	public String loadFile() throws IOException {
		urlReader=new URL("https://swabhav-tech.firebaseapp.com/emp.txt");
		bufferedReader = new BufferedReader(new InputStreamReader(urlReader.openStream()));
		String currentLine = "";
		String finalString = "";

		while ((currentLine = bufferedReader.readLine()) != null) {
			finalString = finalString + currentLine + "/";
		}
		//System.out.println(finalString);
		return finalString;
	}

}
