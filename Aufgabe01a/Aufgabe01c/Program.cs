using System;
using System.Collections.Generic;
using System.IO;

namespace Aufgabe01c {
	class MainClass {
		public static void Main (string[] args) {
			try{
				relativ_frequency ("article.txt", "output.csv");
			} catch(Exception e){
				Console.WriteLine (e.Message);
			}
		}

		public static void relativ_frequency (string filename, string outputfile){
			Dictionary<char, int> count = new Dictionary<char, int> ();
			double percent;

			string article = readFile (filename);

			// Count Letters
			foreach (char letter in article) {
				if (!count.ContainsKey (letter))
					count.Add (letter, 1);
				else
					count [letter] = count [letter] + 1;
			}

			// write file
			using (StreamWriter sw = new StreamWriter(outputfile))
			{
				List<double> percentages = new List<double> ();
				foreach (var element in count) {
					percent = Math.Round(element.Value / (double)article.Length * 100, 2);
					percentages.Add (percent);

					Console.Out.WriteLine ("{0}\t{1,6:0.00}%", (int)element.Key, percent);
					sw.WriteLine ((int)element.Key + ";" + percent + ";" + element.Key);
				}
				Console.Out.WriteLine("Entropie: {0}",entropy (percentages));
				sw.WriteLine("Entropie:;{0}",entropy (percentages));
			}
		}

		public static double entropy(List<double> percentages){
			double sum=0;
			foreach (double percent in percentages) {
				sum += (percent/100) * Math.Log (1 / (percent/100));
			}
			return sum;
		}

		public static string readFile(string filename){
			using (StreamReader stream = new StreamReader (filename)) 
			{
				string line;
				string article="";
				while ((line = stream.ReadLine()) != null) 
				{
					article += line;
				}
				return article;
			}
		}
	}
}
