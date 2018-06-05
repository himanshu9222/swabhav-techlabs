package parser;

import java.io.IOException;
import java.util.HashSet;

import components.Employee;

public interface IParsable {
	public HashSet<Employee> parse() throws IOException;
}
