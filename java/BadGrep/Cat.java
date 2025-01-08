// Java Program to illustrate
// reading from Text File
// using Scanner Class
import java.io.File;
import java.util.Scanner;
import java.io.FileWriter;
import java.io.Writer;

public class Cat 
{
	public static void main(String[] args) throws Exception
	{
		int i;

    		for (i = 0; i < args.length; i++)
    		{
			System.out.println("args[" + i + "] = " + args[i]);
		}

		// pass the path to the file as a parameter
		File file = new File(args[0]);
		Scanner sc = new Scanner(file);
		Writer theWriter = new FileWriter("output.txt");
	 
		while (sc.hasNextLine())
    		{
    			String temp = sc.nextLine();
    			System.out.println(temp);
    			theWriter.write(temp);
    			theWriter.write("\n");
		}
		theWriter.close();
	}
}

