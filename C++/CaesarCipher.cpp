#include <iostream>
#include <string>

using namespace std;

void encrypt();
void decrypt();

int main()
{
    int choice;
    cout << "\tCaesar Cipher" << endl
    << "1. Encrypt" << endl
    << "2. Decrypt" << endl
    << "Select: ";
    cin >> choice;
    cin.ignore();
    
    if(choice == 1)
    {
        encrypt();
    }
    else if(choice == 2)
    {
        decrypt();
    }
    else
    {
        cout<<"Error, bad input, quitting\n";
    }
}

void encrypt()
{
    string inString;
    int length;
   
    cout << "Enter text to encrypt: ";
    getline(cin, inString);
    length = inString.length();
    for(int i = 0; i<length; i++)
    {
        if(isalpha(inString[i]))
        {
            inString[i] = tolower(inString[i]);
            for(int j=0; j<7; j++)
            {
                if(inString[i] == 'z')
                {
                    inString[i] = 'a';
                }
                else
                {
                    inString[i]++;
                }
            }
        }
    }
    cout << "Code is: " << inString;
}

void decrypt()
{
    string inString;
    int length;
   
    cout << "Enter text to decrypt: ";
    getline(cin, inString);
    length = inString.length();
    for(int i = 0; i<length; i++)
    {
        if(isalpha(inString[i]))
        {
            inString[i] = tolower(inString[i]);
            for(int j=0; j<7; j++)
            {
                if(inString[i] == 'a')
                {
                    inString[i] = 'z';
                }
                else
                {
                    inString[i]--;
                }
            }
        }
    }
    cout << "Original is: " << inString;
}