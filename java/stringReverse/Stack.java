import java.util.*;

public class Stack 
{
	private int stackHeight = 0;
	// ArrayList goes here
	ArrayList <Character> list;
	
	public Stack()
	{
		list = new ArrayList<>();
	}
	private void printHeight()
	{
		System.out.println("stackHeight: " + stackHeight);
	}
 
	public boolean IsEmpty()
	{ 
		return(stackHeight == 0);
	}

	/* Puts one character on the stack  */
	/* Increments stackheight by 1      */
	public void Push(char theChar)
	{
		/* to do */
	}

	/* Pops one character off the stack and returns it */
	/* Decrements stackHeight by 1                     */
	public char Pop()
	{
		/* to do */
	}
}
