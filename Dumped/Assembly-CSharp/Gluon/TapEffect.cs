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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TapEffect : MonoBehaviour
	{
		// Fields
		public static float normalScale;
		public static float bigScale;
		public Image image;
		public bool isBig;
		private RectTransform rectTransform;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EffectCoroutine_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TapEffect __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EffectCoroutine_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TapEffect();
		static TapEffect();
	
		// Methods
		private void Awake();
		public void StartEffect(float x, float y);
		[IteratorStateMachine]
		private IEnumerator EffectCoroutine();
	}
}
