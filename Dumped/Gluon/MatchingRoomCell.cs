using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomCell : MonoBehaviour
	{
		public enum PanelMovementType
		{
			None,
			SlideInWithPlayerInfo,
			SlideOutAndClearToEmpty,
			SlideOutThenIn,
			SlideOutThenInWithPlayerInfo
		}

		private class UpdatableUserData
		{
			public MatchingRoomPlayerData playerData;

			public int playerIndex;

			public int memberIndex;

			public PanelMovementType movementType;

			public bool isPlayVoice;

			public UpdatableUserData()
			{
			}

			public UpdatableUserData(MatchingRoomPlayerData data, int playerIndex, int memberIndex, PanelMovementType movementType, bool isPlayVoice)
			{
			}

			public UpdatableUserData MergeData(UpdatableUserData data)
			{
				return null;
			}
		}

		private class ColorSet
		{
			public Color panelColor;

			public Color combatPowerPanelColor;

			public Color characterNameColor;

			public Color characterNameOutlineColor;

			public Color illustrationShadeColor;
		}

		[SerializeField]
		[Header("BackGroud")]
		public Image backgroudImage;

		public Image[] overlayBGs;

		[SerializeField]
		[Header("Mask to Alpha")]
		private UIImageMaskToAlpha[] maskToAlpha;

		[SerializeField]
		[Header("Illustration")]
		public Image illustration;

		public Image dragonEmpty;

		[SerializeField]
		[Header("3DLayer")]
		private RawImageWithAlphaBlend render3DImage;

		[SerializeField]
		[Header("CharacterInfo")]
		public Image characterInfoBG;

		public Image elementalIcon;

		public Text characterNameText;

		public Text combatPowerText;

		public Text raidCombatPowerText;

		public Image combatPowerInfoBG;

		public Image raidCombatPowerInfoBG;

		[SerializeField]
		private Image isEquipWeaponSkinIcon;

		[SerializeField]
		private Image effectiveAbilityImage1;

		[SerializeField]
		private Image effectiveAbilityImage2;

		public Image youMark;

		[SerializeField]
		[Header("PlayerInfo")]
		public Image playerInfoBG;

		public CanvasGroup playerInfoHiderCanvasGroup;

		public AnotherNameIcons anotherNameIcon;

		public Text anotherNameText;

		public Text playerNameText;

		public Image partySwitchCharaIcon;

		[SerializeField]
		[Header("TopLayer")]
		public Transform stampLocation;

		public Transform statusControlLocation;

		public CanvasGroup whiteFlashCanvasGroup;

		public Image[] playerIndexImages;

		public Button detailButton;

		[SerializeField]
		[Header("Publishers")]
		public AnimationUIAutoPublisher insideAnimationPublisher;

		public AnimationUIAutoPublisher insideWithoutPlayerNameAnimationPublisher;

		[SerializeField]
		[Header("Control")]
		public bool isLeft;

		public CanvasGroup emptyContentControl;

		[SerializeField]
		[Header("Layout")]
		public ContentSizeFitter rightCellNamgeLayoutFitter;

		[HideInInspector]
		public MatchingRoomCellStatusControl statusControl;

		[HideInInspector]
		public int positionIndex;

		[HideInInspector]
		public Camera render3DCamera;

		private MatchingReadyState lastReadyState;

		private const float delayByDelayIndex = 0.1f;

		private const float landingAlphaTime = 1f;

		private const float takingOffAlphaTime = 0.6f;

		private const string statusControlPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomCellStatusControl";

		private int power;

		private UpdatableUserData dataForDetail;

		private UpdatableUserData latestData;

		private UpdatableUserData processingData;

		private UpdatableUserData pendingData;

		private int _updatingCounter;

		private bool trySkipping;

		private List<Sequence> runningSkippableSequenceList;

		private ColorSet[] colorSet;

		[HideInInspector]
		public MatchingRoomScene matchingRoomScene;

		public bool isEnableRaidBoost;

		public static readonly int[] usingLayerList;

		private bool isFlushing;

		private bool isUpdatingData
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int questId
		{
			[CompilerGenerated]
			private get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void InitializeRenderTexture()
		{
		}

		private void SetupModelViewImage(bool enableAlphaBlend)
		{
		}

		public void DisableStamp()
		{
		}

		private void FlushSkippableSequences()
		{
		}

		private void AppendSkippableTweener(Tweener t)
		{
		}

		private void DoSlideOut(UpdatableUserData data, Action<UpdatableUserData> onComplete, bool withPlayerInfo)
		{
		}

		private void DoPanelMovement(UpdatableUserData data)
		{
		}

		public void UpdateByPlayerData(MatchingRoomPlayerData playerData, int playerIndex, int memberIndex, int delayIndex, PanelMovementType movementType, bool isPlayVoice)
		{
		}

		private IEnumerator UpdateByPlayerDataCoroutine(UpdatableUserData data, int delayIndex)
		{
			return null;
		}

		private void DoSlideIn(UpdatableUserData data, Action<UpdatableUserData> onComplete, bool withPlayerInfo)
		{
		}

		public void ClearToEmpty()
		{
		}

		private IEnumerator LayoutRebuildCoroutine()
		{
			return null;
		}

		private void UpdateUIByData(UpdatableUserData data)
		{
		}

		public void OnPartySwitchCharaPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		public void UpdateReadyState(MatchingReadyState state)
		{
		}

		public MatchingReadyState GetReadyState(MatchingService.Room myRoom)
		{
			return default(MatchingReadyState);
		}

		public int GetPower()
		{
			return default(int);
		}

		private void ShowEffectiveAbilityIcon(UpdatableUserData userData)
		{
		}

		private bool SetAbilityIcon(Image iconImage, int showAbility)
		{
			return default(bool);
		}

		private bool CheckEnableAbility(MatchingRoomDetailData detailData, UnitDetailModel.DetailDataBase.SkillAbilityInfo skillAbilityInfo)
		{
			return default(bool);
		}
	}
}
