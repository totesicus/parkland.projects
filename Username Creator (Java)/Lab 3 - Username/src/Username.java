
import java.util.Random;
import java.util.Scanner;

public class Username {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String firstName;
		String lastName;
		
		Scanner scan = new Scanner(System.in);
		
		System.out.print("Enter your first name: ");
		firstName = scan.nextLine();
		
		System.out.print("Enter your last name: ");
		lastName = scan.nextLine();
		
		
		Random generator = new Random();
		int num1;
		
		num1 = generator.nextInt(90) + 10;
		
		// I know the lab instructions said to assume that the last name is at least 5 letters long, but I
		// just couldn't help myself.
		
		if (lastName.length() >= 5)
		System.out.println("Your username is " + firstName.charAt(0) + lastName.substring(0, 5) + num1);
		else
		System.out.println("Your username is " + firstName.charAt(0) + lastName + num1);
		

	}

}
