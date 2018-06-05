package components;

import components.enums.Mark;
import components.exception.OutOfBoardException;

public class FourDBoard implements IBoard{
	
	private Cell[][] cell = new Cell[4][4];
	
	public FourDBoard() {
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				cell[i][j] = new Cell();
			}
		}
	}

	@Override
	public Boolean isFull() {
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				if (cell[i][j].getMark() == Mark.EMPTY) {
					return false;
				}
			}
		}
		return true;
	}

	@Override
	public Mark getCell(int x, int y) {
		if (x > 3 || x < 0 || y > 3 || y < 0) {
			throw new OutOfBoardException();
		}
		return cell[x][y].getMark();
	}

	@Override
	public void setCell(int x, int y, Mark mark) {
		if (x > 3 || x < 0 || y > 3 || y < 0) {
			throw new OutOfBoardException();
		}
		cell[x][y].setMark(mark);
	}

	@Override
	public Cell[][] getAllCell() {
		return cell;
	}

}
