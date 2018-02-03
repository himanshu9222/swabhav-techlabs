package guitar.component;

import guitar.component.test.GuitarSpec;

import java.util.Iterator;
import java.util.LinkedList;

public class Inventory {
	private LinkedList<Guitar> guitars;

	public Inventory() {
		guitars = new LinkedList<Guitar>();
	}

	public void addGuitar(String serialNumber, double price, Builder builder,
			String model, Type type,int numStrings, Wood backWood, Wood topWood){
		GuitarSpec spec=new GuitarSpec(builder, model, type, numStrings, backWood, topWood);
		Guitar guitar = new Guitar(serialNumber, price, spec);
		guitars.add(guitar);
	}

	public Guitar getGuitar(String serialNumber) {
		for (Iterator<Guitar> i = guitars.iterator(); i.hasNext();) {
			Guitar guitar = (Guitar) i.next();
			if (guitar.getSerailNumber().equalsIgnoreCase(serialNumber)) {
				return guitar;
			}
		}
		return null;
	}

	public LinkedList<Guitar> search(GuitarSpec searchSpec) {
		
		LinkedList<Guitar> matchingGuitar=new LinkedList<Guitar>();
		for (Iterator<Guitar> i = guitars.iterator(); i.hasNext();) {
			Guitar guitar = (Guitar) i.next();
			//GuitarSpec guitarSpec=guitar.getSpec();
			if (guitar.getSpec().matches(searchSpec))
				matchingGuitar.add(guitar);
		}
		return matchingGuitar;
	}
}