using System;
using System.Diagnostics;

namespace Aufgabe01a {
	class MainClass {
		
		public static void Main (string[] args) {
			Console.Out.Write ("Please enter your value: ");
			string input = Console.In.ReadLine ();
			Console.Out.Write ("Please enter the value's base: ");
			int inputBase = readInt ();
			Console.Out.Write ("Please enter the target base: ");
			int outputBase = readInt ();
			Console.Out.WriteLine ("\"{0}\" base:{1} = \"{2}\" base:{3}", input, inputBase, convertFromToBase (input, inputBase, outputBase), outputBase);
		}

		public static string convertFromToBase(string input, int inputBase, int outputBase){
			string result = "";
			int sum = int.Parse(input);
			if(inputBase != 10)
				sum = toDecimal(input, inputBase);

			while (sum != 0) {
				result = getChar(sum, outputBase) + result;
				sum /= outputBase;
			}

			return result;				
		}

		public static char getChar(int sum, int outputBase){
			if (sum % outputBase > 9) {
				return Convert.ToChar (sum % outputBase + 55);
			}
			return (sum % outputBase).ToString ()[0];
		}

		public static int toDecimal(string input, int inputBase){
			int sum = 0;

			Console.Out.WriteLine ("not base 10");
			for(int i = 0; i < input.Length; i++){
				int num;

				if ((int)Char.GetNumericValue (input [input.Length - 1 - i]) == -1) {
					num = (int)input.ToUpper () [input.Length - 1 - i] - 55;
				} else {
					num = (int)Char.GetNumericValue (input [input.Length - 1 - i]);
				}

				sum += num * (int)(Math.Pow (inputBase, i));
			}
			return sum;
		}

		public static int readInt(){
			int num;
			bool success = int.TryParse (Console.In.ReadLine (), out num);
			while (!success || num > 16 || num < 2) {
				Console.Out.WriteLine ("ERROR: you have to enter a number between 2 - 16");
				success = int.TryParse (Console.In.ReadLine (), out num);
			}
			return num;
		}
	}
}
