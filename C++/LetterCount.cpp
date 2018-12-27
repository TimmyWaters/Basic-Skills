#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main()
{
    string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string phrase;
    cout<<"Enter the phrase: "<<endl;
    getline(cin, phrase);
    int num[26];
    int count;
    char z;
    
    for(int i=0;i<alpha.length();i++)
    {
        num[i]=0;
        count=0;
        cout<<alpha[i]<<" : ";
        for(int x=0;x<phrase.length();x++)
        {
            z=toupper(phrase[x]);
            if(alpha[i]==z)
            {
                count++;
            }
        }
        num[i]=count;
        cout<<num[i]<<endl;
    }
}