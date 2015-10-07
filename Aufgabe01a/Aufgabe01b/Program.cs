using System;
using System.Collections.Generic;

namespace Aufgabe01b {
	class MainClass {
		public static void Main () {
			string input = "010000101101101100111010010001000110101";
			try{
				Console.Out.WriteLine ("{0} = {1}", input, decode(input));
			} catch(Exception e) {
				Console.Out.WriteLine (e.Message);
			}
		}

		public static string decode(string input){
			checkInput (input);
			string output = "";
			int length = 2;
			Dictionary<string, char> cheatSheet = new Dictionary<string, char> (){
				{"01001",'A'}, {"10",'F'}, {"01000",'I'}, {"0111",'M'}, {"0101",'N'}, {"11",'O'}, {"0110",'R'}, {"00",'T'}
			};

			do {
				foreach (var letter in cheatSheet) {
					if (input.Substring (0, length) == letter.Key) {
						input = input.Substring (length, input.Length-length);
						output += letter.Value;
						length = 1;
						break;
					}
				}
				length++;
				if(length>5)
					throw new Exception ("input contains not known lettercodes");
			} while(input.Length > 0);

			return output;
		}

		public static void checkInput(string input){
			foreach (char letter in input) {
				if(letter!='0' && letter!='1')
					throw new Exception ("input contains forbidden characters");
			}
		}
	}
}