import java.io.*;

class CalcDriver
{
	public static void main(String[] args)
	{
		Calculator theCalculator = new Calculator(0, 0);

		theCalculator.SetOperand1(3.14);
		theCalculator.SetOperand2(2.33);

		double answer = theCalculator.Add();

		System.out.println("Answer: " + answer);
	}
}
