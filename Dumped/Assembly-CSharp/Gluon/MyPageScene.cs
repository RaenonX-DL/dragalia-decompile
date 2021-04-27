/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using SerializableCollections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageScene : SceneBase
	{
		// Fields
		public static bool isEcoMode;
		public static bool isLeaving;
		public static bool isShowedInformationByFirst;
		public static bool exists;
		public Camera mainCamera;
		public MyPageCamera myPageCamera;
		public PostEffect mainCameraPostEffect;
		public Camera uiCamera;
		public Camera renderCamera;
		public PostEffect renderCameraPostEffect;
		public MyPageMoveMap moveMap;
		public MyPageSkitMap skitMap;
		public MyPageUICanvas mainCanvas;
		public GameObject moveMapGroundRotationBase;
		public MyPage2dUICanvas main2dCanvas;
		public MyPageTalkCanvas talkCanvas;
		public MyPageObjectsSettings objectsSettings;
		public MyPageLookControl lookControl;
		public MyPageSoundControl soundControl;
		public MyPageMoveMapBgContent moveMapBgContent;
		public GameObject moveMapGroundBase;
		public GameObject moveMapPlayer;
		public GameObject moveMapNhaam;
		public GameObject moveMapExtraChara;
		public MyPageMapCharacters characters;
		public Color[] ambientColors;
		public float updateTime;
		public MyPageResourceNameList resourceNameList;
		public float rotationSpeed;
		public State state;
		public MyPageTutorial tutorial;
		public bool isMoveMapBgLoadedOnStart;
		public bool doMapLoop;
		public bool isSyncLoad;
		[SerializeField]
		private GameObject moveMapWalkRotationBase;
		[HideInInspector]
		public MyPageTransitionController transition;
		[HideInInspector]
		public MyPageMoveMapCharaPosSettings moveMapCharaPosSettings;
		[HideInInspector]
		public MyPageSkitMapCharaPosSettings skitMapCharaPosSettings;
		[HideInInspector]
		public MyPageMapPlaceCharacterSettings myPageMapPlaceCharacterSettings;
		[HideInInspector]
		public GameObject godRayObject;
		[HideInInspector]
		public MyPageBgmSyncSettings bgmSyncSettings;
		[HideInInspector]
		public MyPageBgmSyncSettings.Entry currBgmSyncSetting;
		[HideInInspector]
		public bool useDebugCharaId;
		[HideInInspector]
		public int[] debugCharaIds;
		[HideInInspector]
		public bool isMyPageInfoRequestDone;
		[HideInInspector]
		public bool isMyPageInfoRequestErrer;
		private CanvasGroup mainCanvasCanvasGroup;
		private RawImage fadeoutImage;
		private RenderTexture renderTexture;
		private Material[] godRayMaterials;
		private Vector3 baseRotation;
		private Quaternion initialGroundBaseLocalRotation;
		private Animator playerAnimator;
		private RuntimeAnimatorController playerRuntimeAnimator;
		private State startState;
		private bool isInitDone;
		private bool skipResourceUnload;
		private MyPageBgmSyncSettings.MapSetting mapSetting;
		private UnityEvent backKeyEvent;
		private float walkingSpeed;
		private TouchGuardObject mypageInfoTouchGuard;
		public static string prefabDir;
		public const float animationLoopTime = 1.053f;
		public static string commonBgmLabel;
		public bool isUseMeshCollider;
		private const float rangeOfRay = 0.5f;
		private bool isWaitFadeOut;
		private Coroutine setupSkitMapTalkCanvasCoroutine;
		public static readonly string myPageMapPlaceCharacterSettingsPrefabPath;
		public static bool isOpenGuildPopupAfterEnterScene;
	
		// Nested types
		public enum State
		{
			None = 0,
			MoveMapLoadWait = 1,
			SkitMapLoadWait = 2,
			MoveMapCreate = 3,
			SkitMapCreate = 4,
			MoveFadeIn = 5,
			MoveNormal = 6,
			MoveFadeOutToSkitRender = 7,
			MoveFadeOutToSkitLoad = 8,
			MoveFadeOutToSkit = 9,
			MoveFadeOutToMoveRender = 10,
			MoveFadeOutToMoveLoad = 11,
			MoveFadeOutToMove = 12,
			SkitFadeIn = 13,
			SkitNormal = 14,
			SkitFadeOutToMove = 15,
			SkitFadeOutToMoveLoad = 16,
			SkitFadeOutToMoveRender = 17,
			SkitFadeOutToSkit = 18,
			SkitFadeOutToSkitLoad = 19,
			SkitFadeOutToSkitRender = 20,
			JustRotate = 21
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__72_0;
			public static Func<bool> __9__72_1;
			public static Action<float> __9__73_6;
			public static Func<bool> __9__73_15;
			public static Func<bool> __9__73_10;
			public static Func<string, bool> __9__73_30;
			public static Action<PartyIndexResponse> __9__153_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__72_0();
			internal bool _Start_b__72_1();
			internal void _WaitPrevSceneExit_b__73_6(float value);
			internal bool _WaitPrevSceneExit_b__73_15();
			internal bool _WaitPrevSceneExit_b__73_10();
			internal bool _WaitPrevSceneExit_b__73_30(string target);
			internal void _OnBeforeLeaving_b__153_0(PartyIndexResponse res);
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public MyPageScene __4__this;
			public bool shouldSetTutorialTouchGuard;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__0();
			internal bool _WaitPrevSceneExit_b__1();
			internal bool _WaitPrevSceneExit_b__2();
			internal bool _WaitPrevSceneExit_b__3();
			internal bool _WaitPrevSceneExit_b__4();
			internal void _WaitPrevSceneExit_b__5(UnityEngine.Object obj);
			internal void _WaitPrevSceneExit_b__7();
			internal void _WaitPrevSceneExit_b__8();
			internal bool _WaitPrevSceneExit_b__9();
			internal bool _WaitPrevSceneExit_b__11();
			internal bool _WaitPrevSceneExit_b__12();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_1
		{
			// Fields
			public bool inited;
			public __c__DisplayClass73_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass73_1();
	
			// Methods
			internal void _WaitPrevSceneExit_b__13();
			internal bool _WaitPrevSceneExit_b__14();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_2
		{
			// Fields
			public bool isInformationPopupDone;
	
			// Constructors
			public __c__DisplayClass73_2();
	
			// Methods
			internal void _WaitPrevSceneExit_b__16();
			internal bool _WaitPrevSceneExit_b__17();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_3
		{
			// Fields
			public bool done;
	
			// Constructors
			public __c__DisplayClass73_3();
	
			// Methods
			internal void _WaitPrevSceneExit_b__18();
			internal bool _WaitPrevSceneExit_b__19();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_4
		{
			// Fields
			public bool done;
	
			// Nested types
			private struct __WaitPrevSceneExit_b__20_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass73_4 __4__this;
				private TaskAwaiter<RepeatEndResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass73_4();
	
			// Methods
			internal async void _WaitPrevSceneExit_b__20();
			internal bool _WaitPrevSceneExit_b__21();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_5
		{
			// Fields
			public ExchangeSummonItemConversionPopup popup;
	
			// Constructors
			public __c__DisplayClass73_5();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__22();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_6
		{
			// Fields
			public WeeklyBonusSelectPopup popup;
	
			// Constructors
			public __c__DisplayClass73_6();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__23();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_7
		{
			// Fields
			public bool eventStartPopupDone;
			public bool goEvent;
	
			// Constructors
			public __c__DisplayClass73_7();
	
			// Methods
			internal void _WaitPrevSceneExit_b__24(bool toEvent);
			internal bool _WaitPrevSceneExit_b__25();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_8
		{
			// Fields
			public bool eventStartPopupDone;
			public bool goEvent;
	
			// Constructors
			public __c__DisplayClass73_8();
	
			// Methods
			internal void _WaitPrevSceneExit_b__26(bool toEvent);
			internal bool _WaitPrevSceneExit_b__27();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_9
		{
			// Fields
			public bool eventStartPopupDone;
			public bool goEvent;
	
			// Constructors
			public __c__DisplayClass73_9();
	
			// Methods
			internal void _WaitPrevSceneExit_b__28(bool toEvent);
			internal bool _WaitPrevSceneExit_b__29();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_10
		{
			// Fields
			public bool done;
	
			// Constructors
			public __c__DisplayClass73_10();
	
			// Methods
			internal void _WaitPrevSceneExit_b__31(bool isDeleteAssets);
			internal bool _WaitPrevSceneExit_b__32();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
			private __c__DisplayClass73_0 __8__1;
			private __c__DisplayClass73_2 __8__2;
			private __c__DisplayClass73_7 __8__3;
			private __c__DisplayClass73_8 __8__4;
			private __c__DisplayClass73_9 __8__5;
			private bool _isOpenGuildPopup_5__2;
			private TouchGuardObject _tutorialTouchGuardObject_5__3;
			private TouchGuardObject _infoPopupTouchGuardObject_5__4;
			private TouchGuardObject _waitPopupTouchGuardObject_5__5;
			private int _i_5__6;
			private DataManager.GameData<AtgenExchangeSummomPointList> _exchangeSummomPointList_5__7;
			private int _i_5__8;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public SerializableDictionary<int, SummonPointDataElement> spde;
			public bool isPopupClosed;
			public UnityAction __9__1;
			public Func<bool> __9__2;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _SummonExchangeCorotine_b__1();
			internal bool _SummonExchangeCorotine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_1
		{
			// Fields
			public int i;
			public __c__DisplayClass74_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass74_1();
	
			// Methods
			internal bool _SummonExchangeCorotine_b__0(int x);
		}
	
		[CompilerGenerated]
		private sealed class _SummonExchangeCorotine_d__74 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass74_1 __8__1;
			public MyPageScene __4__this;
			private List<int> _csSummonList_5__2;
			private int _count_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SummonExchangeCorotine_d__74(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public bool isPopupClosed;
			public UnityAction __9__0;
			public Func<bool> __9__1;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _CsSummonExchangeCoroutine_b__0();
			internal bool _CsSummonExchangeCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _CsSummonExchangeCoroutine_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			private __c__DisplayClass75_0 __8__1;
			public MyPageScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CsSummonExchangeCoroutine_d__75(int __1__state);
	
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
			public SummonPointDataElement spde;
			public UnityAction onPopupEnd;
			public CommonIconPopup popup;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass77_0();
	
			// Methods
			internal void _CreateExchangeSummonPopup_b__0();
			internal void _CreateExchangeSummonPopup_b__2();
			internal void _CreateExchangeSummonPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public int summonId;
			public DateTime dateTime;
			public UnityAction onPopupEnd;
			public CommonIconPopup popup;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass78_0();
	
			// Methods
			internal void _CsCreateExchangeSummonPopup_b__0();
			internal void _CsCreateExchangeSummonPopup_b__2();
			internal void _CsCreateExchangeSummonPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public MyPageScene __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _CreateAndroidBackKeyPopup_b__0();
			internal void _CreateAndroidBackKeyPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OnMyPageInfoSuccessCoroutine_d__82 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
			public int is_shop_notification;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnMyPageInfoSuccessCoroutine_d__82(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public Vector3 startPos;
			public Vector3 endPos;
			public MyPageScene __4__this;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _ExitAnimationCoroutine_b__0(float x);
		}
	
		[CompilerGenerated]
		private sealed class _ExitAnimationCoroutine_d__85 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExitAnimationCoroutine_d__85(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public MyPageScene __4__this;
			public bool isWalkerEvent;
			public float maincharaScale;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal void _OnSetupMoveMapPlayerComplete_b__0(UnityEngine.Object controller);
			internal void _OnSetupMoveMapPlayerComplete_b__1();
			internal void _OnSetupMoveMapPlayerComplete_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _SetNhaamTransform_d__95 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
			public bool isWalkerEvent;
			public float maincharaScale;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetNhaamTransform_d__95(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ResetMoveMapCharaShaderCoroutine_d__100 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResetMoveMapCharaShaderCoroutine_d__100(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadUnusedAssetsCoroutine_d__102 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadUnusedAssetsCoroutine_d__102(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetupMoveMapTalkCanvasCoroutine_d__104 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupMoveMapTalkCanvasCoroutine_d__104(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetupGodRayCoroutine_d__105 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupGodRayCoroutine_d__105(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_0
		{
			// Fields
			public MyPageScene __4__this;
			public Animator nhaamAnimator;
			public Action onComplete;
			public Action<UnityEngine.Object> __9__1;
	
			// Constructors
			public __c__DisplayClass106_0();
	
			// Methods
			internal void _SetupMoveMapNhaam_b__0(GameObject obj);
			internal void _SetupMoveMapNhaam_b__1(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0
		{
			// Fields
			public MyPageScene __4__this;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass107_0();
	
			// Methods
			internal void _SetupMoveMapPlayer_b__0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass108_0
		{
			// Fields
			public MyPageScene __4__this;
			public Animator extraCharaAnimator;
			public Action onComplete;
			public Action<UnityEngine.Object> __9__1;
	
			// Constructors
			public __c__DisplayClass108_0();
	
			// Methods
			internal void _SetupMoveMapExtraChara_b__0(GameObject obj);
			internal void _SetupMoveMapExtraChara_b__1(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class _ResetSkitmapCharaShaderCoroutine_d__116 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResetSkitmapCharaShaderCoroutine_d__116(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetupSkitMapTalkCanvasCoroutine_d__118 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupSkitMapTalkCanvasCoroutine_d__118(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaiteChangeStateMoveMapFadeOut_d__131 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaiteChangeStateMoveMapFadeOut_d__131(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaiteChangeStateSkitMapFadeOut_d__143 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaiteChangeStateSkitMapFadeOut_d__143(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPageScene();
		static MyPageScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		[IteratorStateMachine]
		private IEnumerator SummonExchangeCorotine();
		[IteratorStateMachine]
		private IEnumerator CsSummonExchangeCoroutine();
		private void OnDestroy();
		public void CreateExchangeSummonPopup(SummonPointDataElement spde, UnityAction onPopupEnd);
		public void CsCreateExchangeSummonPopup(int summonId, int csPointTermMaxDate, UnityAction onPopupEnd);
		public void CreateAndroidBackKeyPopup();
		public void OnMyPageInfoSuccess(MypageInfoResponse response);
		private void OnMyPageInfoError(ErrorType errorType, int resultCode);
		[IteratorStateMachine]
		private IEnumerator OnMyPageInfoSuccessCoroutine(int is_shop_notification);
		public void ReloadOnError();
		public override void StartExitAnimation();
		[IteratorStateMachine]
		private new IEnumerator ExitAnimationCoroutine();
		public void InitEcoMode();
		public void LoadMoveMapGroundScene(string sceneName);
		public void LoadMoveMapBuildingScene(string sceneName, bool isAdditive);
		public void LoadMoveMapWindmillScene(string sceneName);
		public void CreateMoveMap();
		private void SetUpMoveMapGroundSpeed();
		private bool ReplaceMoveMapGroundParent();
		private void ReplaceMoveMapBuildParent();
		private void OnSetupMoveMapPlayerComplete();
		[IteratorStateMachine]
		private IEnumerator SetNhaamTransform(bool isWalkerEvent, float maincharaScale);
		private void LoadCharacterAnimationCompleted(UnityEngine.Object controller);
		private void SetupMoveMapBird();
		private void SetupMoveMapWindmill();
		private void SetupMoveMapRotation();
		[IteratorStateMachine]
		private IEnumerator ResetMoveMapCharaShaderCoroutine();
		private void UnloadUnusedAssets();
		[IteratorStateMachine]
		private IEnumerator UnloadUnusedAssetsCoroutine();
		private void SetupPlayerAnimation();
		[IteratorStateMachine]
		private IEnumerator SetupMoveMapTalkCanvasCoroutine();
		[IteratorStateMachine]
		private IEnumerator SetupGodRayCoroutine();
		private void SetupMoveMapNhaam(Action onComplete);
		private void SetupMoveMapPlayer(Action onComplete);
		private void SetupMoveMapExtraChara(Action onComplete);
		private void TurnOffPlayerCollider();
		public void SetAmbientColor(int index, Color color);
		public void ResetMoveMapRotation();
		public void DestroyMoveMap();
		public void DestroySkitMap();
		public void LoadSkitMapScene(int skitMapIndex);
		public void CreateSkitMap();
		[IteratorStateMachine]
		private IEnumerator ResetSkitmapCharaShaderCoroutine();
		private void SetupSkitMapTalkCanvas();
		[IteratorStateMachine]
		private IEnumerator SetupSkitMapTalkCanvasCoroutine();
		private void SetupSkitMapTalkNormal();
		private void SetupSkitMapTalkEvent();
		private void EnableRenderCamera();
		private void Update();
		private void MoveMapLoadWait();
		private void SkitMapLoadWait();
		private void MoveMapCreate();
		private void SkitMapCreate();
		private void AdjustMoveMapBuildingRotation();
		private void JustRotate();
		private void MoveFadeIn();
		private void MoveNormal();
		[IteratorStateMachine]
		private IEnumerator WaiteChangeStateMoveMapFadeOut();
		private void AdjustPlayerHigh();
		private void MoveFadeOutToSkitRender();
		private void MoveFadeOutToSkitLoad();
		private void MoveFadeOutToSkit();
		private void MoveFadeOutToMoveRender();
		private void MoveFadeOutToMoveLoad();
		public void LoadMoveMapBg();
		private void LoadMoveMap();
		private void MoveFadeOutToMove();
		private void SkitFadeIn();
		private void SkitNormal();
		[IteratorStateMachine]
		private IEnumerator WaiteChangeStateSkitMapFadeOut();
		private void SkitFadeOutToMoveRender();
		private void SkitFadeOutToMoveLoad();
		private void SkitFadeOutToMove();
		private void SkitFadeOutToSkitRender();
		private void SkitFadeOutToSkitLoad();
		private void SkitFadeOutToSkit();
		public void OnTouchAreaTouched();
		public override void OnPopupOpened();
		public override void OnPopupClosed();
		public override void OnBeforeLeaving();
		public bool IsMoveMapOnGoing();
		private void CheckMeshCollider();
		public void ReloadObjectsSettings();
		[CompilerGenerated]
		private bool _OnMyPageInfoSuccessCoroutine_b__82_0();
		[CompilerGenerated]
		private void _ExitAnimationCoroutine_b__85_1();
		[CompilerGenerated]
		private bool _SetNhaamTransform_b__95_0();
		[CompilerGenerated]
		private bool _ResetMoveMapCharaShaderCoroutine_b__100_0();
		[CompilerGenerated]
		private bool _SetupMoveMapTalkCanvasCoroutine_b__104_0();
		[CompilerGenerated]
		private bool _SetupMoveMapTalkCanvasCoroutine_b__104_1();
		[CompilerGenerated]
		private bool _SetupMoveMapTalkCanvasCoroutine_b__104_2();
		[CompilerGenerated]
		private bool _SetupGodRayCoroutine_b__105_0();
		[CompilerGenerated]
		private bool _ResetSkitmapCharaShaderCoroutine_b__116_0();
		[CompilerGenerated]
		private bool _SetupSkitMapTalkCanvasCoroutine_b__118_0();
		[CompilerGenerated]
		private bool _SetupSkitMapTalkCanvasCoroutine_b__118_1();
		[CompilerGenerated]
		private bool _SetupSkitMapTalkCanvasCoroutine_b__118_2();
		[CompilerGenerated]
		private bool _WaiteChangeStateMoveMapFadeOut_b__131_0();
		[CompilerGenerated]
		private void _LoadMoveMapBg_b__138_0(MyPageMoveMapBgContent obj);
		[CompilerGenerated]
		private bool _WaiteChangeStateSkitMapFadeOut_b__143_0();
	}
}
