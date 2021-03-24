/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BootScene : MonoBehaviour
	{
		// Fields
		private static bool isScreenInitialized;
		private static bool isMessagePackInitialized;
		private int screenHeight;
		private NPFEventHandlerImpl NPFEventhandler;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<string, string> __9__4_0;
			public static UnityAction __9__6_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Initialize_b__4_0(string error, string trace);
			internal void _Awake_b__6_0();
		}
	
		[CompilerGenerated]
		private sealed class _GameStart_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BootScene __4__this;
			private AndroidStatusBarController _statusBar_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GameStart_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoNextScene_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoNextScene_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BootScene();
		static BootScene();
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize();
		public static void SetMessagePackRegister();
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator GameStart();
		[IteratorStateMachine]
		private IEnumerator GotoNextScene();
		private void InitializeDebug();
	}
}
