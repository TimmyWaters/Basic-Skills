/*

Project 2
CS 2265
Timothy Waters

*/

import java.util.Scanner;

public class P2_Timmy
{
	public static void main(String[] args)
	{
		// Don't be rude. Say hello.
		System.out.println("\nWelcome to Project 2 by Timmy Waters");
		System.out.println("************************************\n");

		// Create the Scanner to accept input
		Scanner sc = new Scanner(System.in);

		// Declare variables to hold our 3 integers
		int num1;
		int num2;
		int num3;

		// Ask for input from the user. Project requirements are to use 7, 3, and 5 in that order.
		System.out.print("Enter the first number: ");
		num1 = sc.nextInt();

		System.out.print("Enter the second number: ");
		num2 = sc.nextInt();

		System.out.print("Enter the third number: ");
		num3 = sc.nextInt();


		// Declare variables for the arithmetic
		int sum = num1 + num2 + num3;
		int average = (num1 + num2 + num3)/3;
		int product = num1 * num2 * num3;


		// Give it some space
		System.out.println("\n");


		// Show the answers
		System.out.println("Sum: " + sum);
		System.out.println("Average: " + average);
		System.out.println("Product: " + product);
		System.out.println("Smallest: " + smaller(num1, num2, num3));
		System.out.println("Largest: " + larger(num1, num2, num3));

		// Give it some space
		System.out.println("\n");
	}

	public static int smaller(int x, int y, int z)
	{
		// Variable to hold our smallest number
		int smallest;
		int temp;

		temp = (x<y) ? x : y;
		smallest = (temp<z) ? temp : z;
		return smallest;
	}

	public static int larger(int x, int y, int z)
	{
		// Variable to hold our largest number
		int largest;
		int temp;

		temp = (x>y) ? x : y;
		largest = (temp>z) ? temp : z;
		return largest;
	}
}