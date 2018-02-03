package com.techlabs.collections.sort;

import java.util.Comparator;
import com.techlabs.collections.LineItem;

public class SortByNameComparator implements Comparator<LineItem>{

	@Override
	public int compare(LineItem o1, LineItem o2) {
		return o1.getName().compareTo(o2.getName());
	}

}
