/*
 * Timothy Waters
 * CS 3330: Data Structures and Algorithms
 * Project 2
 * T3 / 2018
 *
 * References:
 * - http://www.cplusplus.com/reference/
 * - Provided sample source code
 */

#include <iostream>
#include <cstdlib>
#include <ctime>
#include <string>
#include <list>
#include <fstream>
#include "CruiseReserve.h"

using namespace std;

// Prototypes
void header();
void menu();
void enterReservation();
void displayReservations();
void searchForReservation();
void editReservation();
void deleteReservation();
int randomNumber(int maxNumber);
char getCharByNumber(int number);
string generateLocaterID(int lengthOfString);
string displayLengthOfCruise(int length);
void saveData();
void loadData();
// End Prototypes

// Declare global reservation list
list <CruiseReserve> reserveList;

// Random Number Generator constants
const int START_ASCII_LETTERS=65;
const int NUM_LETTERS=26;

// Main
int main()
{
    loadData();
    // Main menu interface
    menu();
    
    return 0;
} // End Main

// Header for the program
void header()
{
    cout << "\n**    CruiseLine Reservation System  -  by: Timothy Waters    **" << endl;
    cout << "****************************************************************" << endl;
} // End Header

/*
 * Get a random number between 1 and maxNumber
 * From RandomString.cpp in Sample Code
 */
int randomNumber(int maxNumber)
{
    return (rand() % maxNumber + 1);
} // End randomNumber

/*
 * Convert a given number between 1 and 26 to the equivolent character.
 * For example, 1 is A, 2 is B, etc.
 * From RandomString.cpp in Sample Code
 */
char getCharByNumber(int number)
{
    return number+START_ASCII_LETTERS-1;
} // End getCharByNumber

/*
 * Generate a random string of specified length lengthOfString.
 * From RandomString.cpp in Sample Code
 */
string generateLocaterID(int lengthOfString)
{
    string randomString = "";
    
    for (int i=0; i < lengthOfString; i++)
    {
        randomString +=  getCharByNumber(randomNumber(NUM_LETTERS));
    }
    
    return randomString;
} // End generateLocaterID

// Enter Reservation - enters a new reservation
void enterReservation()
{
    CruiseReserve cruiseReserve;
    string userInput;
    bool correct = false;
    int month;
    int nights;
    int zip;
    
    // Locater ID
    srand(time(NULL));
    cruiseReserve.setLocaterID(generateLocaterID(6));
    // End Locater
    
    cout << "\n**  Enter a reservation  **" << endl;
    cout << "Locater ID: " + cruiseReserve.getLocaterID() << endl;
    
    // Departure Month entry
    while(!correct)
    {
        cout << "\nDeparture Month (1 - 12): ";
        getline(cin, userInput, '\n');
        month = atoi(userInput.c_str());
        if (month >= 1 && month <= 12)
        {
            cruiseReserve.setDepartureMonth(month);
            correct = true;
        }
    } // End Departure Month entry
    
    correct = false; // Reset 'correct' to false
    
    // Length of Cruise entry
    while(!correct)
    {
        cout << "\nLength of Cruise:" << endl;
        cout << "\t1. \t1 to 2 nights" << endl;
        cout << "\t2. \t3 to 5 nights" << endl;
        cout << "\t3. \t6 to 9 nights" << endl;
        cout << "\t4. \t10 to 15 nights" << endl;
        cout << "\nEnter length of cruise: ";
        getline(cin, userInput, '\n');
        nights = atoi(userInput.c_str());
        if (nights >= 1 && nights <= 4)
        {
            cruiseReserve.setLengthOfCruise(nights);
            correct = true;
        } // End If
    } // End Length of Cruise Entry
    
    // Number of Guests
    cout << "\nNumber of guests: ";
    getline(cin, userInput, '\n');
    cruiseReserve.setNumberOfGuests(atoi(userInput.c_str()));
    // End Number of Guests
    
    // First Name
    cout << "\nFirst Name: ";
    getline(cin, userInput, '\n');
    cruiseReserve.setFirstName(userInput);
    // End First Name
    
    // Last Name
    cout << "\nLast Name: ";
    getline(cin, userInput, '\n');
    cruiseReserve.setLastName(userInput);
    // End Last Name
    
    // Billing Address
    cout << "\nBilling Address: ";
    getline(cin, userInput, '\n');
    cruiseReserve.setBillingAddress(userInput);
    // End Billing Address
    
    // ZIP Code
    correct = false; // Reset 'correct' to false
    while(!correct)
    {
        cout << "\nZIP Code: ";
        getline(cin, userInput, '\n');
        if(atoi(userInput.c_str()) >= 10000 && atoi(userInput.c_str()) <= 99999)
        {
            cruiseReserve.setZipCode(atoi(userInput.c_str()));
            correct = true;
        }
    }
    // End ZIP Code
    
    // Add information to linked list
    reserveList.push_back(cruiseReserve);
    
    cout << "\n\n****\tReservation entered.\t****" << endl;
    cout << "Press ENTER key to go back to the main menu." << endl;
    getchar();
} // End enterReservation

// Display Reservations - displays all reservations for the linked list
void displayReservations()
{
    list <CruiseReserve>::iterator cruiseReserve;
    for (cruiseReserve = reserveList.begin(); cruiseReserve != reserveList.end(); ++cruiseReserve)
    {
        cout << "**************************" << endl;
        cout << "LocaterID:  " << cruiseReserve->getLocaterID() << endl;
        cout << "Departure Month:  " << cruiseReserve->getDepartureMonth() << endl;
        cout << "Length of Cruise:  " << displayLengthOfCruise(cruiseReserve->getLengthOfCruise()) << endl;
        cout << "Number of Guests:  " << cruiseReserve->getNumberOfGuests() << endl;
        cout << "First Name:  " << cruiseReserve->getFirstName() << endl;
        cout << "Last Name:  " << cruiseReserve->getLastName() << endl;
        cout << "Billing Address:  " << cruiseReserve->getBillingAddress() << endl;
        cout << "ZIP Code:  " << cruiseReserve->getZipCode() << endl;
        cout << "**************************" << endl;
    }
    
    cout << "\n\n****\tEnd of Reservation List.\t****" << endl;
    cout << "Press ENTER key to go back to the main menu." << endl;
    getchar();
} // End displayReservations

// Save Data - called on exit
void saveData()
{
    ofstream resData("reservation.dat", ios::out);
    list <CruiseReserve>::iterator cruiseReserve;
    if(resData.is_open())
    {
        for (cruiseReserve = reserveList.begin(); cruiseReserve != reserveList.end(); ++cruiseReserve)
        {
            resData << cruiseReserve->getLocaterID() << endl;
            resData << cruiseReserve->getDepartureMonth() << endl;
            resData << cruiseReserve->getLengthOfCruise() << endl;
            resData << cruiseReserve->getNumberOfGuests() << endl;
            resData << cruiseReserve->getFirstName() << endl;
            resData << cruiseReserve->getLastName() << endl;
            resData << cruiseReserve->getBillingAddress() << endl;
            resData << cruiseReserve->getZipCode() << endl;
        }
        resData.close();
    }
    else
    {
        cout << "Unable to open file" << endl;
    }
} // End saveData

// Load data
void loadData()
{
    CruiseReserve cruiseReserve;
    string line;
    int tempInt;
    int arraySize = 8;
    string resArray[8];
    int count = 0;
    ifstream resData("reservation.dat", ios::in);
    if(resData.is_open())
    {
        while(getline(resData, line)) // Get input from the file
        {
            resArray[count] = line; // Store the input from the file
            count++;
            
            // Populate the list
            if(count == arraySize)
            {
                cruiseReserve.setLocaterID(resArray[0]);
                tempInt = atoi(resArray[1].c_str());
                cruiseReserve.setDepartureMonth(tempInt);
                tempInt = atoi(resArray[2].c_str());
                cruiseReserve.setLengthOfCruise(tempInt);
                tempInt = atoi(resArray[3].c_str());
                cruiseReserve.setNumberOfGuests(tempInt);
                cruiseReserve.setFirstName(resArray[4]);
                cruiseReserve.setLastName(resArray[5]);
                cruiseReserve.setBillingAddress(resArray[6]);
                tempInt = atoi(resArray[7].c_str());
                cruiseReserve.setZipCode(tempInt);
                reserveList.push_back(cruiseReserve);
                
                count = 0;
            } // End if
        } // End While loop
        resData.close(); // Close the file
    } // End if
} // End loadData

// Display the length of the cruise as a string
string displayLengthOfCruise(int length)
{
    switch(length)
    {
        case 1:
            return "1 = (1 to 2 nights)";
            break;
        case 2:
            return "2 = (3 to 5 nights)";
            break;
        case 3:
            return "3 = (6 to 9 nights)";
            break;
        case 4:
            return "4 = (10 to 15 nights)";
            break;
        default:
            return "Error: You should never see this.";
            break;
    } // End switch
} // End displayLengthOfCruise

// Search For Reservation - allows user to find a reservation by the locater ID
void searchForReservation()
{
    string searchString;
    bool match = false;
    string userInput;
    cout << "**  Search for Reservation  **" << endl;
    cout << "Enter Locater ID: ";
    getline(cin, searchString, '\n');
    list <CruiseReserve>::iterator cruiseReserve;
    for (cruiseReserve = reserveList.begin(); cruiseReserve != reserveList.end(); ++cruiseReserve)
    {
        if(searchString == cruiseReserve->getLocaterID())
        {
            cout << "\n\nYour reservation was found:\n" << endl;
            cout << "**************************" << endl;
            cout << "LocaterID:  " << cruiseReserve->getLocaterID() << endl;
            cout << "Departure Month:  " << cruiseReserve->getDepartureMonth() << endl;
            cout << "Length of Cruise:  " << displayLengthOfCruise(cruiseReserve->getLengthOfCruise()) << endl;
            cout << "Number of Guests:  " << cruiseReserve->getNumberOfGuests() << endl;
            cout << "First Name:  " << cruiseReserve->getFirstName() << endl;
            cout << "Last Name:  " << cruiseReserve->getLastName() << endl;
            cout << "Billing Address:  " << cruiseReserve->getBillingAddress() << endl;
            cout << "ZIP Code:  " << cruiseReserve->getZipCode() << endl;
            cout << "**************************" << endl;
            match = true;
            cout << "\n\n****\tReservation Found.\t****" << endl;
            cout << "Press ENTER key to go back to the main menu." << endl;
            getchar();
            break;
        }
    }
    if(!match)
    {
        cout << "No match found!" << endl;
        cout << "\t1. Search again" << endl;
        cout << "\t2. Main Menu" << endl;
        cout << "Option: ";
        getline(cin, userInput, '\n');
        
        switch(atoi(userInput.c_str()))
        {
            case 1:
                searchForReservation();
                break;
                
            case 2:
                break;
                
            default:
                break;
        }
        
    }
} // End searchForReservation

// Edit Reservation - allows the user to edit the fields for a given reservation
void editReservation()
{
    cout <<"Edit Reservation function goes here." << endl;
    string searchString;
    bool match = false;
    bool correct = false;
    string userInput;
    int month;
    int nights;
    
    cout << "**  Edit Reservation  **" << endl;
    cout << "Enter Locater ID: ";
    getline(cin, searchString, '\n');
    list <CruiseReserve>::iterator cruiseReserve;
    for (cruiseReserve = reserveList.begin(); cruiseReserve != reserveList.end(); ++cruiseReserve)
    {
        if(searchString == cruiseReserve->getLocaterID())
        {
            cout << "\n\nYour reservation was found:\n" << endl;
            cout << "**************************" << endl;
            cout << "LocaterID:  " << cruiseReserve->getLocaterID() << endl;
            cout << "Departure Month:  " << cruiseReserve->getDepartureMonth() << endl;
            cout << "Length of Cruise:  " << displayLengthOfCruise(cruiseReserve->getLengthOfCruise()) << endl;
            cout << "Number of Guests:  " << cruiseReserve->getNumberOfGuests() << endl;
            cout << "First Name:  " << cruiseReserve->getFirstName() << endl;
            cout << "Last Name:  " << cruiseReserve->getLastName() << endl;
            cout << "Billing Address:  " << cruiseReserve->getBillingAddress() << endl;
            cout << "ZIP Code:  " << cruiseReserve->getZipCode() << endl;
            cout << "**************************" << endl;
            
            cout << "\nAre you sure you want to edit this reservation?" << endl;
            cout << "Enter Y or N: ";
            getline(cin, userInput, '\n');
            if(userInput == "Y" || userInput == "y")
            {
                cout << "\n**  Select option to modify  **" << endl;
                cout << "LocaterID:  " << cruiseReserve->getLocaterID() << endl;
                cout << "\t1. Departure Month:  " << cruiseReserve->getDepartureMonth() << endl;
                cout << "\t2. Length of Cruise:  " << displayLengthOfCruise(cruiseReserve->getLengthOfCruise()) << endl;
                cout << "\t3. Number of Guests:  " << cruiseReserve->getNumberOfGuests() << endl;
                cout << "\t4. First Name:  " << cruiseReserve->getFirstName() << endl;
                cout << "\t5. Last Name:  " << cruiseReserve->getLastName() << endl;
                cout << "\t6. Billing Address:  " << cruiseReserve->getBillingAddress() << endl;
                cout << "\t7. ZIP Code:  " << cruiseReserve->getZipCode() << endl;
                cout << "Enter option: ";
                getline(cin, userInput, '\n');
                
                switch(atoi(userInput.c_str()))
                {
                    case 1:
                        //departureMonth
                        correct = false; // Reset 'correct' to false
                        while(!correct)
                        {
                            cout << "\nDeparture Month (1 - 12): ";
                            getline(cin, userInput, '\n');
                            month = atoi(userInput.c_str());
                            if (month >= 1 && month <= 12)
                            {
                                cruiseReserve->setDepartureMonth(month);
                                correct = true;
                            }
                        } // End Departure Month entry
                        break;
                        
                    case 2:
                        //lengthOfCruise
                        correct = false; // Reset 'correct' to false
                        while(!correct)
                        {
                            cout << "\nLength of Cruise:" << endl;
                            cout << "\t1. \t1 to 2 nights" << endl;
                            cout << "\t2. \t3 to 5 nights" << endl;
                            cout << "\t3. \t6 to 9 nights" << endl;
                            cout << "\t4. \t10 to 15 nights" << endl;
                            cout << "\nEnter length of cruise: ";
                            getline(cin, userInput, '\n');
                            nights = atoi(userInput.c_str());
                            if (nights >= 1 && nights <= 4)
                            {
                                cruiseReserve->setLengthOfCruise(nights);
                                correct = true;
                            } // End If
                        } // End Length of Cruise Entry
                        break;
                        
                    case 3:
                        //numberOfGuests
                        cout << "\nNumber of guests: ";
                        getline(cin, userInput, '\n');
                        cruiseReserve->setNumberOfGuests(atoi(userInput.c_str()));
                        break;
                        
                    case 4:
                        //firstName
                        cout << "\nFirst Name: ";
                        getline(cin, userInput, '\n');
                        cruiseReserve->setFirstName(userInput);
                        break;
                        
                    case 5:
                        //lastName
                        cout << "\nLast Name: ";
                        getline(cin, userInput, '\n');
                        cruiseReserve->setLastName(userInput);
                        break;
                        
                    case 6:
                        //billingAddress
                        cout << "\nBilling Address: ";
                        getline(cin, userInput, '\n');
                        cruiseReserve->setBillingAddress(userInput);
                        break;
                        
                    case 7:
                        //zipCode
                        correct = false; // Reset 'correct' to false
                        while(!correct)
                        {
                            cout << "\nZIP Code: ";
                            getline(cin, userInput, '\n');
                            if(atoi(userInput.c_str()) >= 10000 && atoi(userInput.c_str()) <= 99999)
                            {
                                cruiseReserve->setZipCode(atoi(userInput.c_str()));
                                correct = true;
                            }
                        }
                    default:
                        break;
                }
                
                cout << "\n\n****\tReservation Edited.\t****" << endl;
                cout << "Press ENTER key to go back to the main menu." << endl;
                getchar();
            }
            else
            {
                cout << "\tNot Edited\n" << endl;
            }
            
            
            match = true;
            break;
            
        }
    }
    if(!match)
    {
        cout << "No match found!" << endl;
        cout << "\t1. Search again" << endl;
        cout << "\t2. Main Menu" << endl;
        cout << "Option: ";
        getline(cin, userInput, '\n');
        
        switch(atoi(userInput.c_str()))
        {
            case 1:
                editReservation();
                break;
                
            case 2:
                break;
                
            default:
                break;
        }
        
    }
} // End editReservation

// Delete Reservation - allows the user to delete a reservation
void deleteReservation()
{
    string searchString;
    bool match = false;
    string userInput;
    cout << "**  Delete Reservation  **" << endl;
    cout << "Enter Locater ID: ";
    getline(cin, searchString, '\n');
    list <CruiseReserve>::iterator cruiseReserve;
    for (cruiseReserve = reserveList.begin(); cruiseReserve != reserveList.end(); ++cruiseReserve)
    {
        if(searchString == cruiseReserve->getLocaterID())
        {
            cout << "\n\nYour reservation was found:\n" << endl;
            cout << "**************************" << endl;
            cout << "LocaterID:  " << cruiseReserve->getLocaterID() << endl;
            cout << "Departure Month:  " << cruiseReserve->getDepartureMonth() << endl;
            cout << "Length of Cruise:  " << displayLengthOfCruise(cruiseReserve->getLengthOfCruise()) << endl;
            cout << "Number of Guests:  " << cruiseReserve->getNumberOfGuests() << endl;
            cout << "First Name:  " << cruiseReserve->getFirstName() << endl;
            cout << "Last Name:  " << cruiseReserve->getLastName() << endl;
            cout << "Billing Address:  " << cruiseReserve->getBillingAddress() << endl;
            cout << "ZIP Code:  " << cruiseReserve->getZipCode() << endl;
            cout << "**************************" << endl;
            match = true;
            
            cout << "\n\nWould you like to delete this record?" << endl;
            cout << "\t1. Delete (this cannot be undone!)" << endl;
            cout << "\t2. Main Menu" << endl;
            cout << "Option: ";
            getline(cin, userInput, '\n');
            
            switch(atoi(userInput.c_str()))
            {
                case 1:
                    reserveList.erase(cruiseReserve);
                    cout << "\n\n****\tReservation Deleted.\t****" << endl;
                    cout << "Press ENTER key to go back to the main menu." << endl;
                    getchar();
                    break;
                    
                case 2:
                    break;
                    
                default:
                    break;
            }
            break;
        }
    }
    if(!match)
    {
        cout << "**  Delete Reservation  **" << endl;
        cout << "\nNo match found!\n" << endl;
        cout << "\t1. Search again" << endl;
        cout << "\t2. Main Menu" << endl;
        cout << "Option: ";
        getline(cin, userInput, '\n');
        
        switch(atoi(userInput.c_str()))
        {
            case 1:
                deleteReservation();
                break;
                
            case 2:
                break;
                
            default:
                break;
        }
        
    }
} // End deleteReservation

// Menu - Displays our main menu
void menu()
{
    bool exitProgram = false; // Tells code to exit
    string userInput; // User input
    
    while(!exitProgram) // Menu loop
    {
        header();
        cout << endl << "\t1. Enter Reservation" << endl;
        cout << "\t2. Display Reservations" << endl;
        cout << "\t3. Search for Reservation" << endl;
        cout << "\t4. Edit Reservation" << endl;
        cout << "\t5. Delete Reservation\n" << endl;
        
        cout << "\t99. Exit System" << endl;
        cout << "\t**************************" << endl;
        
        cout << "Option: ";
        getline(cin, userInput, '\n');
        
        switch(atoi(userInput.c_str()))
        {
            case 1:
                enterReservation();
                break;
            
            case 2:
                displayReservations();
                break;
                
            case 3:
                searchForReservation();
                break;
                
            case 4:
                editReservation();
                break;
                
            case 5:
                deleteReservation();
                break;
                
            case 99:
                saveData();
                exitProgram = true;
                break;
                
            default:
                cerr << "Error: Please only enter one of the menu options." << endl;
                break;
        } // End Switch
    } // End While
} // End Menu
