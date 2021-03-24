/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class ProjectPrefs : ScriptableObject
	{
		// Fields
		private static ProjectPrefs instance;
		[SerializeField]
		private List<KeyValuePair> prefs;
	
		// Properties
		private static ProjectPrefs Instance { get; }
		public static bool IsReady { get; }
	
		// Nested types
		[Serializable]
		private class KeyValuePair
		{
			// Fields
			public string key;
			public string value;
	
			// Constructors
			public KeyValuePair();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public string key;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _GetString_b__0(KeyValuePair p);
		}
	
		// Constructors
		public ProjectPrefs();
	
		// Methods
		public static string GetString(string key);
		public static string GetString(string key, string defaultValue);
	}
}
