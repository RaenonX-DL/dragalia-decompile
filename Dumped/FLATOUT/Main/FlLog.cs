using System.Collections;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlLog
	{
		private static bool _initialized;

		private static Hashtable _logTable;

		private static Hashtable _colorTable;

		private static Hashtable _titleTable;

		private static void _Initialize()
		{
		}

		public static void _Log(FlLogTypes logType, FlLogColorTypes colorType, FlLogTitleTypes titleType, GameObject target)
		{
		}

		public static void _Log(FlLogTypes logType, string colorString, string title, GameObject target)
		{
		}

		public static void _Log(string content, string colorString, string title, GameObject target)
		{
		}
	}
}
