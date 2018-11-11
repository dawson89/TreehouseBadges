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

			//var files = directory.GetFiles();
			//foreach (var file in files)
			//{
			//	Console.WriteLine(file.Name);
			//}

			var FileName = Path.Combine(directory.FullName, "data.txt.");
			var file = new FileInfo(FileName);
			if (file.Exists)
			{
				//Allows dispose method to run so you don't have to run a close method
				using (var reader = new StreamReader(file.FullName))
				{
					Console.SetIn(reader);
					Console.WriteLine(Console.ReadLine());
				}

			}

		}
	}
}
