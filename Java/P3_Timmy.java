/*
CS 2265
Project 3
Timothy Waters
*/

import java.util.Scanner;
import java.text.NumberFormat;
import java.util.Locale; 

class Products
{
	Scanner sc = new Scanner(System.in);
	int productNum, quantity; // Stores the product number and quantity
	double lineItemTotal = 0, orderTotal = 0; // Initialize variables to store totals
	NumberFormat dollars = NumberFormat.getCurrencyInstance( Locale.US ); // We're using US dollars
	StringBuilder outputLine = new StringBuilder();

	public void inputData()
	{
		clearConsole();
		headerBar();

		do
		{
			productNum = userInput("Enter the product number(1-5 or -1 to quit): "); // Get the product number from the user

			if((productNum != -1) && (productNum >=1) && (productNum <= 5))
			{
				quantityTotal();
				clearConsole();
				headerBar();
				outputLine.append(productNum + "\t\t" + quantity + "\t\t" + dollars.format(lineItemTotal) + "\t\t" + dollars.format(orderTotal) + "\n");
				System.out.println(outputLine);
			}
		}while(productNum != -1);
		goodBye();
	}

	private void quantityTotal()
	{
		quantity = userInput("Enter the quantity(1-5 or -1 to quit): ");
		if((quantity != -1) && (quantity >=1) && (quantity <= 5))
		{
			switch (productNum)
			{
				case 1: lineItemTotal = quantity * 2.98;
				break;

				case 2: lineItemTotal = quantity * 4.50;
				break;

				case 3: lineItemTotal = quantity * 9.98;
				break;

				case 4: lineItemTotal = quantity * 4.49;
				break;

				case 5: lineItemTotal = quantity * 6.87;
				break;

				default: System.out.println("You should never see this message.");
				break;
			} // End switch

			orderTotal += lineItemTotal; // Keep the running total
		}
		else if(quantity == -1)
		{
			goodBye();
		}
		else
		{
			quantityTotal();
		}
	}

	private void goodBye()
	{
		System.out.println("The order total is: " + dollars.format(orderTotal) + "\n\n");
		System.exit(0);
	}

	private int userInput(String str) // Get the input from the user in a less messy way
	{
		System.out.print(str);
		return sc.nextInt();
	}

	private void headerBar() // Make it look nice and organized
	{
		System.out.println("*** Project 3: Product Information  -  by Timmy Waters ***\n");
		System.out.println("Product\t\tQuantity\tLine Total\tOrder Total"); // It wants the extra \t to display properly for some reason
		System.out.println("***********************************************************");
	} // End headerBar

	private void clearConsole() // Clear the console
	{
    	try 
    	{
      		final String os = System.getProperty("os.name"); // What OS are you running?
      		if (os.contains("Windows")) 
      		{
      			Runtime.getRuntime().exec("cls"); // Clear the DOS terminal
      		} 
      		else 
      		{
          		System.out.println("\033[H\033[2J"); // Any UNIX-based OS, clear the terminal
      		}
    	} 
    	catch (final Exception e) 
    	{
        	System.out.println("something went wrong :("); // This shouldn't happen
    	}
  	} // End clearConsole
}

public class P3_Timmy
{
	public static void main(String[] args) 
	{
		Products pr = new Products(); // Create an object
		pr.inputData(); // Calling the method to get things done
	} // End main function
} // End main class