/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventDetailBannerPage : QuestEventBannerPage
	{
		// Fields
		[SerializeField]
		private RectTransform maskRectTransform;
		private bool isShown;
		public static Action<RenderTexture> onFinishMapInstance;
		[SerializeField]
		public RawImage render3dImageBlack;
		[SerializeField]
		private Image outerFrame;
		private Vector2 descripImageDefaultPos;
		private Sequence animationSeq;
		[SerializeField]
		private RectTransform dummyRectEventQuestTop;
		[SerializeField]
		private RectTransform dummyRectEventQuestTopFrame;
		[SerializeField]
		private RectTransform dummyRectEventQuestMiddle;
		[SerializeField]
		private RectTransform dummyRectEventQuestMiddleFrame;
		[SerializeField]
		private Transform campaignTrans;
		private CampaignButtons campaign;
		private string campaginPath;
		public bool isPrepare;
		private FlashPlayerManager fpMgr;
		private FlashPlayer questTransitionEffect;
		public float mapMove;
		public float mapMoveTime;
		public bool isMapAnim;
		public float fadeout;
		public float goQuestPrepareFlashSec;
		[Header]
		[SerializeField]
		private GameObject voidRoot;
		[SerializeField]
		private GameObject bonusRoot;
		[SerializeField]
		private UnityEngine.UI.Text bonusText;
		[SerializeField]
		private UnityEngine.UI.Text notBonusText;
		[SerializeField]
		private Image bonusImage;
		[SerializeField]
		private Animator bonusAnimator;
		[SerializeField]
		private ButtonWithSelectedImage detailButtonWithSelectedImage;
		[SerializeField]
		private GameObject detailCheckIcon;
		[SerializeField]
		private Button detailButton;
		[Header]
		[SerializeField]
		private GameObject questWallNode;
		[SerializeField]
		private GameObject astralRoot;
		[SerializeField]
		private Image astralItemIconImage;
		[SerializeField]
		private UnityEngine.UI.Text astralItemNumText;
		[Header]
		[SerializeField]
		private QuestEventSimpleBanner simpleBanner;
		[Header]
		[SerializeField]
		private QuestAgitoBanner questAgitoBanner;
		[Header]
		[SerializeField]
		protected Button ultimateDragonInfoButton;
		[SerializeField]
		private ButtonWithSelectedImage ultimateDragonInfoButtonnWithSelectedImage;
		private QuestEventGroupElement groupElement;
		private bool isBonusTime;
		[SerializeField]
		private float animationFrame;
		private static readonly int bonusAnimationHash;
		private QuestWallBanner questWallBanner;
		[SerializeField]
		private UIAnimationPublisher bannerObjectAnimation;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public QuestEventDetailBannerPage __4__this;
			public bool bonusObjFlag;
			public bool questBonusObjFlag;
			public bool campaignFlag;
			public bool voidFlag;
			public Action onCompleteAction;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _StartEnterAnimation_b__0();
			internal void _StartEnterAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public bool bonusObjFlag;
			public bool questBonusObjFlag;
			public bool campaignFlag;
			public bool voidFlag;
			public QuestEventDetailBannerPage __4__this;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _StartExitAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _MapFadeOutAnimationCorutine_d__54 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEventDetailBannerPage __4__this;
			public Action showQuestPrepare3dImage;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MapFadeOutAnimationCorutine_d__54(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestEventDetailBannerPage();
		static QuestEventDetailBannerPage();
	
		// Methods
		private new void Awake();
		private void Start();
		public void SetContent(QuestEventGroupElement groupElement);
		private static void SetActiveScale(GameObject obj, bool isActive);
		public void StartEnterAnimation(float duration = 0.2f, Action onCompleteAction = null);
		public void StartExitAnimation(float duration = 0.2f, bool inActiveOnComplete = false);
		public Tweener SetScreenTransVisible(bool visible, float time = 2f);
		public void MapFadeOutAnimation(Action showQuestPrepare3dImage);
		public void OnQuestDetail();
		[IteratorStateMachine]
		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage);
		private void FrameDefault();
		public void OnTimeAttackRankingButtonForQuestId();
		public new void OnHowToButtonTouched();
		public void OnUltimateDragonInfoButton();
		public void AfterTutorialSetInstructorButton();
		public bool IsOnAnimation();
		[CompilerGenerated]
		private void _SetContent_b__47_1(Material mat);
		[CompilerGenerated]
		private void _SetContent_b__47_0(Material mat);
		[CompilerGenerated]
		private void _StartExitAnimation_b__50_0();
		[CompilerGenerated]
		private void _StartExitAnimation_b__50_1();
		[CompilerGenerated]
		private void _StartExitAnimation_b__50_2();
		[CompilerGenerated]
		private void _OnQuestDetail_b__53_0();
		[CompilerGenerated]
		private bool _MapFadeOutAnimationCorutine_b__54_0();
		[CompilerGenerated]
		private void _OnTimeAttackRankingButtonForQuestId_b__56_0();
		[CompilerGenerated]
		private void _OnHowToButtonTouched_b__57_0();
		[CompilerGenerated]
		private void _OnUltimateDragonInfoButton_b__58_0();
	}
}
