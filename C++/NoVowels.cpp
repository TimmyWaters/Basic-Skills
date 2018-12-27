#include <iostream>
#include <string>

using namespace std;

int main()
{
    int i, x;
    string instr;
    string vowels = "aeiou";
    
    cout<<"Enter some text: ";
    getline(cin, instr);
    
    for(x=0; x<instr.length(); x++)
    {
        for(i=0;i<vowels.length();i++)
        {
            if(instr[x]==vowels[i])
            {
                instr[x]='*';
            }
        }
    }
    cout<<"With vowels replaced: "<<instr;
    return 0;
}