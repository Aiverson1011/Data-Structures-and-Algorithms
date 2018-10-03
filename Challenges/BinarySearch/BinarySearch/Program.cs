using System;

namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		/// <summary>
		/// Iteratively get index from a sorted array using binary search
		/// </summary>
		/// <param name="binaryArray">sorted binary array</param>
		/// <param name="value">value to search for</param>
		/// <returns>the index of the array</returns>
		static int BinarySearchIterative(int[] binaryArray, int value)
		{
			int minimum = 0;
			int last = binaryArray.Length - 1;

			while (minimum <= last)
			{
				//recalculate the middle portion
				int middle = (minimum + last) / 2;

				if (value > binaryArray[middle])
				{
					// if value is larger than the middle, then we increase
					// minimum number to be one larger than the middle
					minimum += middle++;

				}
				else if (value < binaryArray[middle])
				{
					// if the value is less than the middle, then place the last position
					// to one minus the middle index. 
					last = middle--;
				}
				else
				{
					// return the middle index + 1 to get the actual index number
					return ++middle;
				}
			}

			return -1;
		}

		static int BinarySearchRecursive(int[] binaryArray, int value)
		{



			return -1;
		}
	}
}
