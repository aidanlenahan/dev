
import java.io.*;

class input
{
 
  public static void main(String args[])
    throws java.io.IOException
  {
    BufferedReader inputStream = new BufferedReader(
        new InputStreamReader(System.in));

    int theInt;
    String inputLine = null;

    System.out.print("Gimme an integer number: ");
    inputLine = inputStream.readLine(); 
    theInt = Integer.parseInt(inputLine);
    System.out.println("You gave me: " + theInt);
  }
}
