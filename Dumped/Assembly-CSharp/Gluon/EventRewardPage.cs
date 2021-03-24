/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRewardPage : EventQuestPageBase, ICustomMessage
	{
		// Fields
		private TabViewBase tabView;
		[SerializeField]
		private EventRewardTabButton[] tabButtons;
		[SerializeField]
		private Button receiveAllButton;
		[SerializeField]
		private EventRewardCtrl bronzeCtrl;
		[SerializeField]
		private EventRewardCtrl silverCtrl;
		[SerializeField]
		private EventRewardCtrl goldCtrl;
		private bool isInited;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__18_1;
			public static UnityAction __9__18_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnReceipAllButtonTouched_b__18_1();
			internal void _OnReceipAllButtonTouched_b__18_3();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForInitialzing_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventRewardPage __4__this;
			public AnimationUICanvas.AnimationPattern pattern;
			public Action onAnimationDone;
			public Action onCutOff;
			private CanvasGroup _canvasGroup_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForInitialzing_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventRewardPage();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override void OnPageEnterAnimationEnded();
		private void Start();
		protected override void OnDestroy();
		private void SetTabPage(int index);
		public void UpdateReceivedItems();
		public void UpdateReceiveButtonInformation();
		public void SetContent();
		public void OnBackButtonTouched();
		public void UpdateTabButtons(int curIndex);
		public void OnReceipAllButtonTouched();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitForInitialzing(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[CompilerGenerated]
		private void _Start_b__10_0(int curIndex, int preIndex);
		[CompilerGenerated]
		private void _OnReceipAllButtonTouched_b__18_0(RaidEventReceiveRaidPointRewardResponse response);
		[CompilerGenerated]
		private void _OnReceipAllButtonTouched_b__18_2(ExHunterEventReceiveExHunterPointRewardResponse response);
		[CompilerGenerated]
		private bool _WaitForInitialzing_b__21_0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(AnimationPattern pattern, Action onAnimationDone, Action onCutOff);
	}
}
