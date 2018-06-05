package test;

import static org.junit.Assert.*;

import org.junit.Test;

import components.Cell;
import components.enums.Mark;
import components.exception.CellAlreadyMarkedException;

public class CellTest {
	Cell cell=new Cell();
	
	@Test
	public void testCellWithNoMarks() {
		assertEquals(cell.getMark(),Mark.EMPTY);
	}
	
	@Test
	public void testCellSetMark() {
		cell.setMark(Mark.O);	
		assertEquals(cell.getMark(),Mark.O);
	}
	
	@Test(expected= CellAlreadyMarkedException.class)
	public void testCellWhichIsAlreadyMarked() {
		cell.setMark(Mark.O);
		cell.setMark(Mark.X);
	}
	
	

}
