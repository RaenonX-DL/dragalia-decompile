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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyObjectControlCanvas : MonoBehaviour
	{
		// Fields
		public SceneBase baseScene;
		public Camera render3dCamera;
		public RectTransform render3d;
		public Transform renderMask;
		public RectTransform renderMaskRect;
		public RawImage render3dImage;
		public QuestCharacterCtrl[] characterCtrls;
		public Camera[] matchingCharacterCameras;
		public Transform matchingCamerasNode;
		public PartyObjectsSettings objectsSettings;
		public PartyBgmSyncSettings bgmSyncSettings;
		public float runAnimationDistance;
		public float animationDuration;
		[CompilerGenerated]
		private PartySceneState _nowSceneState_k__BackingField;
		[CompilerGenerated]
		private PartySceneState _prevSceneState_k__BackingField;
		[CompilerGenerated]
		private bool _isMatching_k__BackingField;
		[CompilerGenerated]
		private bool _isResetPartyData_k__BackingField;
		[CompilerGenerated]
		private bool _isStartRunAnimation_k__BackingField;
		[CompilerGenerated]
		private bool _isStartLoadAnimation_k__BackingField;
		public bool isPartyReload;
		public bool isPartyEffectReload;
		public float edgeToEdgeOffsetY;
		[SerializeField]
		private RectTransform dummyRectTop;
		[SerializeField]
		private RectTransform dummyRectCharactor;
		[SerializeField]
		private RectTransform dummyRectEquip;
		[SerializeField]
		private RectTransform dummyRectQuestTop;
		[SerializeField]
		private RectTransform dummyRectMainQuestTop;
		[SerializeField]
		private RectTransform dummyRectMainQuestFrame;
		[SerializeField]
		private RectTransform dummyRectEventQuestTop;
		[SerializeField]
		private RectTransform dummyRectEventQuestFrame;
		[SerializeField]
		private RectTransform dummyRectRaidQuestTop;
		[SerializeField]
		private RectTransform dummyRectRaidQuestTopFrame;
		private bool isInitialized;
		private RenderTexture render3dTexture;
		private int[] lastCharaIds;
		private float[] defaultPosXs;
		private float moveTime;
		private const float roteCharaImage = 0f;
		private const float roteEquipImage = 0f;
		private const float baseImageY = 59f;
		private const float questBaseImageY = 65f;
		private AudioPlayback characterVoice;
		private string nowVoiceSheetName;
		private string prevVoiceSheetName;
		private bool isVoiceLoadComplete;
		private int playVoiceIndex;
		private bool isRunInAnimationToLeft;
		private BitArray isLandAnimationLoadEnds;
		private bool isBackgroundBlurred;
		[SerializeField]
		private RawImage render3dImageBlack;
		[SerializeField]
		private Image outerFrame;
		[SerializeField]
		private RectTransform frameMask;
		private const float outerFrameMergin = 9f;
		[SerializeField]
		private float frameMerginTop;
		[SerializeField]
		private float frameMerginChara;
		[SerializeField]
		private float frameMerginEquip;
		[SerializeField]
		private float frameFadeoutFrameToQuestSelect;
		private Action onAnimationDone;
		public float mapMove;
		public float fedeIn;
		public float fadeout;
		private bool isMapAnim;
		public GameObject transEffect;
		public Vector3 flashScale;
		public float animationTime;
		public float flashSec;
		public float mainOffset;
		public float eventOffset;
		public Vector2 pivot;
		public float offsetPivot;
		private Canvas enemyMapCanvas;
		private FlashPlayer questTransitionEffect;
		private PartyBaseScene.questTypeStatus questTypeStatus;
		private FrameMode currentFrameMode;
		private FrameMode prevFrameMode;
		public const float modelAnimationDuration = 0.54f;
		public const int maxRtWidth = 960;
		public const int maxRtHeight = 1080;
	
		// Properties
		public PartySceneState nowSceneState { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PartySceneState prevSceneState { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isMatching { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isResetPartyData { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isStartRunAnimation { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isStartLoadAnimation { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Image render3dImageFrame { get; }
		public FlashPlayer QuestTransitionEffect { get; set; }
		public bool isPrevFrameModeQuest { get; }
		private static int drawLayer { get; }
	
		// Nested types
		public enum FrameMode
		{
			NONE = 0,
			Party = 1,
			Quest = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass117_0
		{
			// Fields
			public PartyObjectControlCanvas __4__this;
			public int index;
			public int charaId;
			public bool useLightProbe;
			public PartyReloadCharaAnimationType animationType;
			public bool isQuestAnimation;
			public AudioPlayback bgmPlayback;
			public UnityAction<int> __9__2;
			public Func<float> __9__3;
	
			// Constructors
			public __c__DisplayClass117_0();
	
			// Methods
			internal bool _ReloadCharacterModelCoroutine_b__0();
			internal void _ReloadCharacterModelCoroutine_b__1(GameObject character);
			internal void _ReloadCharacterModelCoroutine_b__2(int x);
			internal float _ReloadCharacterModelCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _ReloadCharacterModelCoroutine_d__117 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public int index;
			public bool useLightProbe;
			public PartyReloadCharaAnimationType animationType;
			public bool isQuestAnimation;
			public AudioPlayback bgmPlayback;
			private __c__DisplayClass117_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReloadCharacterModelCoroutine_d__117(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public Action<GameObject> onLoaded;
			public PartyObjectControlCanvas __4__this;
			public int index;
			public bool useLightProbe;
			public int charaId;
			public int memberIndex;
			public AudioPlayback bgmPlayback;
			public UnityAction<int> __9__1;
			public Func<float> __9__2;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal void _ReloadMatchingRoomCharacterModel_b__0(GameObject character);
			internal void _ReloadMatchingRoomCharacterModel_b__1(int x);
			internal float _ReloadMatchingRoomCharacterModel_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _LandAnimationLoadCompleteCoroutine_d__121 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LandAnimationLoadCompleteCoroutine_d__121(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartRunInAnimationContine_d__127 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartRunInAnimationContine_d__127(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReloadAttacheffect_d__129 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public int index;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReloadAttacheffect_d__129(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass130_0
		{
			// Fields
			public RectTransform rect;
			public float beginHeight;
			public float endHeight;
	
			// Constructors
			public __c__DisplayClass130_0();
	
			// Methods
			internal void _DOHeight_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class _WaitMoveAnimation_d__132 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitMoveAnimation_d__132(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass133_0
		{
			// Fields
			public PostEffect postEffect;
	
			// Constructors
			public __c__DisplayClass133_0();
	
			// Methods
			internal void _SetBlurState_b__0(float x);
			internal void _SetBlurState_b__1(float x);
			internal void _SetBlurState_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass144_0
		{
			// Fields
			public PartyObjectControlCanvas __4__this;
			public int voiceId;
	
			// Constructors
			public __c__DisplayClass144_0();
	
			// Methods
			internal void _SetupPartyCharacterVoice_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitLoadVoiceGroup_d__145 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitLoadVoiceGroup_d__145(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPlayVoiceDelay_d__148 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public int voiceId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPlayVoiceDelay_d__148(int __1__state);
	
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
			public static TweenCallback __9__151_2;
			public static TweenCallback __9__154_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _MapUpAnimation_b__151_2();
			internal void _SetScreenTransVisible_b__154_0();
		}
	
		[CompilerGenerated]
		private sealed class _MapFadeOutAnimationCorutine_d__153 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MapFadeOutAnimationCorutine_d__153(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayIdleAnimationSyncBGMCoroutine_d__158 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyObjectControlCanvas __4__this;
			public AudioPlayback bgmPlayback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayIdleAnimationSyncBGMCoroutine_d__158(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PartyObjectControlCanvas();
	
		// Methods
		public static PartyObjectControlCanvas GetCurrentCanvas();
		private void OnDestroy();
		public void HideObject();
		public void InitCanvas();
		private void InitQuestTransitionEffect();
		public void ShowRenderImage(float delay = 0f, float fadeTime = 0.5f);
		public void UnloadRender3dTexture();
		public void FadeOutBgCanvas(float duration = 1f);
		public void FitMatchingCameras();
		public bool CheckCreateCharaModel();
		public void ReloadCharacterModel(int index, AudioPlayback bgmPlayback, PartyReloadCharaAnimationType animationType, bool useLightProbe, bool isQuestAnimation);
		[IteratorStateMachine]
		public IEnumerator ReloadCharacterModelCoroutine(int index, AudioPlayback bgmPlayback, PartyReloadCharaAnimationType animationType, bool useLightProbe, bool isQuestAnimation);
		private float GetBgmSyncDelayTime(int index);
		public void ReloadMatchingRoomCharacterModel(int index, MatchingRoomPlayerData playerData, int memberIndex, AudioPlayback bgmPlayback, bool isAutoSelect = false, bool useLightProbe = true, Action<GameObject> onLoaded = null);
		private void LandAnimationLoadComplete(int index);
		[IteratorStateMachine]
		private IEnumerator LandAnimationLoadCompleteCoroutine(int index);
		public void ReloadAllWeaponModel();
		public void SetCharaWeaponModel(int index, int weaponSkinId);
		public void RemoveCharacterModel(int index, bool showWarpEffect = true);
		public void StartRunOutAnimation(bool isToLeft);
		public void StartRunInAnimation(bool isToLeft);
		[IteratorStateMachine]
		private IEnumerator StartRunInAnimationContine(int index);
		public void ReloadAttachEffect();
		[IteratorStateMachine]
		private IEnumerator ReloadAttacheffect(int index);
		private static Tweener DOHeight(RectTransform rect, float endHeight, float moveTime);
		public void ChangeSceneState(PartySceneState state, UnityAction changeStateCallBack = null);
		[IteratorStateMachine]
		private IEnumerator WaitMoveAnimation(UnityAction callback);
		public void SetBlurState(bool enableBlur, float duration = -1f);
		public void MaskPartyCharacter(bool show);
		public void MoveCamera();
		public void ReloadCameraPos();
		public void ReloadCharaPos();
		public void ReloadCharaPos(int index);
		public void ResetSettingParam();
		public void SetSceneState(PartySceneState nowState, PartySceneState prevScene);
		private void ResetRenderTextureInfo();
		private void MoveCharacter();
		private void SetDefaultPosX();
		public void SetupPartyCharacterVoice(int index, int characterId = -1, int voiceId = 6);
		[IteratorStateMachine]
		private IEnumerator WaitLoadVoiceGroup();
		public void ClearPartyCharacterVoice(int index);
		private void PlayPartyCharacterVoice(int voiceId);
		[IteratorStateMachine]
		private IEnumerator WaitPlayVoiceDelay(int voiceId);
		public void ChangeMotionSpeed();
		private float GetBgmSyncSpeed();
		public void MapUpAnimation(Action onAnimationDone = null, PartyBaseScene.questTypeStatus type = PartyBaseScene.questTypeStatus.mainQuest);
		public void MapFadeOutAnimation(RenderTexture renderTexture);
		[IteratorStateMachine]
		private IEnumerator MapFadeOutAnimationCorutine(RenderTexture renderTexture);
		public Tweener SetScreenTransVisible(bool visible);
		public void SwitchThemeColor();
		public void SetFlash(FlashPlayer flashPlayer);
		public void PlayIdleAnimationSyncBGM(AudioPlayback bgmPlayback);
		[IteratorStateMachine]
		private IEnumerator PlayIdleAnimationSyncBGMCoroutine(AudioPlayback bgmPlayback);
		private static bool IsQuestMode();
		[CompilerGenerated]
		private bool _LandAnimationLoadCompleteCoroutine_b__121_0();
		[CompilerGenerated]
		private void _StartRunInAnimation_b__126_0();
		[CompilerGenerated]
		private void _MoveCamera_b__135_0();
		[CompilerGenerated]
		private bool _WaitLoadVoiceGroup_b__145_0();
		[CompilerGenerated]
		private void _MapUpAnimation_b__151_1();
		[CompilerGenerated]
		private void _MapUpAnimation_b__151_0();
		[CompilerGenerated]
		private bool _MapFadeOutAnimationCorutine_b__153_0();
		[CompilerGenerated]
		private void _MapFadeOutAnimationCorutine_b__153_1();
		[CompilerGenerated]
		private bool _PlayIdleAnimationSyncBGMCoroutine_b__158_0();
	}
}
