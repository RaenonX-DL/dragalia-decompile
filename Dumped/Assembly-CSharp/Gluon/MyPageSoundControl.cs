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
	public class MyPageSoundControl : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private long _playTime_k__BackingField;
		private AudioPlayback bgmPlayback;
		private float bgmLoopTime;
	
		// Properties
		public long playTime { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Play_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageBgmSyncSettings.Entry currBgmSyncSetting;
			public MyPageSoundControl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Play_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPageSoundControl();
	
		// Methods
		[IteratorStateMachine]
		public IEnumerator Play(MyPageBgmSyncSettings.Entry currBgmSyncSetting);
		public long GetBgmPlayTime();
		public static void PlayMyPageBgm();
		public static void ReselectMyPageBgm();
	}
}
