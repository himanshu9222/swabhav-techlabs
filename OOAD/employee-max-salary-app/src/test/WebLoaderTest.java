package test;

import static org.junit.Assert.*;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;

import loader.ILoadable;
import loader.WebLoader;

import org.junit.Test;

public class WebLoaderTest {

	@Test
	public void testLoadFile() throws IOException {
		ILoadable load = new WebLoader();
		String str=load.loadFile();
		
		URL urlReader=new URL("https://swabhav-tech.firebaseapp.com/emp.txt");
		BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(urlReader.openStream()));
		String currentLine = "";
		String finalString = "";

		while ((currentLine = bufferedReader.readLine()) != null) {
			finalString = finalString + currentLine + "/";
		}
		
		assertEquals(finalString,str);
	}
}
