/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	[RequireComponent]
	public class AutoLocalizeTextBinderBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public string localizeTextIdStr;
		public const int defaultFindFuzzyMax = 10;
	
		// Properties
		protected virtual string prefixType { get; set; }
	
		// Nested types
		private class StringFuzzyInfo
		{
			// Fields
			public string text;
			public int score;
			public int enumNum;
	
			// Constructors
			public StringFuzzyInfo(string text, int score, int enumNum);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public string prefixType;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _GetFuzzyList_b__1(StringFuzzyInfo x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<StringFuzzyInfo, int> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetFuzzyList_b__8_0(StringFuzzyInfo x);
		}
	
		// Constructors
		public AutoLocalizeTextBinderBase();
	
		// Methods
		public static int CalculateStringFuzzy(string leftString, string rightString);
		public static string FindLocalizeTextIdByText(string checkingText, string prefix, int findFuzzyMax, out List<string> fuzzyList, out List<int> matchingIds);
		public static List<string> GetFuzzyList(string checkingText, string prefixType, int findFuzzyMax, string[] texts = null);
		public void Reset();
		private void Awake();
		public void ApplyTextBySavedLocalizeTextId();
	}
}
