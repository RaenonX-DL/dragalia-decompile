using System;
using UnityEngine;

namespace Cute.Core
{
	public static class TimeNativePlugin
	{
		private static AndroidJavaClass ajc;

		static TimeNativePlugin()
		{
		}

		public static TimeSpan GetElapsedTimeSinceStartUp()
		{
			return default(TimeSpan);
		}
	}
}
