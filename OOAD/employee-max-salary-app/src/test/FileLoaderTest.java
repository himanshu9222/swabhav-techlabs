package test;

import static org.junit.Assert.*;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

import loader.FileLoader;
import loader.ILoadable;

import org.junit.Test;

public class FileLoaderTest {

	@Test
	public void testLoadFile() throws IOException {
		ILoadable load = new FileLoader();
		String str=load.loadFile();
		
		FileReader fileReader = new FileReader("src//components//" + "dataFile.txt");
		@SuppressWarnings("resource")
		BufferedReader bufferedReader = new BufferedReader(fileReader);
		String currentLine = "";
		String finalString = "";

		while ((currentLine = bufferedReader.readLine()) != null) {
			finalString = finalString + currentLine + "/";
		}
		
		assertEquals(finalString,str);
	}

}
