package components.exception;

@SuppressWarnings("serial")
public class OutOfBoardException extends RuntimeException{

	@Override
	public String toString(){
		return "Enter Proper Co-Ordinates";
	}
	
}
