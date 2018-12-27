/*
*
* Timmy Waters
* CS 2265
* Program 6
* 
*/

import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.util.*;

public class GuessNumber implements ActionListener
{
    // Variables
    private JFrame frame;
    private JButton button;
    private JTextField textField;
    private JLabel label;
    private JLabel errorLabel;
    private int randomNumber;
    private int guess;
    private int guessCount;
    private int guessOld;
    private int newDiff;
    private int oldDiff;
    // End Variables
    
    public GuessNumber()
    {
        // Create JFrame
        frame = new JFrame("Guess The Number");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // Close button in Window works now
        
        
        // Start button
        button = new JButton("Start Game");
        button.setBounds(20,20,100,30);
        
        // Text Field
        textField = new JTextField();
        textField.setBounds(125,20,50,30);
        textField.setVisible(false);
        
        // Add Action Listener to the Start button
        button.addActionListener(this);
        
        // The main label showing status
        label = new JLabel();
        label.setBounds(20,60,500,30);
        
        // Show input error
        errorLabel = new JLabel("Only enter 1 - 1000. Try again.");
        errorLabel.setBounds(200,20,200,30);
        errorLabel.setVisible(false);
        
        // Add everything to the frame
        frame.add(button);
        frame.add(textField);
        frame.add(label);
        frame.add(errorLabel);
        frame.setSize(600,150);
        frame.setLayout(null);
        frame.setVisible(true);
        
        // Create the key listener for the text field
        KeyListener keyListener = new KeyListener()
        {
            public void keyPressed(KeyEvent keyEvent)
            {
                // Here is what happens when ENTER is pressed
                if (keyEvent.getKeyCode()==KeyEvent.VK_ENTER)
                {
                    setGuess();
                    if(guess < 1 || guess > 1000)
                    {
                        errorLabel.setVisible(true);
                        textField.setText("");
                    }
                    else
                    {
                        guessCount++;
                        errorLabel.setVisible(false);
                        guessProcess();
                    }
                }
            }
            
            // Required by key listener
            public void keyReleased(KeyEvent keyEvent) {}
            // Required by key listener
            public void keyTyped(KeyEvent keyEvent) {}
        }; // End Key Listener
        
        // Add key listener to the text field
        textField.addKeyListener(keyListener);
    } // End GuessNumber constructor
    
    // Action Listener for start button
    public void actionPerformed(ActionEvent e)
    {
        startGame();
        System.out.println(randomNumber);
    } // End Action Listener
    
    // Actions for start button
    private void startGame()
    {
        // For consistency in colors
        frame.getContentPane().setBackground(new Color(238,238,238));
        
        // Generate the random number
        Random random = new Random();
        randomNumber = random.nextInt(1000) + 1;
        
        // Show the text field empty
        textField.setVisible(true);
        textField.setText("");
        textField.setEnabled(true);
        
        // Initialize these items
        guessCount = 0;
        guessOld = 0;
        label.setText("<html>I have a number between 1 and 1000 can you guess my number?<br>Please enter a number for your first guess and then hit Enter.</html>");
    } // End startGame()
    
    // Set guess var with input from text field
    private void setGuess()
    {
        guess = Integer.parseInt(textField.getText());
    } // End setGuess()
    
    // *** The game logic ***
    private void guessProcess()
    {
        if(guess == randomNumber)
        {
            resultWin();
        }
        else if(guessCount == 1)
        {
            if(guess < randomNumber)
            {
                label.setText(guess + " is TOO LOW! But, you are getting WARMER! Enter guess number " + (guessCount + 1) + ".");
                warmer();
                guessOld = guess;
                oldDiff = randomNumber - guess;
            }
            else if(guess > randomNumber)
            {
                label.setText(guess + " is TOO HIGH! But, you are getting WARMER! Enter guess number " + (guessCount + 1) + ".");
                warmer();
                guessOld = guess;
                oldDiff = guess - randomNumber;
            }
        }
        else if(guess < randomNumber)
        {
            resultLess();
        }
        else if(guess > randomNumber)
        {
            resultGreater();
        }
    } // End guessProcess()
    
    // Yay, they won!
    private void resultWin()
    {
        label.setText(guess + " is correct! Total guesses was " + guessCount + ". Click the button to start a new game.");
        textField.setText("");
        textField.setEnabled(false);
        frame.getContentPane().setBackground(new Color(238,238,238));
    } // End resultWin()
    
    // Too Low!
    private void resultLess()
    {
        newDiff = randomNumber - guess;
        
        if(newDiff < oldDiff)
        {
            label.setText(guess + " is TOO LOW! But, you are getting WARMER! Enter guess number " + (guessCount + 1) + ".");
            warmer();
            guessOld = guess;
        }
        else if(oldDiff < newDiff)
        {
            label.setText(guess + " is TOO LOW! And you are getting COLDER! Enter guess number " + (guessCount + 1) + ".");
            colder();
            guessOld = guess;
        }
        
        oldDiff = randomNumber - guessOld;
    } // End resultLess()
    
    // Too High!
    private void resultGreater()
    {
        newDiff = guess - randomNumber;
        
        if(newDiff < oldDiff)
        {
            label.setText(guess + " is TOO HIGH! But, you are getting WARMER! Enter guess number " + (guessCount + 1) + ".");
            warmer();
            guessOld = guess;
        }
        else if(oldDiff < newDiff)
        {
            label.setText(guess + " is TOO HIGH! And you are getting COLDER! Enter guess number " + (guessCount + 1) + ".");
            colder();
            guessOld = guess;
        }
        
        oldDiff = guessOld - randomNumber;
    } // End resultGreater()
    
    // Warmer!
    private void warmer()
    {
        frame.getContentPane().setBackground( new Color(255,51,51) );
    } // End Warmer
    
    // Colder!
    private void colder()
    {
        frame.getContentPane().setBackground( new Color(102,204,255) );
    } // End colder
    // *** End Game Logic ***
    
    // Main Function
    public static void main(String[] args)
    {
        // Create new game object
        new GuessNumber();
    } // End Main
} // End GuessNumber class
