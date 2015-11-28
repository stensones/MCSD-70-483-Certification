using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chapter3
{
	public class Class3
	{
		public void Method1()
		{
			var two = float.Parse("£1,320", NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands);
			Console.WriteLine(two);

			var cult = CultureInfo.GetCultureInfo("en-US");
			Thread.CurrentThread.CurrentCulture = cult;
			// fails without above line
			var one = float.Parse("$3,321", NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands);
			Console.WriteLine(one);
		}
	}
}
