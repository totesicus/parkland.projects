enum Fruits { orange, lemon, cherry }

public class SlotMachine {
	
	private Fruits slot1Value, slot2Value, slot3Value;
	
	public SlotMachine() {
		slot1Value = Fruits.orange;
		slot2Value = Fruits.lemon;
		slot3Value = Fruits.cherry;
	}
	
	void spin() {
		Fruits[] fruits = Fruits.values();
		slot1Value =  fruits[(int)(Math.random() * 3)];
		slot2Value =  fruits[(int)(Math.random() * 3)];
		slot3Value =  fruits[(int)(Math.random() * 3)];
	}
	
	public Fruits getSlot1Value() {
		return slot1Value;
	}
	
	public void setSlot1Value(Fruits slot1Value) {
		this.slot1Value = slot1Value;
	}
	
	public Fruits getSlot2Value() {
		return slot2Value;
	}
	
	public void setSlot2Value(Fruits slot2Value) {
		this.slot2Value = slot2Value;
	}
	
	public Fruits getSlot3Value() {
		return slot3Value;
	}
	
	public void setSlot3Value(Fruits slot3Value) {
		this.slot3Value = slot3Value;
	}
	
	public String toString() {
		return "| " + slot1Value.toString() + " | " + slot2Value.toString() + " | " + slot3Value.toString() + " |";				
	}

}
