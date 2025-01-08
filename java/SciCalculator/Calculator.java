class Calculator
{
	protected double operand1, operand2;
	protected double answer;

	Calculator(double theOperand1, double theOperand2)
	{
		operand1 = theOperand1;
		operand2 = theOperand2;
	}
	Calculator()
	{
		operand1 = 0;
		operand2 = 0;
		answer = 0;
	}
	public void SetOperand1(double theOperand)
	{
		operand1 = theOperand;
	}
	public void SetOperand2(double theOperand)
	{
		operand2 = theOperand;
	}

	public double add()
	{
		answer = operand1 + operand2;

		return(answer);
	}
	public double subtract()
	{
		answer = operand1 - operand2;
		return(answer);
	}
	public double multiply()
	{
		answer = operand1 * operand2;
		return(answer);
	}
	public double divide()
	{
		answer = operand1 / operand2;
		return(answer);
	}
	public double returnAnswer()
	{
		return(answer);
	}
}

