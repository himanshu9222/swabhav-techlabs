package test;

import static org.junit.Assert.*;

import org.junit.Test;

import components.ThreeDBoard;
import components.Player;
import components.enums.Mark;
import components.exception.OutOfBoardException;

public class BoardTest {

	Player p=new Player("Hiamsnhu", Mark.O);
	ThreeDBoard board=new ThreeDBoard();
	
	@Test
	public void testSetMark() {	
		board.setCell(0, 0, Mark.O);
		assertEquals(board.getCell(0,0),Mark.O);
	}

	@Test(expected=OutOfBoardException.class)
	public void checkException(){
		board.setCell(5, 5, Mark.X);
	}
	
	@Test
	public void testBoardIsFull() {	
		board.setCell(0, 0, Mark.O);
		board.setCell(0, 1, Mark.O);
		board.setCell(0, 2, Mark.O);
		board.setCell(1, 0, Mark.O);
		board.setCell(1, 1, Mark.O);
		board.setCell(1, 2, Mark.O);
		board.setCell(2, 0, Mark.O);
		board.setCell(2, 1, Mark.O);
		board.setCell(2, 2, Mark.O);
		
		equals(board.isFull());
	}
	
	@Test
	public void testBoardIsNotFull() {	
		board.setCell(0, 0, Mark.O);
		board.setCell(0, 1, Mark.O);
		board.setCell(0, 2, Mark.O);
		board.setCell(1, 0, Mark.O);
		board.setCell(1, 1, Mark.O);
		board.setCell(1, 2, Mark.O);
		board.setCell(2, 0, Mark.O);
		board.setCell(2, 1, Mark.O);
		
		assertEquals(board.isFull(),false);
	}
}
