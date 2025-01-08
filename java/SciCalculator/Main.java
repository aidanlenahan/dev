//Aidan Lenahan
//AP CSA
//10.16.24
//This program is a scientific calculator, and is able to perform 16 operations which are usually common on scientific calculators.

import java.io.*;

class Main
{
	public static void main(String[] args)
		throws java.io.IOException
	{
		//Calculator theCalculator = new Calculator();

		BufferedReader inputStream = new BufferedReader(
			new InputStreamReader(System.in));

		int numOperation = 0;
		int divZero;
		double operand1 = 0;
		double operand2 = 0;
		double answer = 0;

		System.out.print("\033[H\033[2J\n");
		System.out.println("Welcome to javaCalc!\n");

		while (numOperation < 17)
		{
			divZero = 0;
			System.out.println("-------------------------");
			System.out.println("1. Add");
			System.out.println("2. Subtract");
			System.out.println("3. Multiply");
			System.out.println("4. Divide");
			System.out.println("5. Power");
			System.out.println("6. Atan2");
			System.out.println("7. Square Root");
			System.out.println("8. Absolute Value");
			System.out.println("9. Sin");
			System.out.println("10. Cos");
			System.out.println("11. Log 10");
			System.out.println("12. Natural Log (e)");
			System.out.println("13. Acos");
			System.out.println("14. Asin");
			System.out.println("15. Atan");
			System.out.println("16. Exp");
			System.out.println("17. Exit");
			System.out.print("\n\n");

			String inputLine = null;
			System.out.print("Type a number 1 through 17: ");
			inputLine = inputStream.readLine();
			numOperation = Integer.parseInt(inputLine);

			if (numOperation >= 1 && numOperation <= 16) {
				System.out.print("Current Operation: ");
			}
			if (numOperation == 1) {
				System.out.println(numOperation + ". Add (a + b)");
			} else if (numOperation == 2) {
				System.out.println(numOperation + ". Subtract (a - b)");
			} else if (numOperation == 3) {
				System.out.println(numOperation + ". Multiply (a * b)");
			} else if (numOperation == 4) {
				System.out.println(numOperation + ". Divide (a / b)");
			} else if (numOperation == 5) {
				System.out.println(numOperation + ". Power (a^b))");
			} else if (numOperation == 6) {
				System.out.println(numOperation + ". Atan2 (y, x))");
			} else if (numOperation == 7) {
				System.out.println(numOperation + ". Square Root (sqrt[a])");
			} else if (numOperation == 8) {
				System.out.println(numOperation + ". Absolute Value (abs[a])");
			} else if (numOperation == 9) {
				System.out.println(numOperation + ". Sin (sin[a])");
			} else if (numOperation == 10) {
				System.out.println(numOperation + ". Cos (cos[a])");
			} else if (numOperation == 11) {
				System.out.println(numOperation + ". Log 10 (log10[a])");
			} else if (numOperation == 12) {
				System.out.println(numOperation + ". Log e (ln[a])");
			} else if (numOperation == 13) {
				System.out.println(numOperation + ". Acos (acos[a])");
			} else if (numOperation == 14) {
				System.out.println(numOperation + ". Asin (asin[a])");
			} else if (numOperation == 15) {
				System.out.println(numOperation + ". Atan (atan[a])");
			} else if (numOperation == 16) {
				System.out.println(numOperation + ". Exp (e^a)");
			}

			SciCalculator theSciCalculator = new SciCalculator();

			if (numOperation < 17)
			{
				inputLine = null;
				System.out.print("\nEnter a first number: ");
				inputLine = inputStream.readLine();
				operand1 = Double.parseDouble(inputLine);
				theSciCalculator.SetOperand1(operand1);

				if (numOperation < 7)
				{
					inputLine = null;
					System.out.print("\nEnter a second number: ");
					inputLine = inputStream.readLine();
					operand2 = Double.parseDouble(inputLine);
					theSciCalculator.SetOperand2(operand2);
				}
			}

			if (numOperation == 1) //addition
			{
				answer = theSciCalculator.add();
			}
			if (numOperation == 2) //subtract
                        {
                                answer = theSciCalculator.subtract();
                        }
			if (numOperation == 3) //multiply
                        {
                                answer = theSciCalculator.multiply();
                        }
			if (numOperation == 4) //divide
                        {
                                if (operand2 == 0)
				{
					divZero = 1;
				}
				else
				{
					answer = theSciCalculator.divide();
				}
                        }
			if (numOperation == 5) //power
                        {
                                answer = theSciCalculator.power();
                        }
			if (numOperation == 6) //atan2
                        {
                                answer = theSciCalculator.atan2();
                        }
			if (numOperation == 7) //square root
                        {
                                answer = theSciCalculator.squareRoot();
                        }
			if (numOperation == 8) //abs val
                        {
                                answer = theSciCalculator.absoluteValue();
                        }
			if (numOperation == 9) //sin
                        {
                                answer = theSciCalculator.sin();
                        }
			if (numOperation == 10) //cos
                        {
                                answer = theSciCalculator.cos();
                        }
			if (numOperation == 11) //log10
                        {
                                answer = theSciCalculator.log10();
                        }
			if (numOperation == 12) //loge
                        {
                                answer = theSciCalculator.loge();
                        }
			if (numOperation == 13) //acos
                        {
                                answer = theSciCalculator.acos();
                        }
			if (numOperation == 14) //asin
                        {
                                answer = theSciCalculator.asin();
                        }
			if (numOperation == 15) //atan
                        {
                                answer = theSciCalculator.atan();
                        }
			if (numOperation == 16) //exp
                        {
                                answer = theSciCalculator.exp();
                        }
			
			if (divZero == 1)
			{
				System.out.println("ERROR: Cannot divide by zero! Try again.");
			}
			else if (numOperation <= 0)
			{
				System.out.println("ERROR: Invalid operation. Try again.");
			}
			else if (numOperation >= 1 && numOperation <= 16)
			{
				System.out.println("Result: " + answer);
			}
		}
	}
}
