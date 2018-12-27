#include <iostream>
#include <unistd.h>

using namespace std;

void spin();

int main()
{
    int pos;
    int spaces;
    int x;
    string text;
    
    cout<<"Enter text: ";
    getline(cin, text);
    
    for(pos = 0; pos <= text.length(); pos++)
    {
        for(x = 0; x < pos; x++)
        {
                cout << text[x];
        }
        if(pos+1 <= text.length())
        {
            spin();
            cout << "\r";
        }
        
    }
    return 0;
}

void spin()
{
      char spinner[] = {'/', '-', '\\', '|'};
    for(int i = 0; i < sizeof(spinner); i++)
    {
        cout << spinner[i];
        fflush(stdout);
        sleep(1);
        cout << "\b";
    }
}