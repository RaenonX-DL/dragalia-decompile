/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EXRushTopPage : EventQuestPageBase, ICustomMessage
	{
		// Fields
		[Header]
		[SerializeField]
		public RectTransform bgFrame;
		public CanvasGroup bgCancvasGroup;
		public UIAnimationPublisher mainPublisher;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text eventTimeText;
		public UnityEngine.UI.Text friendshipNumText;
		public Slider friendshipGauge;
		public UnityEngine.UI.Text eventItemSCountText;
		public UnityEngine.UI.Text eventItemLCountText;
		[Header]
		[SerializeField]
		public GameObject stageSelect;
		public GameObject eventEndedText;
		[Header]
		[SerializeField]
		public ExRushTopCharaButton[] buttons;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text hint;
		public ButtonWithSelectedImage howtoButtonWithSelectedImage;
		private Coroutine loadBGCoroutine;
		private GameObject bgObj;
		private const string bgPrefabPath = "Prefabs/OutGame/EventQuest/21801/ExRushTopBG";
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadBGObj_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EXRushTopPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBGObj_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _OnBackButtonTouched_d__26 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			private TouchGuardObject __7__wrap1;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public EXRushTopPage();
	
		// Methods
		protected override void Awake();
		public override void OnPageBecomeActive(object data);
		[IteratorStateMachine]
		private IEnumerator LoadBGObj();
		public override void OnPageBecomeInActive();
		public override void OnPageEnterAnimationEnded();
		private void UpdateTopInfo();
		public override void OnPresentReceived();
		private void UpdateHint();
		public void OnHelpButtonPressed();
		private void Start();
		public async void OnBackButtonTouched();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _LoadBGObj_b__18_0(GameObject obj);
		[CompilerGenerated]
		private bool _LoadBGObj_b__18_1();
		[CompilerGenerated]
		private void _OnHelpButtonPressed_b__24_0();
	}
}
