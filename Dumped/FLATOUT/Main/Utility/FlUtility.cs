using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlUtility
	{
		public static FlRoot GetRoot(GameObject rootObject, bool fromChildren = false)
		{
			return null;
		}

		public static GameObject Find(GameObject rootObject, string path, bool fullMatch = false)
		{
			return null;
		}

		public static T Find<T>(GameObject rootObject, string path, bool fullMatch = false) where T : Component
		{
			return null;
		}

		public static T FindUI<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false) where T : FlBase
		{
			return null;
		}

		private static GameObject FindLoop(GameObject rootObject, string name, int searchDepth, bool fullMatch)
		{
			return null;
		}

		public static string GetObjectPath(GameObject target, GameObject rootObject, bool withoutUIObj = false, bool start = true)
		{
			return null;
		}
	}
}
