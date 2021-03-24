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
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PettingBalloon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public GameObject uiBalloon;
		public UnityEngine.UI.Text uiBalloonText;
		public AnimationUITalkWindow talkWindowAnimation;
		public DragonStrokeMain strokeMain;
		public float minimumBalloonSkipableTime;
		public float blockNextBalloonTime;
		private Coroutine showWindowCoroutine;
		private string voiceName;
		private float delay;
		private Action onVoiceDone;
		private string message;
		private float minimumDisplayTime;
		private const float defaultMinimumBalloonDisplayTime = 3f;
		public const float greetingBalloonDelayTime = 0.85f;
		private bool showingBalloon;
		private bool skipButtonClicked;
		private bool skippable;
		private bool blockNextBalloon;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public PettingBalloon __4__this;
			public bool isVoiceDone;
			public bool minimumWaitDone;
			public bool exitDone;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _ShowTalkWindowCoroutine_b__0();
			internal void _ShowTalkWindowCoroutine_b__7();
			internal void _ShowTalkWindowCoroutine_b__1();
			internal void _ShowTalkWindowCoroutine_b__2();
			internal bool _ShowTalkWindowCoroutine_b__3();
			internal bool _ShowTalkWindowCoroutine_b__4();
			internal void _ShowTalkWindowCoroutine_b__5();
			internal bool _ShowTalkWindowCoroutine_b__6();
		}
	
		[CompilerGenerated]
		private sealed class _ShowTalkWindowCoroutine_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PettingBalloon __4__this;
			public bool closeAndReOpen;
			private __c__DisplayClass20_0 __8__1;
			public bool ignoreDelay;
			private AudioPlayback _playBack_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowTalkWindowCoroutine_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PettingBalloon();
	
		// Methods
		public bool IsBalloonDisplay();
		public void StartBalloon(string message, string voiceName, float delayTime = 0f, Action onVoiceDone = null, float minimumDisplayTime = -1f, bool ignoreDelay = false);
		[IteratorStateMachine]
		private IEnumerator ShowTalkWindowCoroutine(bool closeAndReOpen, bool ignoreDelay);
		public void StopBalloon();
		public void OnButtonPressed();
		[CompilerGenerated]
		private void _StartBalloon_b__19_0();
	}
}
