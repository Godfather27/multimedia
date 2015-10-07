using System;
using System.Collections.Generic;
using System.IO;

namespace Aufgabe01c {
	class MainClass {
		public static void Main (string[] args) {
			relativ_frequency ("article.txt", "output.csv");
		}

		public static void relativ_frequency (string filename, string outputfile){
			Dictionary<char, int> count = new Dictionary<char, int> ();
			string article="";
			double percent;
			try{
				using (StreamReader stream = new StreamReader (filename)) 
				{
					string line;
					while ((line = stream.ReadLine()) != null) 
					{
						article += line;
					}
				}
			} catch(FileNotFoundException){
				Console.WriteLine ("No Textfile Found, using standard text:");
			} catch(Exception e){
				Console.WriteLine (e.Message);
			}
			foreach (char letter in article) {
				if (!count.ContainsKey (letter))
					count.Add (letter, 1);
				else
					count [letter] = count [letter] + 1;
			}


			using (StreamWriter sw = new StreamWriter(outputfile))
			{
				foreach (var element in count) {
					percent = Math.Round(element.Value / (double)article.Length * 100, 2);
					Console.Out.WriteLine ("{0}\t{1,6:0.00}%", (int)element.Key, percent);
					sw.WriteLine ((int)element.Key + ";" + percent);
				}
			}
		}
	}
}
