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
	public class LocalizeScriptableObject : ScriptableObject
	{
		// Fields
		public string[] texts;
		[CompilerGenerated]
		private static Func<string, string[]> _LoadForEditorEvent_k__BackingField;
	
		// Properties
		public static Func<string, string[]> LoadForEditorEvent { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public LocalizeScriptableObject();
	
		// Methods
		public static string[] Load(string region);
	}
}
