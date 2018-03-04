enum Fruits { orange, lemon, cherry }

public class Slot {
	
	private Fruits slotValue;
	
	public Slot() {
		slotValue = Fruits.orange;		
	}
	
	public Fruits spin() {
		Fruits[] fruits = Fruits.values();
		slotValue =  fruits[(int)(Math.random() * 3)];
		
		return slotValue;		
	}
	
	public Fruits setSlotValue(Fruits value) {
		slotValue = value;
		
		return value;
	}
	
	public Fruits getSlotValue(Fruits value) {
		return value;
	}
	
	public String toString() {
		String result;
		
		if (slotValue == Fruits.orange)
			result = "The fruit in slot one is: orange";
		else if (slotValue == Fruits.lemon)
			result = "The fruit in slot one is: lemon";
		else
			result = "The fruit in slot one is: cherry";			
		
		return result;					
	}

}
