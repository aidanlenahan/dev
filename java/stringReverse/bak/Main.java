//Aidan Lenahan
//1.10.24
//AP CS A
//This program takes a string input from the user and returns it character by character, line by line, in reverse.
//This program makes use of a stack to reverse a string. Stack.java is stack logic made from scratch.

import java.io.*;

class Main
{
 
	public static void main(String args[])
		throws java.io.IOException
	{
		Stack theStack = new Stack();
		char currentChar; //used in for loop
		
		BufferedReader inputStream = new BufferedReader(
		new InputStreamReader(System.in));

		String unreversed;
		String inputLine = null;

		System.out.print("Enter a string: ");
		inputLine = inputStream.readLine(); 
		unreversed = inputLine;
		//System.out.println("You gave me: " + unreversed); //testing

		for (int i = 0; i < unreversed.length(); i++)
		{
			currentChar = unreversed.charAt(i);
			theStack.Push(currentChar);
		}

		while (theStack.IsEmpty() == false)
		{
			System.out.println(theStack.Pop());
		}
	}
}
