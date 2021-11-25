using System;
using System.Collections.Generic;

namespace XLua
{
	public static class SysGenConfig
	{
		[GCOptimize(OptimizeFlag.Default)]
		private static List<Type> GCOptimize => null;

		[AdditionalProperties]
		private static Dictionary<Type, List<string>> AdditionalProperties => null;
	}
}
