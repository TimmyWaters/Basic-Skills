#include <iostream>
#include <string>
#include <cctype>
#include <unistd.h>
using namespace std;

string inmsg, key, enkey, cipher;
string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
int msglen, keylen, mIndex[100], kIndex[100], cIndex[100];

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

void spinner()
{
    int pos;
    int spaces;
    int x;
    string text = "\tVigenere Cipher\n";
    
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
}

void getmsg()
{
    int i, x, j;
    cout<<"Enter the message: ";
    getline(cin, inmsg);
    msglen=inmsg.length();
    for(j=0;j<msglen;j++)
    {
        inmsg[j] = toupper(inmsg[j]);
    }
    for(i=0;i<msglen;i++)
    {
        x=0;
        while(inmsg[i] != alpha[x])
        {
            x++;
        }
        mIndex[i] = x;
    }
}

void getkey()
{
    int i, j, x;
    cout<<"Enter the key: ";
    cin>>key;
    cin.ignore();
    keylen=key.length();
    enkey=inmsg;
    for(i=0; i<msglen; i++)
    {
        enkey[i]=key[i%keylen];
    }
    
    for(int k=0;k<msglen;k++)
    {
        enkey[k] = toupper(enkey[k]);
    }
    for(j=0;j<msglen;j++)
    {
        x=0;
        while(enkey[j] != alpha[x])
        {
            x++;
        }
        kIndex[j] = x;
    }
}
void encrypt()
{
    getmsg();
    getkey();
    cipher=inmsg;
    int x;
    /*** Do Cipher ***/
    cout<<"\nCipher: \n";
    for(int i=0;i<msglen;i++)
    {
        cIndex[i]=(mIndex[i]+kIndex[i])%26;
        x = cIndex[i];
        cipher[i] = alpha[x];
    }
    cout<<cipher;
}

void decrypt()
{
    getmsg();
    getkey();
    cipher=inmsg;
    int x;
    /*** Do Decipher ***/
    cout<<"\nDeciphered: \n";
    for(int i=0;i<msglen;i++)
    {
        cIndex[i]=(mIndex[i]-kIndex[i])%26;
        x = cIndex[i];
        cipher[i] = alpha[x];
    }
    cout<<cipher;
}

int main()
{
    int choice;
    spinner();
    cout<<"1. Encrypt"<<endl;
    cout<<"2. Decrypt"<<endl;
    cout<<"Enter choice: ";
    cin>>choice;
    cin.ignore();
    switch(choice)
    {
        case 1:
        encrypt();
        break;
        
        case 2:
        decrypt();
        break;
    }
}