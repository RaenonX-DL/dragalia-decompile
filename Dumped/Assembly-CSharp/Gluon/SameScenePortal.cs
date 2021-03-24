/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SameScenePortal : SceneBase
	{
		// Fields
		public static string nextSceneName;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__1_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__1_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__1 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SameScenePortal __4__this;
	
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
		public SameScenePortal();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		private void OnDestroy();
	}
}
