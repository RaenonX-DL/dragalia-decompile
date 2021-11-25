using System.Diagnostics;
using UnityEngine;

namespace Gluon
{
	public class ProfileChecker
	{
		[Conditional("UNITY_EDITOR")]
		[Conditional("PROFILE")]
		public static void BeginSample(string name)
		{
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("PROFILE")]
		public static void BeginSample(string name, Object targetObject)
		{
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("PROFILE")]
		public static void EndSample()
		{
		}
	}
}
