/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonAnimScene : MonoBehaviour, IPlaySummonInterface
	{
		// Fields
		[SerializeField]
		private GameObject stage3dNode;
		[SerializeField]
		private SummonPostEffectSetting postEffectSetting;
		[SerializeField]
		private SummonPostFilmSetting postFilmSetting;
		[SerializeField]
		private GameObject postEffectCameraGO;
		[SerializeField]
		private Transform camera3DParent;
		[HideInInspector]
		public Transform node3d;
		private Coroutine _execCoroutine;
		public bool isExitStarted;
		private const float originalCameraFov = 60f;
		private const int rSPFXTrigger = 8;
		private const int srSPFXTrigger = 9;
		private const int ssrSPFXTrigger = 10;
		private const int stopSPFXTrigger = 1;
		public Camera mainCamera;
		private Animator cameraAnimator;
		private GameObject cameraAnimationParent;
		private Camera storedMainCamera;
		public Camera shot2CharaWeaponCamera;
		private bool isEnableScreenTapped;
		[CompilerGenerated]
		private bool _isScreenTapped_k__BackingField;
		private bool isEnableSkipTapped;
		[CompilerGenerated]
		private bool _isSkipTapped_k__BackingField;
		private bool isFadingOut;
		private List<PickupItemInfo> pickupItemIndexList;
		private Vector3 resultFlashCameraInitPosition;
		private BoxSummonPlayPhase playPhase;
		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;
		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;
		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;
		private BoxSummonAnimPage parentPage;
		private static readonly string SE_ITEM_FALL;
		private static readonly string SE_RARE_ITEM_GET;
		private const float darkBGColorPower = 0.3f;
		private List<SummonResultItemData> resultItems;
		private FlashPlayer[] itemFallFlashPlayers;
		private bool isTimerEnd;
		private IEnumerator checkCharaAppealEndCoroutine;
		private Coroutine shot2WaitCoroutine;
		private Coroutine shot2CutinSECoroutine;
		private Coroutine shot2CutinEffectCoroutine;
		private Coroutine shot2AdventSECoroutine;
		private const float charaCutinSETime = 1.8666667f;
		private const float charaCutinRaritySETime = 2.8f;
		private const float dragonCutinSETime = 2.2666667f;
		private const float dragonCutinRaritySETime = 3.2f;
		private const float moonCutinRaritySETime = 1.7f;
		private const string cutinSEName = "SE_SUMMON_0014";
		private const string cutinRSEName = "SE_SUMMON_0015";
		private const string cutinSRSEName = "SE_SUMMON_0016";
		private const string cutinSSRSEName = "SE_SUMMON_0017";
		private const float shot1StoneScale = 2.4f;
		private const float shot2StoneScale = 1.5f;
		private static readonly Vector2[] iconPosition1;
		private static readonly Vector2[] iconPosition2;
		private static readonly Vector2[] iconPosition3;
		private static readonly Vector2[] iconPosition4;
		private static readonly Vector2[] iconPosition5;
		private static readonly Vector2[] iconPosition6;
		private static readonly Vector2[] iconPosition7;
		private static readonly Vector2[] iconPosition8;
		private static readonly Vector2[] iconPosition9;
		public static readonly Vector2[] iconPosition10;
		public static readonly Vector2[][] iconPositions;
	
		// Properties
		Transform IPlaySummonInterface.node3d { get; }
		public Camera OverlayUICamera { get; }
		public bool isScreenTapped { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSkipTapped { [CompilerGenerated] get; [CompilerGenerated] set; }
		FlashPlayerManager IPlaySummonInterface.flashPlayerManager { get; }
		CameraClearFlags IPlaySummonInterface.oldFlashCameraClearFlags { get; set; }
		RenderTexture IPlaySummonInterface.charaWeaponRenderTexture { get; }
		public bool IsBoxSummon { get; }
	
		// Nested types
		public class PickupItemInfo
		{
			// Fields
			public int index;
			public int priority;
	
			// Constructors
			public PickupItemInfo();
			public PickupItemInfo(int index, int priority);
		}
	
		public enum BoxSummonPlayPhase
		{
			None = 0,
			Loading = 1,
			FistCut = 2,
			SkipFirstCut = 3,
			DropItem = 4,
			ItemDemo = 5,
			SkipItemDemo = 6,
			ItemDemoFinished = 7,
			ToResult = 8
		}
	
		private class CombinedMasterElement
		{
			// Fields
			public CharaDataElement charaMasterData;
			public DragonDataElement dragonMasterData;
			public WeaponBodyElement weaponMasterData;
	
			// Constructors
			public CombinedMasterElement();
	
			// Methods
			public SummonModel.StageEffectType GetStageEffectType();
		}
	
		private enum ItemFallKind
		{
			Normal = 0,
			Ssr = 1,
			Nof = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public bool loadDone;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _LoadResource_b__0();
			internal bool _LoadResource_b__1();
			internal void _LoadResource_b__2();
			internal bool _LoadResource_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__59_4;
			public static Func<bool> __9__92_0;
			public static Comparison<PickupItemInfo> __9__127_0;
			public static Func<bool> __9__138_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadResource_b__59_4();
			internal bool _SummonStageFlow_b__92_0();
			internal int _ItemFallCoroutine_b__127_0(PickupItemInfo a, PickupItemInfo b);
			internal bool _SkipCoroutine_b__138_0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadResource_d__59 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			private __c__DisplayClass59_0 __8__1;
			public Action loadEndCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadResource_d__59(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySummonAnimation_d__62 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isNextAnimation;
			public BoxSummonAnimScene __4__this;
			public Action animEndCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySummonAnimation_d__62(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Shot2ObjectDisableTimer_d__69 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			public float time;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Shot2ObjectDisableTimer_d__69(int __1__state);
	
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
			public BoxSummonAnimScene __4__this;
			public int i;
			private string _raritySoundName_5__2;
	
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
	
		[CompilerGenerated]
		private sealed class _PlayCutinEffectCoroutine_d__87 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int i;
			public BoxSummonAnimScene __4__this;
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
		private sealed class _CheckCharaAppealEndCoroutine_d__89 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckCharaAppealEndCoroutine_d__89(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayAdventSECoroutine_d__91 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			public int i;
			private SummonStageUtil _util_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayAdventSECoroutine_d__91(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SummonStageFlow_d__92 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SummonStageFlow_d__92(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartNextStageAnimation_d__93 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartNextStageAnimation_d__93(int __1__state);
	
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
			public int i;
	
			// Constructors
			public __c__DisplayClass94_0();
	
			// Methods
			internal bool _StartDragonShowingUp_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _StartDragonShowingUp_d__94 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			private __c__DisplayClass94_0 __8__1;
			private SummonStageUtil _util_5__2;
			private SummonStageResultSpecificLoadPool.DroppingObj[] _dropItemList_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartDragonShowingUp_d__94(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _KickSPFXEffectTriggerByRarityCoroutine_d__102 : IEnumerator<object>
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
			public _KickSPFXEffectTriggerByRarityCoroutine_d__102(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0
		{
			// Fields
			public AtgenBoxSummonResult summonResult;
			public int startIndex;
			public BoxSummonAnimScene __4__this;
			public Vector2[] positionArray;
			public int itemCount;
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass127_0();
	
			// Methods
			internal bool _ItemFallCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_1
		{
			// Fields
			public int i;
			public __c__DisplayClass127_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass127_1();
	
			// Methods
			internal bool _ItemFallCoroutine_b__2(AtgenBoxSummonDetail a);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_2
		{
			// Fields
			public FlashPlayer flashPlayer;
			public __c__DisplayClass127_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass127_2();
	
			// Methods
			internal void _ItemFallCoroutine_b__3(int index);
		}
	
		[CompilerGenerated]
		private sealed class _ItemFallCoroutine_d__127 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			private __c__DisplayClass127_0 __8__1;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ItemFallCoroutine_d__127(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SkipFirstDemoCoroutine_d__135 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SkipFirstDemoCoroutine_d__135(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SkipCoroutine_d__138 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonAnimScene __4__this;
			public bool needFadeOut;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SkipCoroutine_d__138(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BoxSummonAnimScene();
		static BoxSummonAnimScene();
	
		// Methods
		public void Start();
		public void OnDestroy();
		public void Init();
		public void StartLoading(BoxSummonAnimPage page, bool show3DModel, Action loadEndCallback);
		[IteratorStateMachine]
		private IEnumerator LoadResource(Action loadEndCallback);
		private void OnAllAsyncLoadPrepared();
		public void StartAnimation(Action animEndCallback, bool isNextAnimation = false);
		[IteratorStateMachine]
		private IEnumerator PlaySummonAnimation(Action animEndCallback, bool isNextAnimation = false);
		private void CameraInitialize();
		private void ResetCameraPositionInStage();
		private void RemoveTouchGuard();
		[IteratorStateMachine]
		private IEnumerator Shot2ObjectDisableTimer(float time);
		private void StopShot2ObjectDisableTimer();
		public void TerminatePostEffect(SummonPostEffectSettingsBase.SettingSetType type);
		[IteratorStateMachine]
		private IEnumerator PlayCutinSECoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator PlayCutinEffectCoroutine(int i);
		public void CharactorAppeal(int index);
		[IteratorStateMachine]
		private IEnumerator CheckCharaAppealEndCoroutine(int index);
		private void PlayCutin(int index);
		[IteratorStateMachine]
		private IEnumerator PlayAdventSECoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator SummonStageFlow();
		[IteratorStateMachine]
		private IEnumerator StartNextStageAnimation();
		[IteratorStateMachine]
		private IEnumerator StartDragonShowingUp();
		private void FallItemSetup();
		private void Reset();
		public void OnFinalize();
		private void ResetCamera(bool bIsDragon = false);
		private void ProphetSetup();
		public void SchedulePostEffect(SummonPostEffectSettingsBase.SettingSetType type);
		private void KickSPFXEffectTriggerByRarity(GameObject go, Rarity rarity, int offset = 0);
		[IteratorStateMachine]
		private IEnumerator KickSPFXEffectTriggerByRarityCoroutine(GameObject go, Rarity rarity, int offSet);
		public bool IsPlayCameraAnimation();
		void IPlaySummonInterface.StartWhiteOutEffect(float inTime, float outTime);
		public void OnBoxSummonEvent(BoxSummonEventId eid);
		public void SkipFirstCut();
		public void StartItemFall();
		public void DestroyItemFallFlashPlayers();
		public void ShowItemFallFlashPlayers(bool toShow);
		private void SetupEtoECamera();
		private void ResetEtoECamera();
		private void ExitItemFall();
		[IteratorStateMachine]
		private IEnumerator ItemFallCoroutine();
		private FlashPlayer GetItemFallFlashPlayer(int index);
		public void ClearAll();
		public void DestroyStage3DNodeChildren();
		private void GoToResult(bool isFadingOut);
		private void DestroyChildren(Transform t);
		public bool OnScreenTapped();
		private void SetEnableScreenTapped(bool f);
		[IteratorStateMachine]
		private IEnumerator SkipFirstDemoCoroutine();
		public void SetEnableSkipTapped(bool f);
		public void SkipAniamtion(bool needFadeOut);
		[IteratorStateMachine]
		private IEnumerator SkipCoroutine(bool needFadeOut);
		public void SetupStageRenderCamera(bool isEnable, RenderTexture shot2CharaWeaponRenderTexture = null);
		[CompilerGenerated]
		private bool _SummonStageFlow_b__92_1();
		[CompilerGenerated]
		private bool _SummonStageFlow_b__92_2();
		[CompilerGenerated]
		private bool _SummonStageFlow_b__92_3();
		[CompilerGenerated]
		private bool _StartNextStageAnimation_b__93_0();
		[CompilerGenerated]
		private bool _StartNextStageAnimation_b__93_1();
		[CompilerGenerated]
		private bool _StartDragonShowingUp_b__94_1();
		[CompilerGenerated]
		private bool _StartDragonShowingUp_b__94_2();
	}
}
