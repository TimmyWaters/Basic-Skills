/*
 * CS 2265
 * Timothy Waters
 * Project 5
 */

import java.io.*;
import java.util.*;

public class EncryptProg
{
    public static void main(String[] args)
    {
        try
        {
            Scanner inputKey = new Scanner(new File("keyword.txt"));
            String inKey = inputKey.next();
            Scanner inputFile = new Scanner(new File("input.txt"));
            String inFile = inputFile.nextLine();
            String outText;
            
            Encryption cipher = new Encryption(inKey);
            cipher.setInFile(inFile);
            System.out.println("Raw key input: " + cipher.getKeyPlain());
            System.out.println("Unique character key used: " + cipher.getKey());
            System.out.println("Alphabet:");
            System.out.println(cipher.getAlphabet());
            System.out.println("Encryption Alphabet");
            System.out.println(cipher.getEncAlpha());
            cipher.encrypt();
            System.out.println("");
            OutputStream outputStream = new FileOutputStream("encrypt.txt");
            outText = cipher.getEncryptedText();
            byte b[]=outText.getBytes();//converting string into byte array
            outputStream.write(b);
            outputStream.close();
            Scanner inputNewFile = new Scanner(new File("encrypt.txt"));
            String inNewFile = inputNewFile.nextLine();
            cipher.setInFile(inNewFile);
            cipher.decrypt();
            OutputStream outNewStream = new FileOutputStream("output.txt");
            outText = cipher.getDecryptedText();
            byte d[]=outText.getBytes();//converting string into byte array
            outNewStream.write(d);
            outNewStream.close();
            
        }
        catch(Exception e)
        {
            System.out.println(e);
        }
    }
}

