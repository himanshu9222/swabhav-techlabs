package components;

import components.enums.Mark;
import components.exception.CellAlreadyMarkedException;

public class Cell {
	private Mark mark;

	public Cell() {
		mark = Mark.EMPTY;
	}

	public Mark getMark() {
		return mark;
	}

	@SuppressWarnings("static-access")
	public void setMark(Mark mark) {
		if (this.mark != this.mark.EMPTY) {
			throw new CellAlreadyMarkedException();
		}
		this.mark = mark;
	}

	@Override
	public String toString() {
		return this.mark.toString();
	}
}
