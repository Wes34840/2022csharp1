using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ClassOefening // namespace
{
	internal class ClassStructureExercise // class
	{
		private readonly string accountName; // class variable

		internal ClassStructureExercise(string accountName) // constructor
		{
			this.accountName = accountName; // local variable
		}

		internal void ShowGreetingInConsole() //functie met function arguments
        {
			string greeting = "hello"; // local variable
			Console.WriteLine(greeting + " " + accountName); 
		}

		internal void Show1To10() // function
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i.ToString());
			}
		}

		internal double DistBetweenPoints(int x1, int y1, int x2, int y2) //functie met function arguments
        {

			int dx = x2 - x1; // local variable
			int dy = y2 - y1; // local variable

			double lengthSquared = (dx * dx) + (dy * dy); // local variable

			double length = Math.Sqrt(lengthSquared); // local variable
			return length;

		}
		internal int MultiplyToPower2(int value) // function met function arguments
		{
			int result = value * value; // local variable
			return result;
		}
		
		// private en internal zijn allebei access modifiers
	}
}




