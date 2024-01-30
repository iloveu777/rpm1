using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
	internal class Program
	{
		public static int Factorial(int n)
		{
			int result = 1;
			for (int i = 2; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}
		static void FindSumPair(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					int sum = array[i] + array[j];


					if (sum % 2 == 0)
					{
						WriteLine($"Пара элементов с суммой {sum}: ({array[i]}, {array[j]})");
					}
				}
			}
		}
		public static double Powxx(int x)
		{
			return Math.Pow(x, x);


		}
		public static double AvgSumArray(int[] array)
		{
			double sum = 0;
			foreach (int i in array)
			{
				sum += i;
			}
			return sum / array.Length;

		}
		public static int Arrangements(int n, int m)
		{
			return Factorial(n) / (Factorial(m) * Factorial(n - m));
		}
		public static int FindTriple(int[] array)
		{
			int count = 0;

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					for (int k = j + 1; k < array.Length; k++)
					{
						if (array[i] + array[j] == array[k] ||
							array[j] + array[k] == array[i] ||
							array[k] + array[i] == array[j])
						{
							count++;
						}
					}
				}
			}

			return count;
		}
		
		static void ArrangeArr(int[] array)
		{
			int[] sortedArray = new int[array.Length];
			int evenIndex = 0;
			int oddIndex = 1;

			Array.Sort(array);

			foreach (var element in array)
			{
				if (element % 2 == 0)
				{
					sortedArray[evenIndex] = element;
					evenIndex += 2;
				}
				else
				{
					sortedArray[oddIndex] = element;
					oddIndex += 2;
				}
			}

			Array.Copy(sortedArray, array, array.Length);
		}
		static void Swap(int[] array, int index1, int index2)
		{
			int temp = array[index1];
			array[index1] = array[index2];
			array[index2] = temp;
		}
		public static int[] FindSquareElements(int[] array)
		{
			int[] resultArray = new int[array.Length];
			int resultIndex = 0;

			for (int i = 0; i < array.Length; i++)
			{
				int currentElement = array[i];
				int square = currentElement * currentElement;

				for (int j = 0; j < array.Length; j++)
				{
					if (j != i && array[j] == square)
					{
						resultArray[resultIndex++] = array[j];
						break; 
					}
				}
			}

			int[] finalResultArray = new int[resultIndex];
			Array.Copy(resultArray, finalResultArray, resultIndex);

			return finalResultArray;
		}
		static void Main(string[] args)
		{

			// WriteLine(Factorial(4)); // 1а
			//2
			/*
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			FindSumPair(array);
			*/
			//3
			/*
			WriteLine(Powxx(5));*/
			//4
			/*
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			WriteLine(AvgSumArray(array));*/
			//5
			/*
			WriteLine(Arrangements(3, 5));
			*/
			//6 
			/*
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int a = array.Max();
			WriteLine(a);*/
			// 10
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//WriteLine(FindTriple(array));
			//11
			/*
			ArrangeArr(array);
			foreach (var element in array)
			{
				WriteLine(element);
			}
			*/
			//12
			/*
			int[] ResultArr = FindSquareElements(array);

			foreach (int i in ResultArr)
			{
				WriteLine(i);
			}*/
			//13

			ReadKey();
		}
	}
}


