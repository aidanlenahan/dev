//Aidan Lenahan
//This file is depended on by Main.java

import java.util.*;

public class Stack 
{
	private int stackHeight = 0;
	char mostRecent;
	ArrayList<Character> revStringStack;

	public Stack()
	{
		revStringStack = new ArrayList<Character>();
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
		revStringStack.add(theChar);
		stackHeight++;		
	}

	/* Pops one character off the stack and returns it */
	/* Decrements stackHeight by 1                     */
	public char Pop() //stack log
	{
		stackHeight--;
		mostRecent = revStringStack.remove(revStringStack.size() - 1);
		return mostRecent;
	}
}
