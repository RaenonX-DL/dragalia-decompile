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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FEHQuestMapPage : EventQuestPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Image bgImage;
		public Image fadeImage;
		public AnimationUIBg bgAnimation;
		public UIAnimationPublisher mainPublisher;
		[Header]
		[SerializeField]
		public Transform miniCharaParentNode;
		public FEHQuestMapMiniCharaButton miniCharaButtonTemplate;
		public FlashPlayerManager flashPlayerManager;
		private FlashPlayer[] miniCharaFlashPlayers;
		private Transform[] miniCharaMoveTransforms;
		private List<int> miniCharaDisplayOrder;
		private CanvasGroup bgCanvasGroup;
		private static float locSizeScale;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EnterAnimationCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FEHQuestMapPage __4__this;
			private TouchGuardObject _touchGuard_5__2;
			private int _i_5__3;
			private int _index_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnterAnimationCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _CheckSecondHarlPopup_b__0();
		}
	
		// Constructors
		public FEHQuestMapPage();
		static FEHQuestMapPage();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		private QuestUtil.QuestState GetLocationState(bool isEventEnded, int locationId);
		private void LoadMiniChara();
		private void OnMiniCharaTouched(int masterIndex);
		private void TakeScreenshot();
		public void OnBackFromQuestList();
		public override void OnPageBecomeActive(object data);
		private void Start();
		private void LateUpdate();
		public void OnBackButtonTouched();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator EnterAnimationCoroutine();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void GoQuestDetailListPage(Clb01EventLocationElement loc);
		public static void CheckSecondHarlPopup(bool isOpenPopup);
		[CompilerGenerated]
		private float _LoadMiniChara_b__15_0(int x);
		[CompilerGenerated]
		private float _LoadMiniChara_b__15_1(int x);
		[CompilerGenerated]
		private void _OnBackFromQuestList_b__18_0();
	}
}
