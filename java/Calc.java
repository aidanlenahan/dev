//Aidan Lenahan
//AP CSA Per 7
//09.16.24
//This code asks for the operation to be performed and asks for two operands to add, subtract, multiply, or divide.
//The code also prevents the user from dividing by zero

import java.io.*;

class Calc
{
	public static void main(String[] args)
		throws java.io.IOException
	{
		BufferedReader inputStream = new BufferedReader(
			new InputStreamReader(System.in));

		//vars
		int numOperation = 0;
		int operand1 = 0;
		int operand2 = 0;
		int total = 0;
		int divZero;

		System.out.print("\033[H\033[2J\n");
		System.out.println("Welcome to javaCalc!\n");

		while (numOperation < 5)
		{
			divZero = 0;

			System.out.println("-----------------------");
			System.out.println("1. Add");
			System.out.println("2. Subtract");
			System.out.println("3. Multiply");
			System.out.println("4. Divide");
			System.out.println("5. Exit");
			System.out.print("\n\n");

			String inputLine = null;
			System.out.print("Type a number 1 through 5: ");
			inputLine = inputStream.readLine(); 
			numOperation = Integer.parseInt(inputLine);


			if (numOperation != 5)
			{
				inputLine = null; //do NOT redefine inputLine here, only at the beginning of the file
				System.out.print("\nEnter a number: ");
				inputLine = inputStream.readLine();
				operand1 = Integer.parseInt(inputLine);

				inputLine = null;
				System.out.print("\nEnter a second number: ");
				inputLine = inputStream.readLine();
				operand2 = Integer.parseInt(inputLine);
			}

			if (numOperation == 1) //addition logic
			{
				total = operand1 + operand2;
			}
			if (numOperation == 2) //subtraction logic
			{
				total = operand1 - operand2;
			}
			if (numOperation == 3) //multiplication logic
			{
				total = operand1 * operand2;
			}
			if (numOperation == 4) //division logic
			{
				if (operand2 == 0) //division by zero
				{
					divZero = 1;
				}
				else
				{
					total = operand1 / operand2;
				}
			}

			if (numOperation == 1 | numOperation == 2 | numOperation == 3 | numOperation == 4)
			{
				if (divZero == 1)
				{
					System.out.println("Cannot divide by zero! Try again.");
				}
				else
				{
					System.out.println("The total is: " + total); //displays the calculated numbers done in operator logic above
				}
				System.out.print("\n\n");
			}
		}
		System.out.print("\033[H\033[2J");
	}
}
