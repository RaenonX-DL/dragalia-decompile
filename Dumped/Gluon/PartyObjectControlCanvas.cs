using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyObjectControlCanvas : MonoBehaviour
	{
		public enum FrameMode
		{
			NONE,
			Party,
			Quest
		}

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

		public PartySceneState nowSceneState
		{
			[CompilerGenerated]
			get
			{
				return default(PartySceneState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PartySceneState prevSceneState
		{
			[CompilerGenerated]
			get
			{
				return default(PartySceneState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isMatching
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isResetPartyData
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isStartRunAnimation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isStartLoadAnimation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isLoadingClearPartyByPrevScene
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Image render3dImageFrame => null;

		public FlashPlayer QuestTransitionEffect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isPrevFrameModeQuest => default(bool);

		private static int drawLayer => default(int);

		public static PartyObjectControlCanvas GetCurrentCanvas()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void HideObject()
		{
		}

		public void InitCanvas()
		{
		}

		private void InitQuestTransitionEffect()
		{
		}

		public void ShowRenderImage(float delay = 0f, float fadeTime = 0.5f)
		{
		}

		public void UnloadRender3dTexture()
		{
		}

		public void FadeOutBgCanvas(float duration = 1f)
		{
		}

		public void FitMatchingCameras()
		{
		}

		public bool CheckCreateCharaModel()
		{
			return default(bool);
		}

		public void ReloadCharacterModel(int index, AudioPlayback bgmPlayback, PartyReloadCharaAnimationType animationType, bool useLightProbe, bool isQuestAnimation)
		{
		}

		public IEnumerator ReloadCharacterModelCoroutine(int index, AudioPlayback bgmPlayback, PartyReloadCharaAnimationType animationType, bool useLightProbe, bool isQuestAnimation)
		{
			return null;
		}

		private float GetBgmSyncDelayTime(int index)
		{
			return default(float);
		}

		public void ChangedLayerRecursivelyForMatchingRoom()
		{
		}

		public void ReloadMatchingRoomCharacterModel(int index, MatchingRoomPlayerData playerData, int memberIndex, AudioPlayback bgmPlayback, bool isAutoSelect = false, bool useLightProbe = true, [Optional] Action<GameObject> onLoaded)
		{
		}

		private void LandAnimationLoadComplete(int index)
		{
		}

		private IEnumerator LandAnimationLoadCompleteCoroutine(int index)
		{
			return null;
		}

		public void ReloadAllWeaponModel()
		{
		}

		public void SetCharaWeaponModel(int index, int charaId, int weaponSkinId)
		{
		}

		public void RemoveCharacterModel(int index, bool showWarpEffect = true)
		{
		}

		public void StartRunOutAnimation(bool isToLeft)
		{
		}

		public void StartRunInAnimation(bool isToLeft)
		{
		}

		private IEnumerator StartRunInAnimationContine(int index)
		{
			return null;
		}

		public void ReloadAttachEffect()
		{
		}

		private IEnumerator ReloadAttacheffect(int index)
		{
			return null;
		}

		private static Tweener DOHeight(RectTransform rect, float endHeight, float moveTime)
		{
			return null;
		}

		public void ChangeSceneState(PartySceneState state, [Optional] UnityAction changeStateCallBack)
		{
		}

		private IEnumerator WaitMoveAnimation(UnityAction callback)
		{
			return null;
		}

		public void SetBlurState(bool enableBlur, float duration = -1f)
		{
		}

		public void MaskPartyCharacter(bool show)
		{
		}

		public void MoveCamera()
		{
		}

		public void ReloadCameraPos()
		{
		}

		public void ReloadCharaPos()
		{
		}

		public void ReloadCharaPos(int index)
		{
		}

		public void ResetSettingParam()
		{
		}

		public void SetSceneState(PartySceneState nowState, PartySceneState prevScene)
		{
		}

		private void ResetRenderTextureInfo()
		{
		}

		private void MoveCharacter()
		{
		}

		private void SetDefaultPosX()
		{
		}

		public void SetupPartyCharacterVoice(int index, int characterId = -1, int voiceId = 6)
		{
		}

		private IEnumerator WaitLoadVoiceGroup()
		{
			return null;
		}

		public void ClearPartyCharacterVoice(int index)
		{
		}

		private void PlayPartyCharacterVoice(int voiceId)
		{
		}

		private IEnumerator WaitPlayVoiceDelay(int voiceId)
		{
			return null;
		}

		public void ChangeMotionSpeed()
		{
		}

		private float GetBgmSyncSpeed()
		{
			return default(float);
		}

		public void MapUpAnimation([Optional] Action onAnimationDone, PartyBaseScene.questTypeStatus type = PartyBaseScene.questTypeStatus.mainQuest)
		{
		}

		public void MapFadeOutAnimation(RenderTexture renderTexture)
		{
		}

		private IEnumerator MapFadeOutAnimationCorutine(RenderTexture renderTexture)
		{
			return null;
		}

		public Tweener SetScreenTransVisible(bool visible)
		{
			return null;
		}

		public void SwitchThemeColor()
		{
		}

		public void SetFlash(FlashPlayer flashPlayer)
		{
		}

		public void PlayIdleAnimationSyncBGM(AudioPlayback bgmPlayback)
		{
		}

		private IEnumerator PlayIdleAnimationSyncBGMCoroutine(AudioPlayback bgmPlayback)
		{
			return null;
		}

		private static bool IsQuestMode()
		{
			return default(bool);
		}
	}
}
