/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectAreaCanvas : AnimationUIObject
	{
		// Fields
		[HideInInspector]
		public QuestSelectScene sceneObj;
		public UnityAction onClickEventButton;
		[SerializeField]
		public Canvas selfCanvas;
		[SerializeField]
		public GameObject uiAreaMapRoot;
		[SerializeField]
		public Image uiAreaMapImage;
		[SerializeField]
		private int uiAreaMapKeepCountMax;
		[SerializeField]
		public GameObject uiLineDotRoot;
		[SerializeField]
		public GameObject uiLandmarkRoot;
		[SerializeField]
		private GameObject dragCenterObj;
		[SerializeField]
		public Transform areaMapTargetForDisp;
		[SerializeField]
		private Vector2 namPos;
		[SerializeField]
		private Vector2 namScale;
		[Header]
		[SerializeField]
		private float mapScale;
		[SerializeField]
		private int[] cloudNg;
		[SerializeField]
		private Vector3 landmarkFlashArrangeOffset;
		[SerializeField]
		private AnimationUIBase _animationUiBase;
		[SerializeField]
		private QuestStoryClearReward storyClearReward;
		[SerializeField]
		private RectTransform mapRectTransform;
		[SerializeField]
		private QSLandMarkController qSLandmarkController;
		[SerializeField]
		private GameObject pinchScaleRoot;
		[Header]
		[SerializeField]
		private float pinchMapScalingModulus;
		[Header]
		[SerializeField]
		private Vector2 pinchMapScalingRange;
		[Header]
		[SerializeField]
		private float pinchMapScalingDefault;
		[Header]
		[SerializeField]
		private float pinchMapScalingLimitRangeElasticModulus;
		[SerializeField]
		private Transform _mainTrans;
		[SerializeField]
		private float newCommerTime;
		[SerializeField]
		private float newLandmarkDirectionDelayTime;
		[SerializeField]
		private float newLandmarkIconAnimationDelayTime;
		[SerializeField]
		private float newTreasureBoxIconAnimationDelayTime;
		[CompilerGenerated]
		private bool _isTutorialPopupShown_k__BackingField;
		[CompilerGenerated]
		private QSChapterElement _chapterElement_k__BackingField;
		private float curMapScale;
		private bool isMultiTouch;
		private Vector2[] multiTouchPos;
		private ScrollRect mapDragScrollRect;
		private float prevMultiPointerDistance;
		private RectTransform pinchScaleRootRectTransform;
		private QuestStoryRewardPopup storyRewardPopup;
		private QuestCloudController cloudCtrl;
		private Vector2 centerDiff;
		private Vector2 scrollMin;
		private Vector2 scrollMax;
		private Vector2 dragCenterInitialSize;
		private QuestSelectNhaam questSelectNhaam;
		private QSAreaLandmarkElement[] landmarkArray;
		private RectTransform dragCenterObjRect;
		private QuestReleasePopup releasePopup;
		private RectTransform qaAreaSelectRectTrans;
		private Vector3 initialLocalPos;
		private bool isMapLocalPosPreserved;
		private Vector3 mapPrevLocalPos;
		private int lastLandmarkIndex;
		private List<int> newLandmarkIndexList;
		private List<QSChapterElement> chapterList;
		private QuestSelectLocationDetail questSelectLocationDetailOpened;
		private List<List<QuestSelectRouteDot>> questSelectRouteDotList;
		private List<Material> areaMapMaterialList;
		private const float pointScaleTime = 0.2f;
		private readonly string areaMapImagePrefix;
		private readonly Vector2 cloudAreaSize;
		private bool isInitializing;
		private bool isStartingFlyAnimation;
	
		// Properties
		public AnimationUIBase animationUiBase { get; }
		public bool isTutorialPopupShown { [CompilerGenerated] get; [CompilerGenerated] set; }
		public QSChapterElement chapterElement { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Transform mainTtans { get; }
		public bool IsAreaMapInitializing { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public QuestSelectAreaCanvas __4__this;
			public bool isTutorialRequired;
			public UnityAction __9__3;
			public UnityAction __9__4;
			public UnityAction __9__5;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal void _Initialize_b__0();
			internal void _Initialize_b__3();
			internal void _Initialize_b__1();
			internal void _Initialize_b__4();
			internal void _Initialize_b__2();
			internal void _Initialize_b__5();
		}
	
		[CompilerGenerated]
		private sealed class _Initialize_d__76 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private __c__DisplayClass76_0 __8__1;
			private TouchGuardObject _touchGuardObject_5__2;
			private bool _isFirstClearedQuest_5__3;
			private bool _isNewLandmarkReleased_5__4;
			private int _lastSelectedQuestId_5__5;
			private int _pointerIndex_5__6;
			private float _landmarkInitializedTime_5__7;
			private QSAreaLandmarkElement _lastLandmark_5__8;
			private QuestSelectRouteDot _dotOrg_5__9;
			private bool _newFlag_5__10;
			private int _createdDotCount_5__11;
			private int _i_5__12;
			private QSAreaLandmarkElement _pe_5__13;
			private bool _newReleaseFlag_5__14;
			private QSLandMarkController _qsLandmark_5__15;
			private int _dotNum_5__16;
			private List<QuestSelectRouteDot> _dotList_5__17;
			private int _j_5__18;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Initialize_d__76(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public QuestSelectAreaCanvas __4__this;
			public Action onFinish;
	
			// Constructors
			public __c__DisplayClass83_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_1
		{
			// Fields
			public QuestSelectLocationDetail detailPage;
			public Canvas fCanvas;
			public Canvas hCanvas;
			public __c__DisplayClass83_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass83_1();
	
			// Methods
			internal bool _LoadNewEnrollmentPageCorutine_b__0();
			internal void _LoadNewEnrollmentPageCorutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadNewEnrollmentPageCorutine_d__83 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			public Action onFinish;
			public GiftType giftType;
			private __c__DisplayClass83_1 __8__1;
			public int id;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadNewEnrollmentPageCorutine_d__83(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartFlyAnimation_d__86 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private int _numFlyCount_5__2;
			private int _maxFlyCount_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartFlyAnimation_d__86(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass88_0
		{
			// Fields
			public QuestSelectAreaCanvas __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass88_0();
	
			// Methods
			internal void _NewLandmarkCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _NewLandmarkCoroutine_d__88 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			public int startIndex;
			private __c__DisplayClass88_0 __8__1;
			public int goalIndex;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _NewLandmarkCoroutine_d__88(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<PageBase> __9__91_1;
			public static UnityAction __9__93_2;
			public static Action __9__117_2;
			public static UnityAction __9__123_1;
			public static Action __9__123_0;
			public static UnityAction __9__125_1;
			public static Action __9__125_0;
			public static UnityAction __9__128_1;
			public static Action __9__128_0;
			public static UnityAction __9__131_1;
			public static Action __9__131_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CheckTransition_b__91_1(PageBase basePage);
			internal void _CreateAndroidReviewNoPopup_b__93_2();
			internal void _Tutorial_2_2_Coroutine_b__117_2();
			internal void _Tutorial_ReleaseTruthDragonBattle_Coroutine_b__123_0();
			internal void _Tutorial_ReleaseTruthDragonBattle_Coroutine_b__123_1();
			internal void _Tutorial_ReleaseAgito_Coroutine_b__125_0();
			internal void _Tutorial_ReleaseAgito_Coroutine_b__125_1();
			internal void _Tutorial_7_1_ShowDualWindow_Coroutine_b__128_0();
			internal void _Tutorial_7_1_ShowDualWindow_Coroutine_b__128_1();
			internal void _Tutorial_9_1_ShowDualWindow_Coroutine_b__131_0();
			internal void _Tutorial_9_1_ShowDualWindow_Coroutine_b__131_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0
		{
			// Fields
			public QuestSelectAreaCanvas __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass92_0();
	
			// Methods
			internal void _CreateAndroidReviewPopup_b__0();
			internal void _CreateAndroidReviewPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _CreateAndroidReviewNoPopup_b__0();
			internal void _CreateAndroidReviewNoPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal void _CreateAndroidReviewYesPopup_b__0();
			internal void _CreateAndroidReviewYesPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_0
		{
			// Fields
			public CommonPopup popup;
			public bool isNewLandmark;
			public QuestSelectAreaCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass98_0();
	
			// Methods
			internal void _CreateDuplicateConfirmPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public QuestSelectAreaCanvas __4__this;
			public DragEventScrollRect dragRect;
	
			// Constructors
			public __c__DisplayClass103_0();
	
			// Methods
			internal void _Tutorial_1_1_Coroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_Coroutine_d__103 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private __c__DisplayClass103_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_Coroutine_d__103(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public QuestSelectAreaCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal void _Tutorial_1_1_Result_Coroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_1_Result_Coroutine_d__105 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private __c__DisplayClass105_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_1_Result_Coroutine_d__105(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_2_MaterialReceiveDone_Coroutine_d__108 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_2_MaterialReceiveDone_Coroutine_d__108(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass110_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public QuestSelectAreaCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass110_0();
	
			// Methods
			internal void _Tutorial_1_4_Coroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_4_Coroutine_d__110 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private __c__DisplayClass110_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_4_Coroutine_d__110(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass112_0
		{
			// Fields
			public TutorialGuideWindowData windowData;
			public QuestSelectAreaCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass112_0();
	
			// Methods
			internal void _Tutorial_1_5_Coroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_5_Coroutine_d__112 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private __c__DisplayClass112_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_5_Coroutine_d__112(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_1_Coroutine_d__114 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_1_Coroutine_d__114(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_2_Coroutine_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_2_Coroutine_d__117(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass118_0
		{
			// Fields
			public PointerEventHandler pointerEventHandler;
			public UnityAction callback;
			public DragEventScrollRect dragEventScrollRect;
			public CanvasGroup[] canvasGroups;
			public QuestSelectAreaCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass118_0();
	
			// Methods
			internal void _Tutorial_ToBackButton_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_6_1_Coroutine_d__121 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_6_1_Coroutine_d__121(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseTruthDragonBattle_Coroutine_d__123 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseTruthDragonBattle_Coroutine_d__123(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_ReleaseAgito_Coroutine_d__125 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_ReleaseAgito_Coroutine_d__125(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_7_1_Coroutine_d__127 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_7_1_Coroutine_d__127(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_7_1_ShowDualWindow_Coroutine_d__128 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_7_1_ShowDualWindow_Coroutine_d__128(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_9_1_Coroutine_d__130 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_9_1_Coroutine_d__130(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_9_1_ShowDualWindow_Coroutine_d__131 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_9_1_ShowDualWindow_Coroutine_d__131(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_10_1_Coroutine_d__133 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_10_1_Coroutine_d__133(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass135_0
		{
			// Fields
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass135_0();
	
			// Methods
			internal void _MovePointerWithAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass151_0
		{
			// Fields
			public UnityAction action;
	
			// Constructors
			public __c__DisplayClass151_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass151_1
		{
			// Fields
			public QuestSelectTrailerPopup popup;
			public __c__DisplayClass151_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass151_1();
	
			// Methods
			internal void _CheckTrailer_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass157_0
		{
			// Fields
			public bool nhaamAnimationEnd;
			public QuestSelectAreaCanvas __4__this;
			public bool nextFlag;
	
			// Constructors
			public __c__DisplayClass157_0();
	
			// Methods
			internal void _ChangeChapter_b__0();
			internal bool _ChangeChapter_b__1();
			internal void _ChangeChapter_b__2();
			internal bool _ChangeChapter_b__3();
			internal void _ChangeChapter_b__4();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeChapter_d__157 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectAreaCanvas __4__this;
			private __c__DisplayClass157_0 __8__1;
			public int groupId;
			public bool isSupport;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeChapter_d__157(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectAreaCanvas();
	
		// Methods
		protected override void OnDestroy();
		private void Update();
		[IteratorStateMachine]
		public IEnumerator Initialize();
		private void InitTresureBox(QSAreaLandmarkElement[] landmarkArray, bool isNewTresureReleased, int lastLandmarkIndex);
		private void onStartArrangingRoutePoints();
		private void OnEndArrangingRoutePoints();
		private void onReadyStartArrangingRoutePoints();
		private void onReadyEndArrangingRoutePoints();
		public void LoadNewEnrollmentPage(int id, GiftType giftType, int index, Action onFinish);
		[IteratorStateMachine]
		private IEnumerator LoadNewEnrollmentPageCorutine(int id, GiftType giftType, int index, Action onFinish);
		private void OnNewEnrollmentOutAnimationStart();
		private void OnNewEnrollmentInAnimationEnd();
		[IteratorStateMachine]
		private IEnumerator StartFlyAnimation();
		private void StartNewLandmarkActivation();
		[IteratorStateMachine]
		private IEnumerator NewLandmarkCoroutine(int startIndex, int goalIndex);
		private int GetNextLandMarkIndex(int lastIndex);
		private int GetMainLocationLastIndex();
		private void CheckTransition(bool isNewLandmark);
		private void CreateAndroidReviewPopup();
		private void CreateAndroidReviewNoPopup();
		private void CreateAndroidReviewYesPopup();
		public void OnClickBack();
		public void OnClickDifficulty();
		private void CloseQuestSelectLocation();
		private CommonPopup CreateDuplicateConfirmPopup(string title, string text, bool isNewLandmark = false);
		private void StartTutorial();
		private void Tutorial_Default();
		private void DisableUiOnTutorial();
		private void Tutorial_1_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Coroutine();
		private void Tutorial_1_1_Result();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_1_Result_Coroutine();
		private void Tutorial_1_2();
		private void Tutorial_1_2_MaterialReceiveDone();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_2_MaterialReceiveDone_Coroutine();
		private void Tutorial_1_4();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_4_Coroutine();
		private void Tutorial_1_5();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_5_Coroutine();
		private void Tutorial_2_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_1_Coroutine();
		private void StartEditSkillTutorial();
		private void Tutorial_2_2();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_2_Coroutine();
		private void Tutorial_ToBackButton();
		private void Tutorial_ToEventTab();
		private void Tutorial_6_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_6_1_Coroutine();
		private void Tutorial_ReleaseTruthDragonBattle();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseTruthDragonBattle_Coroutine();
		private void Tutorial_ReleaseAgito();
		[IteratorStateMachine]
		private IEnumerator Tutorial_ReleaseAgito_Coroutine();
		private void Tutorial_7_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_7_1_Coroutine();
		[IteratorStateMachine]
		private IEnumerator Tutorial_7_1_ShowDualWindow_Coroutine();
		private void Tutorial_9_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_9_1_Coroutine();
		[IteratorStateMachine]
		private IEnumerator Tutorial_9_1_ShowDualWindow_Coroutine();
		private void Tutorial_10_1();
		[IteratorStateMachine]
		private IEnumerator Tutorial_10_1_Coroutine();
		private void MovePointer(int targetPointerArrayIndex);
		private void MovePointerWithAnimation(int targetPointerArrayIndex, Action onCompleted = null);
		private void OnPinch();
		private void ChageMapScale(float deltaDistance);
		public Vector3 GetNowPoint();
		private bool IsAreaSelectOperationEnabled();
		private bool IsDispJustAreaMapColorTexture();
		public Vector3 GetNowPoint(Vector3 pos);
		private void ReflectPinchScale(float scaleValue);
		public void NhaamMove(int pointerIndex);
		public void PlayCloud();
		private void StopCloud();
		public QSAreaLandmarkElement[] GetLandmarkArray();
		private void OnLandmarkAppearedCommon(QSAreaLandmarkElement landmarkElement);
		private int GetDotNum();
		private void OnClickEventButton();
		public void CanvasActive(bool enable);
		private void CheckTrailer(UnityAction action);
		private float GetAim(Vector2 p1, Vector2 p2);
		public void ChageChapter(bool isSupport);
		public void OnClickLeftArrow();
		public void OnClickRightArrow();
		private int GetMaxChapter();
		[IteratorStateMachine]
		private IEnumerator ChangeChapter(int groupId, bool isSupport = false);
		public void OnToChapter();
		private bool CheckPlayNewLandmarkAnimationCondition(QSAreaLandmarkElement landmark);
		[CompilerGenerated]
		private bool _StartFlyAnimation_b__86_0();
		[CompilerGenerated]
		private void _CheckTransition_b__91_0(PageBase basePage);
		[CompilerGenerated]
		private void _Tutorial_1_1_b__102_0();
		[CompilerGenerated]
		private void _Tutorial_1_1_Result_b__104_0();
		[CompilerGenerated]
		private void _Tutorial_1_2_MaterialReceiveDone_b__107_0();
		[CompilerGenerated]
		private void _Tutorial_1_2_MaterialReceiveDone_Coroutine_b__108_0();
		[CompilerGenerated]
		private void _Tutorial_1_2_MaterialReceiveDone_Coroutine_b__108_1();
		[CompilerGenerated]
		private void _Tutorial_1_2_MaterialReceiveDone_Coroutine_b__108_2();
		[CompilerGenerated]
		private void _Tutorial_1_4_b__109_0();
		[CompilerGenerated]
		private void _Tutorial_1_5_b__111_0();
		[CompilerGenerated]
		private void _Tutorial_2_1_b__113_0();
		[CompilerGenerated]
		private void _Tutorial_2_1_Coroutine_b__114_0();
		[CompilerGenerated]
		private void _Tutorial_2_1_Coroutine_b__114_1();
		[CompilerGenerated]
		private void _StartEditSkillTutorial_b__115_0();
		[CompilerGenerated]
		private void _Tutorial_2_2_b__116_0();
		[CompilerGenerated]
		private void _Tutorial_2_2_Coroutine_b__117_0();
		[CompilerGenerated]
		private void _Tutorial_2_2_Coroutine_b__117_1();
		[CompilerGenerated]
		private void _Tutorial_ToBackButton_b__118_0();
		[CompilerGenerated]
		private void _Tutorial_ToEventTab_b__119_0();
		[CompilerGenerated]
		private void _Tutorial_6_1_b__120_0();
		[CompilerGenerated]
		private void _Tutorial_6_1_Coroutine_b__121_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseTruthDragonBattle_b__122_0();
		[CompilerGenerated]
		private void _Tutorial_ReleaseAgito_b__124_0();
		[CompilerGenerated]
		private void _Tutorial_7_1_b__126_0();
		[CompilerGenerated]
		private void _Tutorial_7_1_Coroutine_b__127_0();
		[CompilerGenerated]
		private void _Tutorial_9_1_b__129_0();
		[CompilerGenerated]
		private void _Tutorial_9_1_Coroutine_b__130_0();
		[CompilerGenerated]
		private void _Tutorial_10_1_b__132_0();
		[CompilerGenerated]
		private void _Tutorial_10_1_Coroutine_b__133_0();
		[CompilerGenerated]
		private void _Tutorial_10_1_Coroutine_b__133_1();
	}
}
