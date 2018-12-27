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

#include "CruiseReserve.h"
#include <iostream>

using namespace std;

CruiseReserve::CruiseReserve()
{
    //cout << "Object is being created" << endl;
}

CruiseReserve::CruiseReserve(const CruiseReserve &cruiseReserve)
{
    this->locaterID = cruiseReserve.locaterID;
    this->departureMonth = cruiseReserve.departureMonth;
    this->lengthOfCruise = cruiseReserve.lengthOfCruise;
    this->numberOfGuests = cruiseReserve.numberOfGuests;
    this->firstName = cruiseReserve.firstName;
    this->lastName = cruiseReserve.lastName;
    this->billingAddress = cruiseReserve.billingAddress;
    this->zipCode = cruiseReserve.zipCode;
}

CruiseReserve::~CruiseReserve()
{
    //cout << "Object is being deleted" << endl;
}

void CruiseReserve::setLocaterID(const string locaterID)
{
    this->locaterID = locaterID;
}
string CruiseReserve::getLocaterID() const
{
    return locaterID;
}

void CruiseReserve::setDepartureMonth(const int departureMonth)
{
    this->departureMonth = departureMonth;
}
int CruiseReserve::getDepartureMonth() const
{
    return departureMonth;
}

void CruiseReserve::setLengthOfCruise(const int lengthOfCruise)
{
    this->lengthOfCruise = lengthOfCruise;
}
int CruiseReserve::getLengthOfCruise() const
{
    return lengthOfCruise;
}

void CruiseReserve::setNumberOfGuests(const int numberOfGuests)
{
    this->numberOfGuests = numberOfGuests;
}
int CruiseReserve::getNumberOfGuests() const
{
    return numberOfGuests;
}

void CruiseReserve::setFirstName(const string firstName)
{
    this->firstName = firstName;
}
string CruiseReserve::getFirstName() const
{
    return firstName;
}

void CruiseReserve::setLastName(const string lastName)
{
    this->lastName = lastName;
}
string CruiseReserve::getLastName() const
{
    return lastName;
}

void CruiseReserve::setBillingAddress(const string billingAddress)
{
    this->billingAddress = billingAddress;
}
string CruiseReserve::getBillingAddress() const
{
    return billingAddress;
}

void CruiseReserve::setZipCode(const int zipCode)
{
    this->zipCode = zipCode;
}
int CruiseReserve::getZipCode() const
{
    return zipCode;
}
