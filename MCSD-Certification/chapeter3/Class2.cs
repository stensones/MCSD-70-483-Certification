using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
	class Class2
	{
		private void Method1()
		{
			var one = 1;
			var two = 2;

			if (one != two)
				return;

			one = two;
		}
	}
}
