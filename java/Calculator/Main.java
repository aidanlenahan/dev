//Aidan Lenahan
//AP CS A Per. 4
//10.2.24
//This program takes two double numbers as input. It them uses the Calculator class and the
//Add(), Subtract(), Multiply(), and Divide() functions which then return the answer back to Main.java.
//The program then prints the result. Division by zero is not allowed.

import java.io.*;

class Main
{
	public static void main(String[] args)
		throws java.io.IOException
	{
		BufferedReader inputStream = new BufferedReader(
			new InputStreamReader(System.in));

		int numOperation = 0;
		int divZero;
		double operand1 = 0;
		double operand2 = 0;
		double answer = 0;
		
		
		System.out.print("\033[H\033[2J\n");
		System.out.println("Welcome to javaCalc!\n");

		while (numOperation < 5)
		{
			divZero = 0;
			System.out.println("-------------------------");
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
				inputLine = null;

				System.out.print("\nEnter a number: ");
				inputLine = inputStream.readLine();
				operand1 = Double.parseDouble(inputLine);

				inputLine = null;
				System.out.print("\nEnter a second number: ");
				inputLine = inputStream.readLine();
				operand2 = Double.parseDouble(inputLine);
			}
			
			Calculator theCalculator = new Calculator(0, 0);

			theCalculator.SetOperand1(operand1);
			theCalculator.SetOperand2(operand2);
			
			if (numOperation == 1) //addition logic
			{

				answer = theCalculator.Add();
			}
			if (numOperation == 2) //subtraction logic
			{
				answer = theCalculator.Subtract();
			}
			if (numOperation == 3) //multiplication logic
			{
				answer = theCalculator.Multiply();
			}
			if (numOperation == 4)
			{
				if (operand2 == 0) //division by zero
                                {
                                        divZero = 1;
                                }
                                else
                                {
                                        answer = theCalculator.Divide();
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
					System.out.println("The total is: " + answer);
				}
			}
		}
	}
}
