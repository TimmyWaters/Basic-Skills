import java.io.*;
import java.util.*;

public class Encryption
{
    private String key;
    private String inKey;
    private String inFile;
    private char[] charKey;
    private char[] charPlain = new char[26];
    private char[] charEnc = new char[26];
    private char[] encryptArr;
    private int len;
    private int count = 0;
    private String alphabet;
    private String encAlpha;
    private String tempAlpha;
    private String temp;
    private String encryptedText;
    private String decryptedText;
    
    public Encryption(String newKey)
    {
        // ***   Key
        inKey = newKey;
        generateKey();
        
        // Generate the alphabet
        generateAlpha();
        
        // Encrypted alphabet
        generateEncAlpha();
    }
    
    public void setInFile(String in)
    {
        inFile = in;
    }
    
    private void generateKey()
    {
        charKey = inKey.toCharArray();
        Set<Character> charSet = new HashSet<>();
        len = 0;
        for(char c : charKey)
        {
            if (charSet.add(c))
            {
                charKey[len++] = c;
            }
        }
        key = new String(charKey, 0, len);
    }
    
    private void generateAlpha()
    {
        int x, y;
        for(x = 0; x < 26; ++x)
        {
            y = x + 65;
            charPlain[x] = (char)y;
        }
        alphabet = String.valueOf(charPlain);
    }
    
    private void generateEncAlpha()
    {
        for(int i = charPlain.length-1; i >= 0; i--)
        {
            charEnc[count] = charPlain[i];
            count++;
        }
        tempAlpha = String.valueOf(charEnc);
        for(int j = 0; j < key.length(); j++)
        {
            temp = String.valueOf(key.charAt(j));
            tempAlpha = tempAlpha.replaceAll(temp, "");
        }
        encAlpha = key + tempAlpha;
    }
    
    public void encrypt()
    {
        char[] tempChar = new char[inFile.length()];
        char myChar;
        char myNewChar;
        encryptArr = inFile.toCharArray();
        for(int x = 0; x < encryptArr.length; ++x)
        {
            for(int y = 0; y < charPlain.length; ++y)
            {
                if(encryptArr[x] == ' ')
                {
                    tempChar[x] = ' ';
                    myChar = tempChar[x];
                    System.out.println("Plaintext byte " + (int) myChar + " (" + myChar + ") was not encoded");
                    break;
                }
                if(encryptArr[x] == charPlain[y])
                {
                    tempChar[x] = encAlpha.charAt(y);
                    myChar = encryptArr[x];
                    myNewChar = tempChar[x];
                    System.out.println("Plaintext byte " + (int) myChar + " (" + myChar + ") encoded as " + myNewChar);
                    break;
                }
            }
        }
        encryptedText = String.valueOf(tempChar);
    }
    
    public void decrypt()
    {
        char[] tempChar = new char[inFile.length()];
        char myChar;
        char myNewChar;
        encryptArr = inFile.toCharArray();
        for(int x = 0; x < encryptArr.length; ++x)
        {
            for(int y = 0; y < encAlpha.length(); ++y)
            {
                if(encryptArr[x] == ' ')
                {
                    tempChar[x] = ' ';
                    myChar = tempChar[x];
                    System.out.println("Plaintext byte " + (int) myChar + " (" + myChar + ") was not encoded");
                    break;
                }
                if(encryptArr[x] == encAlpha.charAt(y))
                {
                    tempChar[x] = charPlain[y];
                    myChar = encryptArr[x];
                    myNewChar = tempChar[x];
                    System.out.println("Plaintext byte " + (int) myChar + " (" + myChar + ") decoded as " + myNewChar);
                    break;
                }
            }
        }
        decryptedText = String.valueOf(tempChar);
    }
    
    public String getDecryptedText()
    {
        return decryptedText;
    }
    
    public String getEncryptedText()
    {
        return encryptedText;
    }
    
    public String getKey()
    {
        return key;
    }
    
    public String getAlphabet()
    {
        return alphabet;
    }
    
    public String getEncAlpha()
    {
        return encAlpha;
    }
    
    public String getKeyPlain()
    {
        return inKey;
    }
    
    public String getPlainMsg()
    {
        return inFile;
    }
}
