using System;
using System.Collections.Generic;

namespace XLua
{
	public class MethodWrap
	{
		private string methodName;

		private List<OverloadMethodWrap> overloads;

		private bool forceCheck;

		public MethodWrap(string methodName, List<OverloadMethodWrap> overloads, bool forceCheck)
		{
		}

		public int Call(IntPtr L)
		{
			return default(int);
		}
	}
}
