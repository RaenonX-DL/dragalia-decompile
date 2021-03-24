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
	public class EnableComponentLater : MonoBehaviour
	{
		// Fields
		public MonoBehaviour componentToDelayEnable;
		public int delayFrame;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__3 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EnableComponentLater __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__3(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EnableComponentLater();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
	}
}
