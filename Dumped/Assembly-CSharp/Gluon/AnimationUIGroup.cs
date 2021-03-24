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
	public class AnimationUIGroup : AnimationUIPartBase
	{
		// Fields
		public GameObject[] targets;
		[SerializeField]
		public float delayInterval;
		[SerializeField]
		private bool shouldReverseDelayInterval;
		private IEnumerator coroutine;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForFinished_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float time;
			public AnimationUIGroup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForFinished_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AnimationUIGroup();
	
		// Methods
		public override void Init();
		public void UpdateDelayTime();
		public override void Execute(bool isReverse = false);
		[IteratorStateMachine]
		private IEnumerator WaitForFinished(float time);
		public override void Kill();
	}
}
