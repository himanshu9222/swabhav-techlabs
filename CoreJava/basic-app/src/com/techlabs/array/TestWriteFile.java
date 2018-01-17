package com.techlabs.array;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;

public class TestWriteFile {

	public static void main(String[] args) {
		try {
			FileWriter file = new FileWriter("hello.txt");
			//we can code it without BufferWriter but we use it for more efficiency because it chain the FileWriter to a BufferedWriter
			BufferedWriter f1=new BufferedWriter(file);
			f1.write("Hello World");
			f1.write("-------");
			f1.write("This is Himanshu");
			// file.write(5);
			f1.close();
		} catch (Exception ex) {
			ex.printStackTrace();
		}

		try {
			File file = new File("hello.txt");
			FileReader f1 = new FileReader(file);

			@SuppressWarnings("resource")
			BufferedReader br = new BufferedReader(f1);

			String read = null;
			while ((read = br.readLine()) != null) {
				System.out.println(read);

			}
		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

}
