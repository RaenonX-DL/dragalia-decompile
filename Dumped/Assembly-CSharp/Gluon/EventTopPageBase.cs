/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventTopPageBase : EventQuestPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		protected Image titleImage;
		[SerializeField]
		protected UnityEngine.UI.Text durationText;
		[SerializeField]
		protected GameObject eventEndDescription;
		[Header]
		[SerializeField]
		protected Button questListButton;
		[SerializeField]
		protected Button multiButton;
		[Header]
		[SerializeField]
		protected GameObject buttonsParent;
		[SerializeField]
		protected GameObject buttonsParent4;
		[Header]
		[SerializeField]
		protected EventCommonButtonCtrl commonButtonCtrl;
		[SerializeField]
		protected EventCommonButtonCtrl commonButtonCtrl4;
		[Header]
		[SerializeField]
		protected bool workaroundRefs271047;
		protected string voiceData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public MatchingTypeSelectPopup popup;
			public EventTopPageBase __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _ShowMultiJoinPopup_b__0();
			internal void _ShowMultiJoinPopup_b__1();
			internal void _ShowMultiJoinPopup_b__2();
			internal void _ShowMultiJoinPopup_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForStatusInfoInitilizing_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventTopPageBase __4__this;
			public AnimationUICanvas.AnimationPattern pattern;
			private CanvasGroup _canvasGroup_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStatusInfoInitilizing_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public bool hideStatusInfo;
			public EventTopPageBase __4__this;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _StartExitAnimation_b__0();
		}
	
		// Constructors
		public EventTopPageBase();
	
		// Methods
		protected void OnMissionButtonTouched();
		public override void OnPageBecomeActive(object data);
		protected virtual void Start();
		protected virtual void SetDurationText();
		public virtual void OnQuestButtonTouched();
		public void OnBackButtonTouched();
		public void OnMultiButtonTouched();
		private void ShowMultiJoinPopup();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void OnPageEnterAnimationEnded();
		protected virtual void OnBeginningPopupShown();
		public string UpdateVoiceData();
		[IteratorStateMachine]
		protected virtual IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		[CompilerGenerated]
		private bool _WaitForStatusInfoInitilizing_b__23_0();
	}
}
