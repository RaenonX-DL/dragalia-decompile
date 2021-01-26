/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventStatusInfoCtrl : AnimationUIObject
	{
		// Fields
		[Header]
		[SerializeField]
		private Image bg2DImage;
		[Header]
		[SerializeField]
		private Image charaBg;
		[SerializeField]
		public OutGameBgChara bgCharacter;
		[SerializeField]
		private RectTransform etoeCharaMoveNode;
		[SerializeField]
		private Transform charaOffsetNode;
		[SerializeField]
		private float charaMoveOffsetIPhoneX;
		[Header]
		[SerializeField]
		private Button charaTalkButton;
		[Header]
		[SerializeField]
		public EventTalkWindowModule talkWindowModule;
		[Header]
		[SerializeField]
		private RectMask2D questTopMask;
		[SerializeField]
		private RectMask2D questListMask;
		[SerializeField]
		private GameObject goSeperatorTop;
		[SerializeField]
		private GameObject goSeperatorQuestList;
		[SerializeField]
		private Transform topKeepStableOffset;
		[Header]
		[SerializeField]
		private Transform statusInfoParent;
		[Header]
		[SerializeField]
		private CampaignButtons campaign;
		[Header]
		[SerializeField]
		private EventMapImage mapImage;
		[SerializeField]
		private GameObject treasureImagesParent;
		[SerializeField]
		private Image[] treasureImages;
		[Header]
		[SerializeField]
		private float startHeightSeperatorQuestList;
		[SerializeField]
		public float endHightSeperatorRaidQuestList;
		[SerializeField]
		private float startHeadSeparatorYOffset;
		[Header]
		[SerializeField]
		private float questListMaskMinWidth;
		[SerializeField]
		public float questListMaskMaxWidth;
		[Header]
		[SerializeField]
		private float maskMovingDuration;
		[Header]
		[SerializeField]
		private RectTransform bgTopTransform;
		[SerializeField]
		private RectTransform frameTopTransform;
		[SerializeField]
		private RectTransform bgMiddleTransform;
		[SerializeField]
		private RectTransform frameMiddleTransform;
		[SerializeField]
		private GameObject edgeToEdgeFrameObj;
		[Header]
		[SerializeField]
		private UIAnimationPublisher charaPublisher;
		[Header]
		[SerializeField]
		private AnimationUIGroup animationGroup;
		[SerializeField]
		private AnimationUIMove charaMove;
		[Header]
		[SerializeField]
		private bool isUseBalloonExitDelay;
		[SerializeField]
		private float balloonExitDelay;
		[CompilerGenerated]
		private int _eventPoint_k__BackingField;
		[CompilerGenerated]
		private bool _isOnMaskAnimation_k__BackingField;
		[CompilerGenerated]
		private RectTransform _syncTopMask_k__BackingField;
		private int curTalkIndex;
		public bool isTreasureTime;
		[CompilerGenerated]
		private bool _isInited_k__BackingField;
		private const float image2DHeightIPhoneX = 642f;
		public static Action<RenderTexture> onFinishMapInstance;
		private const float topKeepStableHighPosOffset = -76f;
		private string selectedTopCharaId;
		private CanvasGroup bgCanvasGroup;
		private const string bgMaterialReadyFlagName = "__matReady";
		private Coroutine talkCoroutine;
		private EventInfoCtrlBase infoCtrl;
		private bool isMapAnim;
		private FlashPlayer questTransitionEffect;
		private FlashPlayerManager fpMgr;
		private float fadeout;
	
		// Properties
		public int eventPoint { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isOnMaskAnimation { [CompilerGenerated] get; [CompilerGenerated] set; }
		public RectTransform syncTopMask { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isInited { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public Image charaBg;
			public int eventId;
			public bool deactiveParts;
			public OutGameBgChara bgCharacter;
			public Action<Material> __9__1;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _LoadCharaterImage_b__0(bool hasEmotionDiff);
			internal void _LoadCharaterImage_b__1(Material material);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0
		{
			// Fields
			public EventStatusInfoCtrl __4__this;
			public EventQuestTalkDataModel.TalkSet talk;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass67_0();
	
			// Methods
			internal void _OnMiniCharaTouched_b__0();
			internal void _OnMiniCharaTouched_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public EventStatusInfoCtrl __4__this;
			public EventTopPageBase page;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal bool _Talk_b__0();
			internal bool _Talk_b__1();
			internal bool _Talk_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _Talk_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventStatusInfoCtrl __4__this;
			public EventTopPageBase page;
			private __c__DisplayClass72_0 __8__1;
			public string voiceData;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Talk_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0
		{
			// Fields
			public Material mat;
	
			// Constructors
			public __c__DisplayClass77_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_1
		{
			// Fields
			public Color oldColor;
			public __c__DisplayClass77_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass77_1();
	
			// Methods
			internal void _FadeBackground_b__5(float value);
		}
	
		[CompilerGenerated]
		private sealed class _FadeBackground_d__77 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isFadeIn;
			public EventStatusInfoCtrl __4__this;
			private float _startValue_5__2;
			private float _endValue_5__3;
			private Ease _ease_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FadeBackground_d__77(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public EventStatusInfoCtrl __4__this;
			public SceneNameDefine.PageName nextPageName;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _StartAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public EventStatusInfoCtrl __4__this;
			public RectTransform maskRectTransform;
			public float startWidth;
			public float endWidth;
			public float startY;
			public float endY;
			public RectTransform seperatorQuestListRectTrans;
			public bool isGotoQuestList;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _ExcuteAnimation_b__0(float value);
			internal void _ExcuteAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ExcuteAnimation_d__83 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventStatusInfoCtrl __4__this;
			public float delay;
			private __c__DisplayClass83_0 __8__1;
			public SceneNameDefine.PageName nextPageName;
			public SceneNameDefine.PageName prevPageName;
			public bool isFadeOut;
			private bool _isEntryToTopMode_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExcuteAnimation_d__83(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _MapFadeOutAnimationCorutine_d__93 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventStatusInfoCtrl __4__this;
			public Action showQuestPrepare3dImage;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MapFadeOutAnimationCorutine_d__93(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public EventStatusInfoCtrl __4__this;
			public bool visible;
	
			// Constructors
			public __c__DisplayClass95_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_1
		{
			// Fields
			public int initSortingOrder;
			public __c__DisplayClass95_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass95_1();
	
			// Methods
			internal void _SetScreenTransVisible_b__0();
		}
	
		// Constructors
		public EventStatusInfoCtrl();
		static EventStatusInfoCtrl();
	
		// Methods
		public EventInfoCtrlBase GetEventInfoCtrlBase();
		protected override void Awake();
		private void Start();
		public void UpdateCampains();
		public static Vector2 LoadCharaterImage(int eventId, OutGameBgChara bgCharacter, Image charaBg, out Vector2 charaEventListPageMoveOffset, EventStatusInfoCtrl infoCtrl = null, bool deactiveParts = false, EventQuestTalkDataModel.TalkSet usingTalkSet = null);
		private void Load2DIBgImage();
		public void SetEventInfo();
		public void OnMiniCharaTouched(int posIndex);
		public void ShowTreasureTimeImageInHeader(EventQuestModel.TreasureTimeType treasureType, bool forceInactive = false);
		public void OnCharaTouched();
		public void StartTalk(string voiceData, EventTopPageBase page = null);
		public void StopTalk(bool forceFadeOut = false);
		[IteratorStateMachine]
		private IEnumerator Talk(string voiceData, EventTopPageBase page = null);
		private string GetVoiceGroupName(string soundName);
		public string GetVoiceData(bool isFromCharaTouch);
		private void LateUpdate();
		public void ResetTopImageAndTalk();
		[IteratorStateMachine]
		private IEnumerator FadeBackground(bool isFadeIn);
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void SetAlphaWithObjects(float value);
		public void StartAnimationFromQuestPrepare(SceneNameDefine.PageName nextPageName, SceneNameDefine.PageName previousPageName, bool isFadeOut = false, float delay = 0f);
		public void StartAnimation(SceneNameDefine.PageName nextPageName, SceneNameDefine.PageName previousPageName, bool isFadeOut = false, float delay = 0f);
		[IteratorStateMachine]
		private IEnumerator ExcuteAnimation(SceneNameDefine.PageName nextPageName, SceneNameDefine.PageName prevPageName, bool isFadeOut, float delay);
		public void ResetCharaTalkButton(bool defaultValue = true);
		public void ResetEventTopMask();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public void StartQuestPrepareMoveAnimation();
		public void MapFadeOutAnimation(Action showQuestPrepare3dImage);
		[IteratorStateMachine]
		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage);
		private void FrameDefault();
		public Tweener SetScreenTransVisible(bool visible);
		[CompilerGenerated]
		private void _Start_b__62_1(Material x);
		[CompilerGenerated]
		private void _Start_b__62_0(GameObject prefab);
		[CompilerGenerated]
		private void _Start_b__62_2(bool isReverse);
		[CompilerGenerated]
		private bool _FadeBackground_b__77_0();
		[CompilerGenerated]
		private bool _FadeBackground_b__77_1();
		[CompilerGenerated]
		private bool _FadeBackground_b__77_2();
		[CompilerGenerated]
		private bool _FadeBackground_b__77_3();
		[CompilerGenerated]
		private bool _FadeBackground_b__77_4();
		[CompilerGenerated]
		private void _StartQuestPrepareMoveAnimation_b__91_0();
		[CompilerGenerated]
		private void _StartQuestPrepareMoveAnimation_b__91_1();
		[CompilerGenerated]
		private bool _MapFadeOutAnimationCorutine_b__93_0();
	}
}
