/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RetryMain : SceneBase
	{
		// Fields
		private bool isHost;
		private int questId;
		private int lastQuestStartPlayerCount;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__3_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__3_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__3 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public RetryMain __4__this;
	
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
	
		[CompilerGenerated]
		private sealed class _LoadSceneMulti_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public RetryMain __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSceneMulti_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction close;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _PopupHostExitConfirmCreate_b__0();
		}
	
		// Constructors
		public RetryMain();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnEnterScene();
		[IteratorStateMachine]
		private IEnumerator LoadSceneMulti();
		private void Disconnect();
		private bool CheckError();
		private void PopupHostExitConfirmCreate(UnityAction close = null);
		public void LoadBeforeQuestScene();
		private string GetNextSceneName();
		[CompilerGenerated]
		private void _LoadSceneMulti_b__5_0();
		[CompilerGenerated]
		private void _CheckError_b__7_0(MultiPlayError.ErrorType error);
		[CompilerGenerated]
		private void _CheckError_b__7_1();
		[CompilerGenerated]
		private void _CheckError_b__7_2();
	}
}
