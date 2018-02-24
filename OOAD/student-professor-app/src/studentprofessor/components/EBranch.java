package studentprofessor.components;

public enum EBranch {
	Computer, IT, Electronic, Civil, Mehanical, Instrumentation;

	public String toString() {
		switch (this) {
		case Computer:
			return "Computer";
		case IT:
			return "IT";
		case Electronic:
			return "Electronic";
		case Civil:
			return "Civil";
		case Mehanical:
			return "Mechanical";
		case Instrumentation:
			return "Instrumentation";
		default:
			return null;
		}
	}
}
