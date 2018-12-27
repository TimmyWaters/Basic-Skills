#include <iostream>
#include <unistd.h>

using namespace std;

int main()
{
    char spinner[] = {'/', '-', '\\', '|'};
    for(int i = 0; i < sizeof(spinner); i++)
    {
        cout << spinner[i];
        fflush(stdout);
        sleep(1);
        cout << "\r";
    }
    return 0;
}