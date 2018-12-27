/*
Example by Timmy
*/

public class VigenereTable
{
	public static void main(String[] args)
	{
		// Create the array
		int alphabet[][] = new int[26][26];
		
		// Here's the magic!
		for(int x = 0; x < 26; ++x)
		{
			for(int y = 0; y < 26; ++y)
			{
				alphabet[x][y] = (x+y) + 65;

				if(alphabet[x][y]>=91)
            	{
                	alphabet[x][y]-=26;
            	} // End of if-statement

            	System.out.print((char) alphabet[x][y]);
			} // End of inner for-loop

			System.out.println("");
		} // End of outer for-loop

	} // End of main function
} // End of main Class