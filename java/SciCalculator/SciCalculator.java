import java.lang.Math;

public class SciCalculator extends Calculator
{
	SciCalculator()
	{
		/* Call constructor for Calculator */
		super();
	}

	public void SetOperand1(double theOperand1)
	{
		/* Call setOperand1 for Calculator */
		super.SetOperand1(theOperand1);
	}
 
	public void SetOperand2(double theOperand2)
	{
		/* Call setOperand2 for Calculator */
		super.SetOperand2(theOperand2);
	}
	double power()
	{
		answer = Math.pow(operand1, operand2);
		return(answer);
	}
	double atan2()
	{
		answer = Math.atan2(operand1, operand2);
		return(answer);
	}
	double squareRoot()
	{
		answer = Math.sqrt(operand1);
		return(answer);
	}
	double absoluteValue()
	{
		answer = Math.abs(operand1);
		return(answer);
	}
	double sin()
	{
		answer = Math.sin(operand1);
		return(answer);
	}
	double cos()
	{
		answer = Math.cos(operand1);
		return(answer);
	} 
	double log10()
	{
		answer = Math.log10(operand1);
		return(answer);
	}
	double loge()
	{
		answer = Math.log(operand1);
		return(answer);
	}
	double acos()
	{
		answer = Math.acos(operand1);
		return(answer);
	} 
	double asin()
	{
		Math.asin(operand1);
		return(answer);
	}
	double atan()
	{
		answer = Math.atan(operand1);
		return(answer);
	}
	double exp()
	{
		answer = Math.exp(operand1);
		return(answer);
	}	

}
