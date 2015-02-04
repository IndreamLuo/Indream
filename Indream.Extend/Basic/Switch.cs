using Indream.Extend.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indream.Extend
{
	public static partial class BasicExtend
	{
		public static SwitchResult<T> Case<T>(this T @object)
		{
			return new SwitchResult<T>(@object);
		}

		public static SwitchResult<T> Case<T>(this SwitchResult<T> @switch, T value, Action action)
		{
			throw new NotImplementedException();

			//if (@switch.Object == value)
			//{
			//	action();
			//}

			return @switch;
		}
	}
}
