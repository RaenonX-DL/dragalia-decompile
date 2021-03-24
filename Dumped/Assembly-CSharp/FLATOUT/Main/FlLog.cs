/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlLog
	{
		// Fields
		private static bool _initialized;
		private static Hashtable _logTable;
		private static Hashtable _colorTable;
		private static Hashtable _titleTable;
	
		// Constructors
		public FlLog();
		static FlLog();
	
		// Methods
		private static void _Initialize();
		public static void _Log(FlLogTypes logType, FlLogColorTypes colorType, FlLogTitleTypes titleType, GameObject target);
		public static void _Log(FlLogTypes logType, string colorString, string title, GameObject target);
		public static void _Log(string content, string colorString, string title, GameObject target);
	}
}
