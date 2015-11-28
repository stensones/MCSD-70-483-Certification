using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class Class1
    {
		internal enum Things
		{
			One = 23,
			Two,
			three
		}

		[Flags]
		internal enum BadBeasts
		{
			None,
			Cows,
			Sheep,
			Pigs,
			Dogs
		}

		[Flags]
		internal enum GoodBeasts
		{
			None,
			Cows = 1,	// values ensure we can bit flag combine values as [flags] implies and get parts back out!
			Sheep = 2,
			Pigs = 4,
			Dogs = 8
		}
	}
}
