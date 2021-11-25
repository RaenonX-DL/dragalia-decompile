using System;

namespace XLua
{
	public class GCOptimizeAttribute : Attribute
	{
		private OptimizeFlag flag;

		public OptimizeFlag Flag => default(OptimizeFlag);

		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default)
		{
		}
	}
}
