/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class MasterLabel
	{
		// Fields
		private const string jstTimeStartLabel = "<Time_JST=\"";
		private const string timeEndLabel = "\">";
	
		// Methods
		public static string Get(string id);
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize();
		public static string ConvertToLocalTime(string targetText);
	}
}
