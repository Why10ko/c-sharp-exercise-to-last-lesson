using System;

// Задача 1 --------------------------------------------------------

	// public class Program 
	// {
	// 	public static void Main(string [] arg)
	// 	{
	// 		Console.Write("Введи N: ");
	// 		int N = Convert.ToInt32(Console.ReadLine());
	// 		Console.Write("Введи M: ");
	// 		int M = Convert.ToInt32(Console.ReadLine());
	// 		if (N < M) {
	// 			Console.Write(GetSummaRec(N, M));
	// 		}	else {
	// 			Console.Write("Первое число должно быть меньше второго");	
	// 		}
			
	// 	}
	// 	public static int GetSummaRec(int N, int M)
	// 	{	
	// 		if(N == M) 
	// 		{
	// 			return N;
	// 		}
	// 			return N + GetSummaRec(N + 1, M);
	// 	}
	// }


	// Задача 2 --------------------------------------------------------

	// public class Program 
	// {
	// 	public static void Main(string [] arg)
	// 	{
	// 		Console.Write("Введи N: ");
	// 		int N = Convert.ToInt32(Console.ReadLine());
	// 		Console.Write("Введи M: ");
	// 		int M = Convert.ToInt32(Console.ReadLine());
	// 		if (N >= 0 && M >= 0) {
	// 			Console.Write(funcAckermann(N, M));
	// 		}	else {
	// 			Console.Write("Первое число должно быть меньше второго");	
	// 		}
	// 	}
	// 	public static int funcAckermann(int N, int M)
  //   {
  //       if (N == 0) return M + 1;
  //       if (M == 0) return funcAckermann(N - 1, 1);
  //       return funcAckermann(N - 1, funcAckermann(N, M - 1));
  //   }
	// }

	// Задача 3 --------------------------------------------------------

	// public class Program 
	// {
	// 	static void Main(string [] args)
	// 	{
	// 		int[] arr = {1,2,3,4,5};
	// 		ReverseArr(arr, arr.Length-1);
	// 	}
	// 	static void ReverseArr(int[] arr, int i)
  //   {
  //     if(i < 0 ) return;
	// 			Console.WriteLine(arr[i]);
	// 			ReverseArr(arr,i - 1);	
  //   }
	// }
