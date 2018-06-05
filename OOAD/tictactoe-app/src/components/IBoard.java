package components;

import components.enums.Mark;

public interface IBoard {
	Boolean isFull() ;
	Mark getCell(int x, int y);
	void setCell(int x, int y, Mark mark);
	Cell[][] getAllCell();
}
