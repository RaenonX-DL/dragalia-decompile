/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameBgAlterChara : MonoBehaviour
	{
		// Fields
		private AudioPlayback voice;
		private string voiceGroupName;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public string voiceGroupName;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal bool _WaitForPlayTalkSound_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForPlayTalkSound_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string voiceGroupName;
			public OutGameBgAlterChara __4__this;
			public string voiceName;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForPlayTalkSound_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public OutGameBgAlterChara();
	
		// Methods
		private void OnDestroy();
		public void PlayTalkSound(string voiceGroupName, string voiceName);
		[IteratorStateMachine]
		private IEnumerator WaitForPlayTalkSound(string voiceGroupName, string voiceName);
	}
}
