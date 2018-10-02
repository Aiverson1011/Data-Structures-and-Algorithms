using System;

namespace reverseArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			string[] cats = { "Josie", "Belle", "Frodo", "Trinity", "Leia" };

			OutputArray(cats);
			Console.WriteLine("-----------");
			OutputArray(ArrayReverse(cats));
			Console.WriteLine("-------------");
			OutputArray(ReverseInPlace(cats));
		}

		/// <summary>
		/// Reverse an array with additional space and time
		/// </summary>
		/// <param name="myArray">string array to be reversed</param>
		/// <returns>Newly reversed array</returns>
		static string[] ArrayReverse(string[] myArray)
		{
			Console.WriteLine("Array Reverse");
			string[] reversed = new string[myArray.Length];
			int counter = 0;

			for (int i = myArray.Length - 1; i >= 0; i--)
			{
				reversed[i] = myArray[counter++];
			}
			return reversed;
		}


	}
}
