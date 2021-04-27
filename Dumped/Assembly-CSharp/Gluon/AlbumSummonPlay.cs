/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumSummonPlay : MonoBehaviour, IPlaySummonInterface
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
		[SerializeField]
		private Camera mainCamera;
		[SerializeField]
		private Camera shot2CharaWeaponCamera;
		[HideInInspector]
		public Transform node3d;
		[CompilerGenerated]
		private bool _isScreenTapped_k__BackingField;
		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;
		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;
		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;
		private const float charaCutinBGMTime = 1f;
		private Coroutine shot2CutinBGMCoroutine;
		private Coroutine shot2CutinSECoroutine;
		private Coroutine shot2CutinEffectCoroutine;
		private Coroutine shot2AdventSECoroutine;
		private Coroutine shot2CutinTextureOffsetCoroutine;
		private Coroutine shot2WaitCoroutine;
		private Coroutine _execCoroutine;
		private IEnumerator checkCharaAppealEndCoroutine;
		private const int rSPFXTrigger = 8;
		private const int srSPFXTrigger = 9;
		private const int ssrSPFXTrigger = 10;
		private const int stopSPFXTrigger = 1;
		private const float originalCameraFov = 60f;
		private const float shot1StoneScale = 2.4f;
		private const float shot2StoneScale = 1.5f;
		private const float darkBGColorPower = 0.3f;
		private bool isTimerEnd;
		private Camera flashCamera;
		private List<SummonResultItemData> resultItems;
		private AlbumSummonCanvas parentPage;
		private Vector3 resultFlashCameraInitPosition;
		private Animator cameraAnimator;
		private GameObject cameraAnimationParent;
		private Camera storedMainCamera;
		private bool isEnableScreenTapped;
		private BoxSummonPlayPhase playPhase;
		private SummonUnitShaderSettings unitShaderSettings;
		private AudioPlayback bgmAudioPlayer;
	
		// Properties
		public Camera OverlayUICamera { get; }
		public bool isScreenTapped { [CompilerGenerated] get; [CompilerGenerated] set; }
		FlashPlayerManager IPlaySummonInterface.flashPlayerManager { get; }
		Transform IPlaySummonInterface.node3d { get; }
		CameraClearFlags IPlaySummonInterface.oldFlashCameraClearFlags { get; set; }
		RenderTexture IPlaySummonInterface.charaWeaponRenderTexture { get; }
		public bool IsBoxSummon { get; }
	
		// Nested types
		public enum BoxSummonPlayPhase
		{
			None = 0,
			Loading = 1,
			FistCut = 2,
			DropItem = 3,
			ItemDemo = 4,
			ItemDemoFinished = 5,
			ToResult = 6
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public bool loadDone;
	
			// Constructors
			public __c__DisplayClass60_0();
	
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
			public static Func<bool> __9__60_4;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadResource_b__60_4();
		}
	
		[CompilerGenerated]
		private sealed class _LoadResource_d__60 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
			private __c__DisplayClass60_0 __8__1;
			public Action loadEndCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadResource_d__60(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _LoadSummonBgScene_b__0();
			internal bool _LoadSummonBgScene_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSummonBgScene_d__61 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSummonBgScene_d__61(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySummonAnimation_d__65 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySummonAnimation_d__65(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Shot2ObjectDisableTimer_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
			public float time;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Shot2ObjectDisableTimer_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayBgmCorutine_d__71 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayBgmCorutine_d__71(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCutinSECoroutine_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
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
			public _PlayCutinSECoroutine_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCutinEffectCoroutine_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int i;
			public AlbumSummonPlay __4__this;
			private SummonStageUtil _util_5__2;
			private SummonStageResultSpecificLoadPool _specPool_5__3;
			private SummonStageObjectsSettings _settings_5__4;
			private Rarity _rarity_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayCutinEffectCoroutine_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCutinOuterTextureOffsetCoroutine_d__74 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int i;
			public AlbumSummonPlay __4__this;
			private SummonStageResultSpecificLoadPool _specPool_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayCutinOuterTextureOffsetCoroutine_d__74(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CheckCharaAppealEndCoroutine_d__76 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckCharaAppealEndCoroutine_d__76(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayAdventSECoroutine_d__78 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
			public int i;
			private SummonStageUtil _util_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayAdventSECoroutine_d__78(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartNextStageAnimation_d__79 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartNextStageAnimation_d__79(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public int i;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal bool _StartUnitShowingUp_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _StartUnitShowingUp_d__80 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumSummonPlay __4__this;
			private __c__DisplayClass80_0 __8__1;
			private SummonStageUtil _util_5__2;
			private SummonStageResultSpecificLoadPool.DroppingObj[] _dropItemList_5__3;
			private SummonStageResultSpecificLoadPool _specificPool_5__4;
			private Rarity _rarity_5__5;
			private List<SummonStageResultSpecificLoadPool.SummonModelSetting> _modelSettingList_5__6;
			private WeaponType _weaponType_5__7;
			private bool _useWeaponModel_5__8;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartUnitShowingUp_d__80(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _KickSPFXEffectTriggerByRarityCoroutine_d__88 : IEnumerator<object>
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
			public _KickSPFXEffectTriggerByRarityCoroutine_d__88(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AlbumSummonPlay();
	
		// Methods
		public void Start();
		public void OnDestroy();
		public void Init();
		public void StartLoading(AlbumSummonCanvas page, Camera camera, Action loadEndCallback);
		[IteratorStateMachine]
		private IEnumerator LoadResource(Action loadEndCallback);
		[IteratorStateMachine]
		public IEnumerator LoadSummonBgScene();
		public void UnloadSummonBgScene();
		private void OnAllAsyncLoadPrepared();
		public void StartAnimation();
		[IteratorStateMachine]
		private IEnumerator PlaySummonAnimation();
		private void CameraInitialize();
		private void ResetCameraPositionInStage();
		[IteratorStateMachine]
		private IEnumerator Shot2ObjectDisableTimer(float time);
		private void StopShot2ObjectDisableTimer();
		public void TerminatePostEffect(SummonPostEffectSettingsBase.SettingSetType type);
		[IteratorStateMachine]
		private IEnumerator PlayBgmCorutine();
		[IteratorStateMachine]
		private IEnumerator PlayCutinSECoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator PlayCutinEffectCoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator PlayCutinOuterTextureOffsetCoroutine(int i);
		public void CharactorAppeal(int index);
		[IteratorStateMachine]
		private IEnumerator CheckCharaAppealEndCoroutine(int index);
		private void PlayCutin(int index);
		[IteratorStateMachine]
		private IEnumerator PlayAdventSECoroutine(int i);
		[IteratorStateMachine]
		private IEnumerator StartNextStageAnimation();
		[IteratorStateMachine]
		private IEnumerator StartUnitShowingUp();
		private void SetWeaponVisibilityState(int index, bool useWeaponModel, bool isMainWeapon, bool visible);
		private void SetWeaponBindArmState(int index, bool useWeaponModel, bool isMainWeapon, bool rightArm);
		private void FallItemSetup();
		private void Reset();
		public void OnFinalize();
		public void SchedulePostEffect(SummonPostEffectSettingsBase.SettingSetType type);
		private void KickSPFXEffectTriggerByRarity(GameObject go, Rarity rarity, int offset = 0);
		[IteratorStateMachine]
		private IEnumerator KickSPFXEffectTriggerByRarityCoroutine(GameObject go, Rarity rarity, int offSet);
		public bool IsPlayCameraAnimation();
		void IPlaySummonInterface.StartWhiteOutEffect(float inTime, float outTime);
		public void OnBoxSummonEvent(BoxSummonEventId eid);
		public void ResetCamera();
		private void SetupEtoECamera();
		public void ClearAll();
		private void GoToResult();
		private void DestroyChildren(Transform t);
		public bool OnScreenTapped();
		private void SetEnableScreenTapped(bool f);
		public void SetupStageRenderCamera(bool isEnable, RenderTexture shot2CharaWeaponRenderTexture = null);
		[CompilerGenerated]
		private void _Start_b__56_0();
		[CompilerGenerated]
		private bool _StartNextStageAnimation_b__79_0();
		[CompilerGenerated]
		private void _StartUnitShowingUp_b__80_0();
		[CompilerGenerated]
		private bool _StartUnitShowingUp_b__80_1();
		[CompilerGenerated]
		private bool _StartUnitShowingUp_b__80_3();
		[CompilerGenerated]
		private bool _StartUnitShowingUp_b__80_5();
		[CompilerGenerated]
		private bool _StartUnitShowingUp_b__80_6();
		[CompilerGenerated]
		private bool _StartUnitShowingUp_b__80_4();
	}
}
