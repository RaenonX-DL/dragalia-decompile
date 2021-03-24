/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class AisacController
	{
		// Fields
		private static Tweener _tweener;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public int index;
			public string controlName;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _FadeAisacControlValue_b__0(float value);
		}
	
		// Constructors
		static AisacController();
	
		// Methods
		public static void FadeAisacControlValue(int index, string controlName, float fadeFromValue, float fadeToValue, float fadeTime);
		private static void OnComplete();
		public static void ResetAisacControlValue(int index);
	}
}
