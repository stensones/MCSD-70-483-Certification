using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter9
{
    public class CustomCollection : CollectionBase
	{
		public int this[int index]
		{
			get
			{
				return (int)this.List[index];
			}

			set
			{
				this.List[index] = value;
			}
		}

		int Add(int value)
		{
			return this.List.Add(value);
		}

		public int IndexOf(int value)
		{
			return (this.List.IndexOf(value));
		}

		public void Insert(int index, int value)
		{
			this.List.Insert(index, value);
		}

		public void Remove(int value)
		{
			this.List.Remove(value);
		}
		public bool Contains(int value)
		{
			// If value is not of type Int16, this will return false.
			return (this.List.Contains(value));
		}

		protected override void OnValidate(object value)
		{
			if (typeof(int) != value.GetType())
			{
				throw new InvalidOperationException("value is not an int");
			}

			base.OnValidate(value);
		}
	}
}
