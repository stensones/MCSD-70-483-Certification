namespace ExampleCode.Chapter3
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class StructWithDefaultCtor
	{
		public StructWithDefaultCtor()
		{
			this.One = 3;
			this.Two = 69;
			this.Three = "a value";
		}

		public int One { get; set; }

		public int Two { get; set; }

		public string Three { get; set; }
	}
}
