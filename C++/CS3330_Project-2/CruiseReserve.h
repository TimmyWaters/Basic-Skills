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

#ifndef CruiseReserve_h
#define CruiseReserve_h

#include <iostream>
#include <string>

using namespace std;

class CruiseReserve
{
public:
    CruiseReserve();
    CruiseReserve(const CruiseReserve &cruiseReserve);
    ~CruiseReserve();
    
    void setLocaterID(const string locaterID);
    string getLocaterID() const;
    
    void setDepartureMonth(const int departureMonth);
    int getDepartureMonth() const;
    
    void setLengthOfCruise(const int lengthOfCruise);
    int getLengthOfCruise() const;
    
    void setNumberOfGuests(const int numberOfGuests);
    int getNumberOfGuests() const;
    
    void setFirstName(const string firstName);
    string getFirstName() const;
    
    void setLastName(const string lastName);
    string getLastName() const;
    
    void setBillingAddress(const string billingAddress);
    string getBillingAddress() const;
    
    void setZipCode(const int zipCode);
    int getZipCode() const;
    
private:
    string locaterID;
    int departureMonth; // Input Validation Required
    int lengthOfCruise; // Input Validation Required
    int numberOfGuests;
    string firstName;
    string lastName;
    string billingAddress;
    int zipCode; // Input Validation Required
};

#endif /* CruiseReserve_h */
