/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CutSceneObj : MonoBehaviour
	{
		// Fields
		private EffectObject effect;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__1 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CutSceneObj __4__this;
			private CutSceneInitializer _initializer_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__1(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CutSceneObj();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public void PlaySound(string cueName);
		public void PlayEffect(string name);
		public void PlayEffectAttachPosition(string command);
		public void StopEffect(float life);
		public void DummyCall();
	}
}
