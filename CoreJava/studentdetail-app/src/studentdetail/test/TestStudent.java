package studentdetail.test;

import java.io.IOException;

import studentdetail.components.StudentConsole;

public class TestStudent {

	public static void main(String[] args) throws IOException,
			NullPointerException, ClassNotFoundException {
		StudentConsole s = new StudentConsole();
		s.menu();
	}
}
