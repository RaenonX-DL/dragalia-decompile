/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TextLineWrap : MonoBehaviour
	{
		// Fields
		[Header]
		public bool changeOnlyOnce;
		[Header]
		public bool shrinkOnChange;
		private TextGenerator generator;
		private int changeCount;
		private const string targetBeginChars = "\uFF64\u3001\uFF61\u3002\\)\uFF09\\]\u300D\u300F\\}\u3011,\u3015\u3009\u300B\u301F\\\u2019\\\u201D\\.\u30FB";
	
		// Nested types
		[CompilerGenerated]
		private sealed class _SetupText_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TextLineWrap __4__this;
			private UnityEngine.UI.Text _text_5__2;
			private RectTransform _rectTransform_5__3;
			private float _originalWidth_5__4;
			private float _originalHeight_5__5;
			private int _i_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupText_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TextLineWrap();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		public IEnumerator SetupText();
		public static float GetProperWidthRecursively(TextGenerator generator, UnityEngine.UI.Text text, float width, float height, int maxRetryTime, int currentRetryTime, bool shrinkOnChange);
	}
}
