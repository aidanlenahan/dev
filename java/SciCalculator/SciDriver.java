class SciDriver
{
	public static void main(String[] args)
	{
		//Calculator theCalculator = new Calculator();
		SciCalculator theSciCalculator = new SciCalculator();

		theSciCalculator.SetOperand1(4.3);
		theSciCalculator.SetOperand2(3.5);

		double answer = theSciCalculator.Add();
		System.out.println("answer: " + answer);

		//answer = theSciCalculator.Sqrt
	}
}
