import java.io.*;


class Pyramid
{
	public static void main(String[] args)
	{
		int pyramidSize = 5;
		System.out.println("What is the size of the pyramid?");
		
		//define 'input' variable'
		for (int i =1; i <= pyramidSize; i++) {
			for (int j=1; j <= i; j++) {
				System.out.print("*");
			}
			System.out.print("\n");
		}
		for (int i =pyramidSize; i >=0; i--) {
			for (int j=pyramidSize; j >=0; j--) {
			       System.out.print("*");
			}
	 		System.out.print("\n");
		}		
	}
}
