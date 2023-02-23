using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ClassOefening
{
	internal class ShopGreeter
	{
		private string greeting;
		internal ShopGreeter()
        {
			greeting = "Welcome customer! Please buy many many items!";

		}
		internal void GreetCustomer()
		{
			Console.WriteLine(greeting);
		}


	}
}




