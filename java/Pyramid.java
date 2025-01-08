//Aidan Lenahan
//AP CSA Per 7
//09.16.24
//This code takes an integer input and then turns it into a horizontal standing pyramid.

import java.io.*;

class Pyramid
{
	public static void main(String[] args)
		throws java.io.IOException
	{
		BufferedReader inputStream = new BufferedReader(
			new InputStreamReader(System.in));

		int pyramidSize = 0;
		String inputLine = null;
		System.out.println("What is the size of the pyramid?");
		inputLine = inputStream.readLine(); 
		pyramidSize = Integer.parseInt(inputLine);

		System.out.print("\n\n\n\n");
		for (int i =1; i <= pyramidSize - 1; i++) {
			for (int j = 1; j <= i; j++) {
				System.out.print("*");
			}
			System.out.print("\n");
		}
		//System.out.print(pyramidSize + "\n");
		for (int i = 1; i <= pyramidSize; i++) {
			for (int j = pyramidSize; j >= i; j--) {
			       System.out.print("*");
			}
	 		System.out.print("\n");
		}
		System.out.print("\n\n\n\n");		
	}
}
