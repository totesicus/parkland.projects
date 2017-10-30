
public class Flight {
	
	private String airline, origin, destination;
	private int flightNumber;
	
	public Flight(String airline, int flightNumber, String origin, String destination)
	{
		this.airline = airline;
		this.flightNumber = flightNumber;
		this.origin = origin;
		this.destination = destination;
	}
	
	public String getAirline()
	{
		return airline;
	}
	
	public int getFlightNumber()
	{
		return flightNumber;
	}
	
	public String getOrigin()
	{
		return origin;
	}
	
	public String getDestination()
	{
		return destination;
	}
	
	public void setAirline(String airline)
	{
		this.airline = airline;
	}
	
	public void setFlightNumber(int flightNumber)
	{
		this.flightNumber = flightNumber;
	}
	
	public void setOrigin(String origin)
	{
		this.origin = origin;
	}
	
	public void setDestination(String destination)
	{
		this.destination = destination;
	}
	
	public String toString()
	{
		return airline + " #" + flightNumber + " -- From: " + origin + ", To: " + destination;
	}
	

}
