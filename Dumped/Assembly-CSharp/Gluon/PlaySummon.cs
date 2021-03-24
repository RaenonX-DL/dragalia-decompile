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
using DG.Tweening.Core;
using SPFX;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlaySummon : MonoBehaviour, IPlaySummonInterface
	{
		// Fields
		private static PlaySummon instance;
		private const float originalCameraFov = 60f;
		private const string stageBGSceneName = "SummonBGScene";
		private const string stageBGScenePath = "Scene/OutGame/SummonBGScene/SummonBGScene";
		private const int rSPFXTrigger = 8;
		private const int srSPFXTrigger = 9;
		private const int ssrSPFXTrigger = 10;
		private const int stopSPFXTrigger = 1;
		private const float shot1StoneScale = 2.4f;
		private const float shot2StoneScale = 1.5f;
		private const float shot2AmuletScale = 1f;
		private const float darkBGColorPower = 0.3f;
		private const float overExposureBGColorPower = 4f;
		private Sequence bgExposureSequence;
		private const string amuletRarity5hot2CameraName = "Rarity5";
		public Camera mainCamera;
		private Animator cameraAnimator;
		private GameObject cameraAnimationParent;
		[Header]
		[SerializeField]
		private float[] rStageRates;
		[SerializeField]
		private float[] srStageRates;
		[SerializeField]
		private float[] ssrStageRates;
		[Header]
		[SerializeField]
		private Image whiteOutImage;
		private Tweener whiteOutTweener;
		[HideInInspector]
		public SummonScene scene;
		[HideInInspector]
		public Transform node3d;
		[Header]
		[SerializeField]
		private float bgmWaitTime;
		public Button skipButton;
		private bool isSkip;
		private bool isNextPressed;
		private bool isTimerEnd;
		private IEnumerator checkCharaAppealEndCoroutine;
		private Coroutine shot2WaitCoroutine;
		private List<SummonResultItemData> resultItems;
		private const string resultDummyWeaponPathTemplate = "Weapon/model/w{0}_01";
		private const string resultDummyWeaponPathTemplateSaya = "Weapon/model/w{0}_02";
		private int[] resultDummyWeaponIdList;
		private const string cutinSEName = "SE_SUMMON_0014";
		private const string cutinRSEName = "SE_SUMMON_0030";
		private const string cutinSRSEName = "SE_SUMMON_0031";
		private const string cutinSSRSEName = "SE_SUMMON_0034";
		private const string cutinSSRAdventSEName = "SE_SUMMON_0032";
		private const string charaSSRSlashSEName = "SE_SUMMON_0033";
		private const string moonGetSEName = "SE_SUMMON_0036";
		private const string amuletAdventSEName = "SE_SUMMON_0038";
		private const string dragonStoneBreakSEName = "SE_SUMMON_0042";
		private const string dragonSSRUniverseSEName = "SE_SUMMON_0043";
		private Coroutine shot2AdventSECoroutine;
		private Coroutine shot2CutinSECoroutine;
		private Coroutine shot2CutinEffectCoroutine;
		private Coroutine shot2CutinTextureOffsetCoroutine;
		private Coroutine shot2SwitchToWeaponModelCoroutine;
		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;
		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;
		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;
		private Camera oldFlashCamera;
		[HideInInspector]
		public Camera sceneResultFlashCamera;
		private AudioPlayback bgmAudioPlayer;
		private CriAtomExPlayback bgmAudioPlayback;
		private AudioPlayback unitVoiceAudio;
		private long bgmBeatBeginingPos;
		private long bgmBeatInterval;
		private const long bgmBeatSecondPartBeginingPos = 1314;
		private const long bgmBeatSecondPartInterval = 375;
		private Action onBGMSyncSkipReady;
		private bool isSyncBGMForSkipDone;
		private bool isWaitingForShot2SkipPoint;
		private const float shot2BGMSyncWhiteOutTime = 0.25f;
		private BGMJumpToLocation bgmJumpToLocation;
		private bool isShot1SkipForBGMTransition;
	
		// Properties
		public static PlaySummon Instance { get; }
		Transform IPlaySummonInterface.node3d { get; }
		FlashPlayerManager IPlaySummonInterface.flashPlayerManager { get; }
		CameraClearFlags IPlaySummonInterface.oldFlashCameraClearFlags { get; set; }
		RenderTexture IPlaySummonInterface.charaWeaponRenderTexture { get; }
		public bool IsBoxSummon { get; }
	
		// Nested types
		public enum BGMJumpToLocation
		{
			None = 0,
			Rewind = 1,
			Hook = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public bool loadDone;
			public bool isLoaded;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _LoadBackgroundCoroutine_b__0();
			internal void _LoadBackgroundCoroutine_b__4();
			internal bool _LoadBackgroundCoroutine_b__1();
			internal void _LoadBackgroundCoroutine_b__2();
			internal bool _LoadBackgroundCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBackgroundCoroutine_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			private __c__DisplayClass75_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBackgroundCoroutine_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PreloadAllAnimations_d__76 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isResult;
			private GameObject _go_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PreloadAllAnimations_d__76(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayAdventSECoroutine_d__85 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			public int i;
			private SummonStageUtil _util_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayAdventSECoroutine_d__85(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCutinSECoroutine_d__86 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			public int i;
			private float _accumulatedTime_5__2;
			private SummonStageObjectsSettings.SETimeDefine[] __7__wrap2;
			private int __7__wrap3;
			private SummonStageObjectsSettings.SETimeDefine _seItem_5__5;
			private float _waitTime_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayCutinSECoroutine_d__86(int __1__state);
	
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
			public static Action<float> __9__87_0;
			public static Action<float> __9__87_1;
			public static Func<bool> __9__128_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _PlayCutinEffectCoroutine_b__87_0(float x);
			internal void _PlayCutinEffectCoroutine_b__87_1(float x);
			internal bool _SummonStageFlowFirst_b__128_2();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCutinEffectCoroutine_d__87 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int i;
			public PlaySummon __4__this;
			private SummonStageUtil _util_5__2;
			private SummonStageResultSpecificLoadPool _specPool_5__3;
			private SummonStageObjectsSettings _settings_5__4;
			private Rarity _rarity_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayCutinEffectCoroutine_d__87(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCutinOuterTextureOffsetCoroutine_d__88 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int i;
			public PlaySummon __4__this;
			private SummonStageResultSpecificLoadPool _specPool_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayCutinOuterTextureOffsetCoroutine_d__88(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SwitchToWeaponModelCoroutine_d__89 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int phase;
			public PlaySummon __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SwitchToWeaponModelCoroutine_d__89(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _KickSPFXEffectTriggerByRarityCoroutine_d__91 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GameObject go;
			public Rarity rarity;
			public int offSet;
			private SPFXInstance _spfx_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _KickSPFXEffectTriggerByRarityCoroutine_d__91(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0
		{
			// Fields
			public PlaySummon __4__this;
			public float outTime;
			public DOGetter<Color> __9__3;
			public DOSetter<Color> __9__4;
			public TweenCallback __9__5;
	
			// Constructors
			public __c__DisplayClass96_0();
	
			// Methods
			internal Color _StartWhiteOutEffect_b__0();
			internal void _StartWhiteOutEffect_b__1(Color Color);
			internal void _StartWhiteOutEffect_b__2();
			internal Color _StartWhiteOutEffect_b__3();
			internal void _StartWhiteOutEffect_b__4(Color Color);
			internal void _StartWhiteOutEffect_b__5();
		}
	
		[CompilerGenerated]
		private sealed class _CheckCharaAppealEndCoroutine_d__97 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckCharaAppealEndCoroutine_d__97(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Shot2ObjectDisableTimer_d__98 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			public float time;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Shot2ObjectDisableTimer_d__98(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SummonStageFlow_d__127 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SummonStageFlow_d__127(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SummonStageFlowFirst_d__128 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			private SummonStageUtil _util_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SummonStageFlowFirst_d__128(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_0
		{
			// Fields
			public int i;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal bool _SummonStageFlowSecond_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SummonStageFlowSecond_d__129 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			private __c__DisplayClass129_0 __8__1;
			private SummonStageUtil _util_5__2;
			private SummonStageResultSpecificLoadPool.DroppingObj[] _dropItemList_5__3;
			private SummonStageResultSpecificLoadPool _specificPool_5__4;
			private GameObject _dropAnimator_5__5;
			private Rarity _rarity_5__6;
			private List<SummonStageResultSpecificLoadPool.SummonModelSetting> _modelSettingList_5__7;
			private WeaponType _weaponType_5__8;
			private bool _useWeaponModel_5__9;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SummonStageFlowSecond_d__129(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CharactorAppeal_d__134 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaySummon __4__this;
			public int index;
			private Animator _anim_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CharactorAppeal_d__134(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ShowMoonForResultCoroutine_d__144 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GameObject modelObject;
			public PlaySummon __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowMoonForResultCoroutine_d__144(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		private PlaySummon();
		static PlaySummon();
	
		// Methods
		public static bool IsInstanceEmpty();
		private void StartNowLoading(bool showGauge);
		private void TerminateNowLoading();
		public void OnBoxSummonEvent(BoxSummonEventId eid);
		[IteratorStateMachine]
		private IEnumerator LoadBackgroundCoroutine();
		[IteratorStateMachine]
		private IEnumerator PreloadAllAnimations(bool isResult);
		private void OnAllAsyncLoadPrepared();
		private void ProphetSetup();
		private void FafnirSetup();
		private void FallItemSetup();
		private void FallItemScaleSetup();
		private void CameraInitialize();
		private void PlayCutin(int index);
		private void DisableFafnir();
		[IteratorStateMachine]
		private IEnumerator PlayAdventSECoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator PlayCutinSECoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator PlayCutinEffectCoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator PlayCutinOuterTextureOffsetCoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator SwitchToWeaponModelCoroutine(int phase);
		private void KickSPFXEffectTriggerByRarity(GameObject go, Rarity rarity, int offset = 0);
		[IteratorStateMachine]
		private IEnumerator KickSPFXEffectTriggerByRarityCoroutine(GameObject go, Rarity rarity, int offSet);
		public void SetVisibleDropItem(bool isVisible);
		public void DroppingObjectDestory();
		private void ResetCameraPositionInStage();
		private void ResetCamera(bool bIsDragon = false);
		public void StartWhiteOutEffect(float inTime, float outTime);
		[IteratorStateMachine]
		private IEnumerator CheckCharaAppealEndCoroutine(int index);
		[IteratorStateMachine]
		private IEnumerator Shot2ObjectDisableTimer(float time);
		private void StopShot2ObjectDisableTimer();
		public bool IsPlayCameraAnimation();
		private void SyncBGMForSkip(Action onSkipReady);
		private void OnTransitionToNextPart();
		private long QueryNextSkipPoint(Action onSkipReady);
		private void OnEverySkipPoint();
		private void ClearSyncBGMFlag();
		private long GetCurrentBGMPosition();
		private void StartWaitSyncBGMForSkip();
		public void OnStageViewInstantiated();
		private void Start();
		private void OnDestroy();
		public void SchedulePostEffect(SummonPostEffectSettingsBase.SettingSetType type);
		public void TerminatePostEffect(SummonPostEffectSettingsBase.SettingSetType type);
		[IteratorStateMachine]
		private IEnumerator SummonStageFlow();
		[IteratorStateMachine]
		private IEnumerator SummonStageFlowFirst();
		[IteratorStateMachine]
		private IEnumerator SummonStageFlowSecond();
		public void OnShot1WeaponDropped(int index, EffectObject playingEffect);
		private void SetWeaponVisibilityState(int index, bool useWeaponModel, bool isMainWeapon, bool visible);
		private void SetWeaponBindArmState(int index, bool useWeaponModel, bool isMainWeapon, bool rightArm);
		private void ResetStatue();
		[IteratorStateMachine]
		public IEnumerator CharactorAppeal(int index);
		private void OnFinalize();
		public void DetachChildrenToStageNode(Transform t, bool forceDeactivate);
		public bool OnInitialize();
		public bool OnFadeIn();
		public void OnNextButton();
		public void OnSkipButton();
		public static void AdjustCharacterColorPower(int index, float power);
		public static void AdjustBGColorPower(float power);
		public Transform ActivateModelAtIndexForResult(int index);
		[IteratorStateMachine]
		private IEnumerator ShowMoonForResultCoroutine(GameObject modelObject, Rarity rarity);
		private void LoadRichObject(GameObject rootObject, string path);
		[CompilerGenerated]
		private bool _SummonStageFlowFirst_b__128_0();
		[CompilerGenerated]
		private void _SummonStageFlowFirst_b__128_1();
		[CompilerGenerated]
		private bool _SummonStageFlowFirst_b__128_3();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_1();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_6();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_7();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_3();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_4();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_5();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_8();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_9();
		[CompilerGenerated]
		private bool _SummonStageFlowSecond_b__129_2();
		[CompilerGenerated]
		private void _OnSkipButton_b__140_0();
	}
}
