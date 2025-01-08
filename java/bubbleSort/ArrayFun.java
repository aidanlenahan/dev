import java.io.*;

class ArrayFun 
{
  public static void main(String args[])
    throws java.io.IOException
  {
    BufferedReader inputStream = new BufferedReader(
        new InputStreamReader(System.in));

    int theInt;
    String inputLine = null;
    
    int [] intArray = new int[12];
    // int intArray[12]; // C Style
    
    for (int i = 0; i < intArray.length; i++)
    {
      System.out.print("Please enter an integer number: ");
      inputLine = inputStream.readLine();
      intArray[i] = Integer.parseInt(inputLine);
      System.out.println("You gave me: " + intArray[i]);
    }

    for (int i = 0; i < intArray.length; i++)
    {
      System.out.println(intArray[i]);
    }
  }
}

