using System;
					
public class Program
{
	
	public static string Reverse(string str) //to reverse a string
	{
		string reverseString =" ";
		int Length= str.Length-1;
		for(int i=0; Length >= i; Length--)
		{
			reverseString += str[Length];
		}	
		return reverseString;
	}
	public static void println(string str2)
	{
		 Console.WriteLine(str2);
	}
	public static bool IsPalindrom(string str)
	{
	       StringBuilder builder = new StringBuilder();
		foreach(char c in str)
        {
            if(char.IsLetterOrDigit(c))
            {
                builder.Append(c.ToString().ToLower());
            }
        }
                string strToCheck = builder.ToString();

		int r = strToCheck.Length -1;
		int l = 0;
		while(l <= r)
		{
			if(strToCheck[l] != strToCheck[r])
			   {
				   println(" not valid palindrome");
				   return false;
			   }
			   l++;
			   r--;
		}		
	println("valid  palindrome");
	return true;
	}	
	public static void Main()
	{
		println("enter string: ");
		string str1 = Console.ReadLine();	
		println(Reverse(str1));
		IsPalindrom(str1);

	}
	
}