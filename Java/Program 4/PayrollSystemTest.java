/* PayrollSystemTest.java
* 
* Employee hierarchy test program.
* 
* CS 2265
* Project 4
* Timothy Waters
*
*/

import java.util.Scanner;

public class PayrollSystemTest

{

   public static void main( String args[] )

   {
      Scanner sc = new Scanner(System.in); // Create Scanner for input
      Employee[] employees = new Employee[5]; // Our 5 employees

      mainMenu(employees, sc); // Input the data

      // generically process each element in array employees

      clearConsole(); // Clear the screen
      headerBar(); // A nice header for the screen

      for ( Employee currentEmployee : employees )

      {

         System.out.println( currentEmployee ); // invokes toString

 

         // determine whether element is a BasePlusCommissionEmployee

         if ( currentEmployee instanceof BasePlusCommissionEmployee )

         {

            // downcast Employee reference to

            // BasePlusCommissionEmployee reference

            BasePlusCommissionEmployee employee =

               ( BasePlusCommissionEmployee ) currentEmployee;

 

            double oldBaseSalary = employee.getBaseSalary();

            employee.setBaseSalary( 1.10 * oldBaseSalary );

            System.out.printf(

               "new base salary with 10%% increase is: $%,.2f\n",

               employee.getBaseSalary() );

         } // end if

         if(currentEmployee.getBonusMonth() == 11)
         {
            System.out.printf( "earned $%,.2f\n\n", currentEmployee.earnings() * 4 + 100);
         }          
         else
         {
            System.out.printf( "earned $%,.2f\n\n", currentEmployee.earnings() * 4);
         }

      } // end for

 

      // get type name of each object in employees array

      for ( int j = 0; j < employees.length; j++ )

         System.out.printf( "Employee %d is a %s\n", j+1,

            employees[ j ].getClass().getName() );

   } // end main

   // Main interface for input
   public static void mainMenu(Employee[] employees, Scanner sc)
   {
      // Variables
      int workerType = 0;
      String firstName = "";
      String lastName = "";
      String ssn = "";
      int month = 0;
      int day = 0;
      int year = 0;
      double sales = 0;
      double rate = 0;
      double salary = 0;
      double hourlyWage = 0;
      double hoursWorked = 0;
      // End Variables

      for(int x = 0; x < 5; ++x) // Loop to create employees
      {
         clearConsole(); // Clear the screen
         headerBar(); // A nice header for the screen
         System.out.println("Worker " + (x+1));
         System.out.println("**********\n");

         workerType = setWorkerType(sc); // Set the worker type
         System.out.print("Enter First Name: ");
         firstName = sc.next(); // Set First Name
         System.out.print("Enter Last Name: ");
         lastName = sc.next(); // Set Last Name
         System.out.print("Enter SSN: ");
         ssn = sc.next(); // Set SSN
         System.out.print("Enter Birth Month: ");
         month = sc.nextInt(); // Set Birth Month
         System.out.print("Enter Birth Day: ");
         day = sc.nextInt(); // Set Birth Day
         System.out.print("Enter Birth Year: ");
         year = sc.nextInt(); // Set Birth Year

         switch(workerType) // Switch - create info for specific employee types
         {
            case 1: System.out.print("Enter Hourly Wage: ");
                  hourlyWage = sc.nextDouble(); // Set Hourly Wage
                  System.out.print("Enter Hours Worked: ");
                  hoursWorked = sc.nextDouble(); // Set Hours Worked
                  employees[x] = new HourlyEmployee( firstName, lastName, ssn, month, day, year, hourlyWage, hoursWorked ); // Create an Hourly object
               break;

            case 2: System.out.print("Enter Salary: ");
                  salary = sc.nextDouble(); // Set Salary
                  employees[x] = new SalariedEmployee( firstName, lastName, ssn, month, day, year, salary ); // Create Salary object
               break;

            case 3: System.out.print("Enter Sales: ");
                  sales = sc.nextDouble(); // Set Sales
                  System.out.print("Enter Rate: ");
                  rate = sc.nextDouble(); // Set Rate for commission
                  employees[x] = new CommissionEmployee( firstName, lastName, ssn, month, day, year, sales, rate ); // Create commission object
               break;

            case 4: System.out.print("Enter Sales: ");
                  sales = sc.nextDouble(); // Set Sales Total
                  System.out.print("Enter Rate: ");
                  rate = sc.nextDouble(); // Set commission rate
                  System.out.print("Enter Salary: ");
                  salary = sc.nextDouble(); // Set salary
                  employees[x] = new BasePlusCommissionEmployee( firstName, lastName, ssn, month, day, year, sales, rate, salary ); // Create Base plus Commission object
         } // end Switch
      } // end for-loop
   } // end MainMenu()

   // Set the worker type from input
   public static int setWorkerType(Scanner sc)
   {
      int workerType; // hold the selection
      // Menu for Worker type
      System.out.println("Set the worker type:");
      System.out.println("1. Hourly");
      System.out.println("2. Salary");
      System.out.println("3. Comission");
      System.out.println("4. Base Plus Comission");
      System.out.print("\nEnter selection: ");
      workerType = sc.nextInt();

      return workerType;
   } // End setWorkerType

   public static void headerBar() // Make it look nice and organized
   {
      System.out.println("*** Project 4: Employee Information  -  by Timmy Waters ***");
      System.out.println("***********************************************************\n");
   } // End headerBar

   public static void clearConsole() // Clear the console
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

} // end class PayrollSystemTest

 

/**************************************************************************

 * (C) Copyright 1992-2005 by Deitel & Associates, Inc. and               *

 * Pearson Education, Inc. All Rights Reserved.                           *

 *                                                                        *

 * DISCLAIMER: The authors and publisher of this book have used their     *

 * best efforts in preparing the book. These efforts include the          *

 * development, research, and testing of the theories and programs        *

 * to determine their effectiveness. The authors and publisher make       *

 * no warranty of any kind, expressed or implied, with regard to these    *

 * programs or to the documentation contained in these books. The authors *

 * and publisher shall not be liable in any event for incidental or       *

 * consequential damages in connection with, or arising out of, the       *

 * furnishing, performance, or use of these programs.                     *

 *************************************************************************/
