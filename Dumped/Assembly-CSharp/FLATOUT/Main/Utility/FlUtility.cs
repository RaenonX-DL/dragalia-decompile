/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlUtility
	{
		// Constructors
		public FlUtility();
	
		// Methods
		public static FlRoot GetRoot(GameObject rootObject, bool fromChildren = false);
		public static GameObject Find(GameObject rootObject, string path, bool fullMatch = false);
		public static T Find<T>(GameObject rootObject, string path, bool fullMatch = false)
			where T : Component;
		public static T FindUI<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false)
			where T : FlBase;
		private static GameObject FindLoop(GameObject rootObject, string name, int searchDepth, bool fullMatch);
		public static string GetObjectPath(GameObject target, GameObject rootObject, bool withoutUIObj = false, bool start = true);
	}
}
