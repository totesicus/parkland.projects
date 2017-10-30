
public class FlightTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Flight flight1 = new Flight("Delta", 143, "Los Anegeles", "Denver");
		Flight flight2 = new Flight("Jet Blue", 265, "Miami", "Birmingham");
		Flight flight3 = new Flight("US Airways", 336, "Seattle", "Chicago");
		Flight flight4 = new Flight("Korean Air", 798, "New York", "London");
		Flight flight5 = new Flight("Delta", 679, "Portland", "Pittsburgh");
		
		System.out.println(flight1);
		System.out.println(flight2);
		System.out.println(flight3);
		System.out.println(flight4);
		System.out.println(flight5);
		
		System.out.println();
		
		System.out.print(flight1 + "\t Old Flight Number: #" + flight1.getFlightNumber());
		flight1.setFlightNumber(133);
		System.out.println("\t New Flight Number: #" + flight1.getFlightNumber());
		
		System.out.print(flight5 + "\t Old Destination: " + flight5.getDestination());
		flight5.setDestination("Cleveland");
		System.out.println("\t New Destination: " + flight5.getDestination());

	}

}
