package components;

import components.enums.Mark;
import components.exception.OutOfBoardException;

public class ThreeDBoard implements IBoard{
	private Cell[][] cell = new Cell[3][3];

	public ThreeDBoard() {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				cell[i][j] = new Cell();
			}
		}
	}

	@Override
	public Cell[][] getAllCell() {
		return cell;
	}

	@Override
	public void setCell(int x, int y, Mark mark) {
		if (x > 2 || x < 0 || y > 2 || y < 0) {
			throw new OutOfBoardException();
		}
		cell[x][y].setMark(mark);
	}

	@Override
	public Mark getCell(int x, int y) {
		if (x > 2 || x < 0 || y > 2 || y < 0) {
			throw new OutOfBoardException();
		}
		return cell[x][y].getMark();
	}
	
	@Override
	public Boolean isFull() {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				if (cell[i][j].getMark() == Mark.EMPTY) {
					return false;
				}
			}
		}
		return true;
	}
}
