/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestDetailCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private EventQuestDetailHeader eventDetailBanner;
		[SerializeField]
		private Image questBg;
		[SerializeField]
		private float questBgFadeinTime;
		[SerializeField]
		private float questBgFadeoutTime;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public bool eventDetailBannerLoaded;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _SetQuestEventCoroutine_b__0();
			internal bool _SetQuestEventCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetQuestEventCoroutine_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestDetailCanvas __4__this;
			public int eventId;
			public Clb01EventLocationElement location;
			public Action onCompleted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetQuestEventCoroutine_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public bool eventDetailBannerLoaded;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _SetQuestEventCoroutine_b__0();
			internal bool _SetQuestEventCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetQuestEventCoroutine_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventQuestDetailCanvas __4__this;
			public int eventId;
			public CombatEventLocationElement location;
			public Action onCompleted;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetQuestEventCoroutine_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventQuestDetailCanvas();
	
		// Methods
		private void Start();
		public void ShowScreenshotBackImage();
		public void HideScreenshotBackImage();
		public void SetQuestEventGroup(int eventId, Clb01EventLocationElement location, Action onCompleted);
		[IteratorStateMachine]
		private IEnumerator SetQuestEventCoroutine(int eventId, Clb01EventLocationElement location, Action onCompleted);
		public void SetQuestEventGroup(int eventId, CombatEventLocationElement location, Action onCompleted);
		[IteratorStateMachine]
		private IEnumerator SetQuestEventCoroutine(int eventId, CombatEventLocationElement location, Action onCompleted);
		public void SetQuestBanner(int eventId, int topImageId);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void OnSupportPageActive();
		public void OnSupportPageExitAnimation();
		public void BackButtonPressed();
		[CompilerGenerated]
		private void _HideScreenshotBackImage_b__6_0();
	}
}
