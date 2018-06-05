package test;

import static org.junit.Assert.*;

import org.junit.Test;

import components.IBoard;
import components.IResultAnalyser;
import components.ThreeDBoard;
import components.ThreeDResultAnalyser;
import components.enums.Mark;
import components.enums.Result;

public class ThreeDResultAnalyserTest {
	IBoard board =new ThreeDBoard();
	IResultAnalyser ra=new ThreeDResultAnalyser(board);
	
	@Test
	public void testWin() {
		board.setCell(0, 0, Mark.O);
		board.setCell(0, 1, Mark.O);
		board.setCell(0, 2, Mark.O);
		
		assertEquals(ra.analyse(), Result.WIN);
	}
	
	@Test
	public void testTie() {
		board.setCell(0, 0, Mark.O);
		board.setCell(0, 1, Mark.X);
		board.setCell(0, 2, Mark.O);
		board.setCell(1, 0, Mark.X);
		board.setCell(1, 1, Mark.O);
		board.setCell(1, 2, Mark.X);
		board.setCell(2, 0, Mark.O);
		board.setCell(2, 1, Mark.X);
		board.setCell(2, 2, Mark.O);
		
		assertEquals(board.isFull(), true);
	}

}
