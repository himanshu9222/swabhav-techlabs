package components.exception;

@SuppressWarnings("serial")
public class CellAlreadyMarkedException extends RuntimeException{

	@Override
	public String toString(){
		return "Cell is already marked";
	}
}
