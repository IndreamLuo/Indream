using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indream.Extend.Basic
{
	public class SwitchResult<T>
	{
		public SwitchResult(T @object)
		{
			this.Object = @object;
		}

		public T Object { get; private set; }
	}
}
