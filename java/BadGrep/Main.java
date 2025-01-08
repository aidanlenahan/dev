// Aidan Lenahan
// AP CS A
// 11.09.24
// This program takes an input file (specified in the first argument) and finds and replaces all instances of a letter (specified in the second argument)
// and replaces it with another character (specified in the third argument). The file then prints all changes to the terminal and to a file called output.txt
import java.io.File;
import java.util.Scanner;
import java.io.FileWriter;
import java.io.Writer;

public class Main 
{
	public static void main(String[] args) throws Exception
	{
		//error checking
		if (args.length < 3)
		{
			System.out.println("Usage: java Main <inputFile> <charToReplace> <replacementChar>");
			return;
		}
		
		//parse args
		String filePath = args[0];
		char charToReplace = args[1].charAt(0);
		char replacementChar = args[2].charAt(0);

		// pass the path to the file as a parameter
		File inputFile = new File(filePath);
		Scanner sc = new Scanner(inputFile);
		Writer theWriter = new FileWriter("output.txt");
	 
		//replace characters and print modified
		while (sc.hasNextLine())
    		{
    			String line = sc.nextLine();
    			//System.out.println(line);
    			String modifiedLine = line.replace(charToReplace, replacementChar);
			System.out.println(modifiedLine); //print to term
			theWriter.write(modifiedLine);
    			theWriter.write("\n");
		}

		//close
		theWriter.close();
		sc.close();
		System.out.println("\n\nChanges made to output.txt");
	}
}

