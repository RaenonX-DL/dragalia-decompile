/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePostEffectSettings : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public MyPageScene scene;
		private const int maxIrisCount = 8;
		private GameObject[] worldIrisObjects;
		private GameObject irisPointPrefab;
		private Vector2[] irisSize;
		private Color fogColor;
		private float fogStartDistance;
		private float fogEndDistance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPagePostEffectSettings __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPagePostEffectSettings();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public void ApplyToPostEffect(PostEffect effect, MyPagePostEffectParams param, Transform mapBase);
		public void UpdateMoveMapPostEffect(PostEffect effect, MyPagePostEffectParams param);
		public void UpdateSkitMapPostEffect(PostEffect effect, MyPagePostEffectParams param);
		public void Reset();
	}
}
