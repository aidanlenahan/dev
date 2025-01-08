//Aidan Lenahan
//10.22.2024
//AP CSA
//This program uses the bubble sorting technique to sort twelve integers that the user provides.

import java.io.*;

class Main 
{
	public static void main(String args[])
		throws java.io.IOException
	{
		BufferedReader inputStream = new BufferedReader(
        		new InputStreamReader(System.in));

		int theInt;
		String inputLine = null;
    
		int [] intArray = new int[10];
		// int intArray[12]; // C Style

		for (int i = 0; i < intArray.length; i++)
		{
			System.out.print("Please enter an integer number: ");
			inputLine = inputStream.readLine();
			intArray[i] = Integer.parseInt(inputLine);
			System.out.println("You gave me: " + intArray[i]);
		}

		boolean swapped = true;
		while (swapped)
		{
			swapped = false;
			for (int i = 0; i < intArray.length - 1; i++)
			{
				if (intArray[i] > intArray[i + 1])
				{
					//swap
					int tempIndex = intArray[i];
					intArray[i] = intArray[i + 1];
					intArray[i + 1] = tempIndex;
					swapped = true; //mark swap
				}
			}
		}	
		//print sorted
		for (int i = 0; i < intArray.length; i++)
		{
			System.out.print(intArray[i] + " ");
		}
		System.out.print("\n\n");
	}
}

