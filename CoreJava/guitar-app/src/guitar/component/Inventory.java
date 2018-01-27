package guitar.component;

import java.util.Iterator;
import java.util.LinkedList;

public class Inventory {
	private LinkedList<Guitar> guitars;

	public Inventory() {
		guitars = new LinkedList<Guitar>();
	}

	public void addGuitar(String serialNumber, double price, Builder builder,
			String model, Type type, Wood backWood, Wood topWood){
		Guitar guitar = new Guitar(serialNumber, price, builder, model, type,
				backWood, topWood);
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

	public LinkedList<Guitar> search(Guitar searchGuitar) {
		LinkedList<Guitar> matchingGuitar=new LinkedList<Guitar>();
		for (Iterator<Guitar> i = guitars.iterator(); i.hasNext();) {
			Guitar guitar = (Guitar) i.next();

			if (searchGuitar.getBuilder()!=guitar.getBuilder())
				continue;

			String model = searchGuitar.getModel().toLowerCase();
			if ((model != null) && (!model.equals(""))
					&& (!model.equals(guitar.getModel().toLowerCase())))
				continue;

			
			if (searchGuitar.getType()!=guitar.getType())
				continue;

			
			if (searchGuitar.getBackWood()!=guitar.getBackWood())
				continue;

			
			if (searchGuitar.getTopWood()!=guitar.getTopWood())
				continue;
			matchingGuitar.add(guitar);
		}
		return matchingGuitar;
	}
}