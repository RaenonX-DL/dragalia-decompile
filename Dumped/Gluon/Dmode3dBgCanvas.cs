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
	public class Dmode3dBgCanvas : MonoBehaviour
	{
		public SceneBase baseScene;

		public Camera render3dCamera;

		public RectTransform render3d;

		public RectTransform renderMaskRect;

		public RawImage render3dImage;

		public QuestCharacterCtrl[] characterCtrls;

		public PartyObjectsSettings objectsSettings;

		public PartyBgmSyncSettings bgmSyncSettings;

		public float runAnimationDistance;

		public float animationDuration;

		private PartySceneState nowSceneState;

		private PartySceneState prevSceneState;

		public bool isPartyReload;

		public bool isPartyEffectReload;

		[SerializeField]
		private RectTransform dummyRectCharactor;

		[SerializeField]
		private RectTransform dummyRectEquip;

		[SerializeField]
		private RectTransform dummyRectQuestTop;

		private bool isInitialized;

		private RenderTexture render3dTexture;

		private int[] lastCharaIds;

		private float[] defaultPosXs;

		private float moveTime;

		private const float roteCharaImage = 0f;

		private const float roteEquipImage = 0f;

		private AudioPlayback characterVoice;

		private string nowVoiceSheetName;

		private string prevVoiceSheetName;

		private bool isVoiceLoadComplete;

		private int playVoiceIndex;

		private bool isRunInAnimationToLeft;

		private BitArray isLandAnimationLoadEnds;

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

		public const int maxRtWidth = 960;

		public const int maxRtHeight = 1080;

		public static PartySceneState initSceneState
		{
			[CompilerGenerated]
			get
			{
				return default(PartySceneState);
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

		public Image render3dImageFrame => null;

		private static int drawLayer => default(int);

		public static Dmode3dBgCanvas GetCurrentCanvas()
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

		public void ShowRenderImage(float delay = 0f, float fadeTime = 0.5f)
		{
		}

		public void FadeOutBgCanvas(float duration = 1f)
		{
		}

		public bool CheckCreateCharaModel()
		{
			return default(bool);
		}

		public void ReloadCharacterModel(int index, int charaId, AudioPlayback bgmPlayback, PartyReloadCharaAnimationType animationType, bool useLightProbe, bool isQuestAnimation)
		{
		}

		public IEnumerator ReloadCharacterModelCoroutine(int index, int charaId, AudioPlayback bgmPlayback, PartyReloadCharaAnimationType animationType, bool useLightProbe, bool isQuestAnimation)
		{
			return null;
		}

		private float GetBgmSyncDelayTime(int index)
		{
			return default(float);
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

		public bool IsCharactersCompleteLandAnimation()
		{
			return default(bool);
		}

		public void StartRunInAnimation(bool isToLeft)
		{
		}

		private IEnumerator StartRunInAnimationContine(int index)
		{
			return null;
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

		private void ReloadCharaPos(int index)
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

		public void SetupPartyCharacterVoice(int index)
		{
		}

		public void SetupPartyCharacterVoice(int index, int characterId, int voiceId = 6)
		{
		}

		private IEnumerator WaitLoadVoiceGroup()
		{
			return null;
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

		public void OnStatusButtonPressed(int characterIndex)
		{
		}
	}
}
