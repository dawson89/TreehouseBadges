using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TreehouseBadges
{
	class Program
	{
		static void Main(string[] args)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			DirectoryInfo directory = new DirectoryInfo(currentDirectory);
			var fileName = Path.Combine(directory.FullName, "dawson.json");
			var fileContents = ReadBadgeResults(fileName);			
		}

		public static string ReadFile(string fileName)
		{
			using (var reader = new StreamReader(fileName))
			{
				return reader.ReadToEnd();
			}
		}

		public static List<string[]> ReadBadgeResults(string fileName)
		{
			var badgeResults = new List<string[]>();
			using (var reader = new StringReader(fileName))
			{
				string line = "";
				while((line = reader.ReadLine()) != null)
				{
					string[] values = line.Split(',');
					badgeResults.Add(values);

				}
			}
			return badgeResults;
		}
	}
}
