/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameBgChara : AnimationUIBase, ICustomMessage
	{
		// Fields
		public DifferenceImageController imageCtrl;
		public string assetPath;
		public bool isAutoInit;
		public bool isLipSyncOnStart;
		protected Tweener eyeBlinkTween;
		protected Tweener lipSynchTween;
		protected const float DefaultEyeBlinkIntervalMin = 2f;
		protected const float DefaultEyeBlinkIntervalMax = 5f;
		protected const float DefaultEyeBlinkingTime = 0.05f;
		protected const float DefaultLipSynchIntervalMin = 0.06666667f;
		protected const float DefaultLipSynchIntervalMax = 0.06666667f;
		protected const float DefaultLipSynchingTime = 0.1f;
		protected float eyeBlinkIntervalMin;
		protected float eyeBlinkIntervalMax;
		protected float eyeBlinkingTime;
		protected float lipSynchIntervalMin;
		protected float lipSynchIntervalMax;
		protected float lipSynchingTime;
		protected bool isLipSynch;
		public AudioPlayback voice;
		private string voiceGroupName;
		private Coroutine waitCoroutine;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public OutGameBgChara __4__this;
			public Action<bool> onCompleted;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _InitDifferenceImage_b__0(DifferenceImageObject obj);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__31_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitWhileVoicePlay_b__31_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitWhileVoicePlay_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OutGameBgChara __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitWhileVoicePlay_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public OutGameBgChara();
	
		// Methods
		private void Start();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		private void RemoveCharaVoiceGroup();
		private void OnDestroy();
		public void Init(string path, Action<bool> onCompleted);
		protected void InitDifferenceImage(string path, Action<bool> onCompleted);
		public override void StartExitAnimation(Action onAnimationDone = null);
		public void ShowDifference(bool show);
		public void DoLipSynch();
		[IteratorStateMachine]
		private IEnumerator WaitWhileVoicePlay();
		private void SetEyeBlink();
		private void SetLipSynch();
		public void PlayTalkSound(string voiceGroupName, string voiceName);
		[CompilerGenerated]
		private void _SetEyeBlink_b__32_0();
		[CompilerGenerated]
		private void _SetEyeBlink_b__32_1();
		[CompilerGenerated]
		private void _SetLipSynch_b__33_0();
		[CompilerGenerated]
		private void _SetLipSynch_b__33_1();
	}
}
