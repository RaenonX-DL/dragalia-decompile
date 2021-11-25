using System;
using System.Runtime.CompilerServices;

namespace Cute.Master
{
	public class MasterLoader
	{
		public static event Action<Type> OnLoadRequest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void RequestLoadMaster(Type type)
		{
		}
	}
}
