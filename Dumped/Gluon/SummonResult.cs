using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonResult : MonoBehaviour
	{
		private static SummonResult instance;

		public Action onBackButtonTouched;

		public Action<SummonTopItemData.ButtonType> onSummonButtonTouched;

		[SerializeField]
		[Header("Result")]
		public GameObject multiSummonResult;

		public GameObject singleSummonResult;

		[SerializeField]
		[Header("MultiPosition")]
		public GameObject[] multiSummonCharaIconPosList;

		[SerializeField]
		[Header("ReSummonButtons")]
		public GameObject singleSummonButtonObject;

		public GameObject multiSummonButtonObject;

		public SummonButton multiSummonButton;

		public GameObject multiSummonBalloon;

		public GameObject manyFreeMultiSummonBalloon;

		public Text manyFreeMultiSummonBalloonText;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject firstViewBottomItemNode;

		public GameObject backButtonGO;

		public GameObject captionGO;

		public GameObject autoPresentBoxTextNode;

		public Image whiteFade;

		public GameObject bonusButton;

		public float bonusPopupDelayTime;

		[SerializeField]
		[Header("Illustration")]
		public GameObject illustration;

		public Transform illustrationViewOffset;

		public UnitDetail2dModel illustrationImage;

		[SerializeField]
		[Header("2d3d")]
		public Transform switchEffectAttachPoint;

		public Text switch2d3dButtonText;

		public GameObject switch2d3dButtonGO;

		public GameObject detailButtonGO;

		public DragEventScrollRect dragScrollRect;

		[SerializeField]
		[Header("Ownwed")]
		public GameObject ownedSingleTickedLine;

		public GameObject ownedMultiTicketLine;

		public GameObject ownedStoneLine;

		public GameObject ownedPaidStoneLine;

		public Text ownedSingleTicketCountText;

		public Text ownedMultiTicketCountText;

		public Text ownedFreeStoneCountText;

		public Text ownedPaidStoneCountText;

		public Text ownedMoonCountText;

		public GameObject ownedFrame;

		[SerializeField]
		[Header("CaptionIcon")]
		public Image singleCaptionIcon;

		public Image multiCaptionIcon;

		public Image dailyCaptionIcon;

		[SerializeField]
		[Header("DisplayMoon")]
		public CommonIcon moonIcon;

		[SerializeField]
		[Header("Plate")]
		public SummonResultStatusPlate statusPlate;

		[SerializeField]
		[Header("RenderTextures")]
		public RawImage bg3dRenderTextureImage;

		public RawImageWithAlphaBlend chara3dRenderTextureImage;

		public RawImage flashTextureImage;

		[SerializeField]
		[Header("Story")]
		public SimpleStoryManager storyManager;

		[SerializeField]
		[Header("ExchangeSummon")]
		public GameObject exchangeSummonNode;

		public Text beforeExchangeSummon;

		public Text afterExchangeSummon;

		public Image exchangeSummonImage;

		[SerializeField]
		[Header("Publishers")]
		public UIAnimationPublisher multiPublisher;

		public UIAnimationPublisher singlePublisher;

		public UIAnimationPublisher majorEnterPublisher;

		public UIAnimationPublisher exitPubliser;

		public UIAnimationPublisher subExitPubliser;

		[SerializeField]
		private float fadeTimeFactor;

		private FlashPlayer switchFlashPlayer;

		private bool bShowing2D;

		private int showingResultIndex;

		private bool bShowingSingleDetailOnMultiPage;

		private Transform current3DTransform;

		private float panelAnimationMoveDist;

		private float panelAnimationBaseDuration;

		private float panelAnimation10SwitchWaitTime;

		private float panelAnimationSwitchWaitTime;

		private float amuletScale;

		private Vector3 amuletViewOffset;

		private int oldFlashCameraDepth;

		private Vector3 originalChara3DCameraPosition;

		private readonly Vector3 resultChara3DCameraPosition;

		private RenderTexture bgRenderTexture;

		[HideInInspector]
		public SummonScene scene;

		private Camera oldFlashCamera;

		private FlashPlayer[] itemFallFlashPlayers;

		private FlashPlayer[] haloBackFlashPlayers;

		private FlashPlayer[] haloFrontFlashPlayers;

		private FlashPlayer[] bonusFrontFlashPlayers;

		private FlashPlayer extraBonusFrontFlashPlayers;

		private const string haloBackFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_thumb_panel_effect_halo";

		private const string haloFrontFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_thumb_panel_effect_ster";

		private const string summonResultBonusFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_SummonResultBonus";

		private const string summonResultExtraBonusFlashPrefabPath = "Prefabs/OutGame/SummonShop/Result/SSRHaloFlash/pf_SummonResultExtraBonus";

		private const string flashLabelIconSquare = "init_sharp";

		private const string flashLabelIconRounded = "init_round";

		private const string flashLabelIconCut = "init_unique";

		private const string flashLabelBonus6thPrize = "Bonus_06";

		private const string flashLabelBonus5thPrize = "Bonus_05";

		private const string flashLabelBonusBronze = "Bonus_04";

		private const string flashLabelBonusSilver = "Bonus_03";

		private const string flashLabelBonusGold = "Bonus_02";

		private const string flashLabelBonusPlatinum = "Bonus_01";

		private const string flashBonusPlatinumSound = "SE_OUT_COMMON_0065";

		private const string flashBonusGoldSound = "SE_OUT_COMMON_0066";

		private const string flashBonusSilverSound = "SE_OUT_COMMON_0067";

		private const string flashBonusPocoPocoSound = "SE_OUT_COMMON_0068";

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

		public static SummonResult Instance => null;

		public SummonModelBase model
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private SummonResult()
		{
		}

		static SummonResult()
		{
		}

		public void Start()
		{
		}

		private bool IsExchangeSummon()
		{
			return default(bool);
		}

		public void StartItemFall()
		{
		}

		public static Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos)
		{
			return default(Vector3);
		}

		private void SetFlashObjectPosition(FlashPlayer flashPlayer, Vector3 rawPosition, string[] objNameList)
		{
		}

		private string GetFlashLabelByGiftTypeForIcon(GiftType giftType)
		{
			return null;
		}

		private string GetFlashLabelByBonusType(int index)
		{
			return null;
		}

		private string GetFlashSoundLabelByBonusType(int index)
		{
			return null;
		}

		private void SetEnableResultFlash(bool enable)
		{
		}

		private IEnumerator ItemFallCoroutine()
		{
			return null;
		}

		public void RefreshPrice()
		{
		}

		private void ShowTutorialPop()
		{
		}

		private IEnumerator ShowTutorialPopCoroutine()
		{
			return null;
		}

		private void DestroyItemFallFlashPlayers()
		{
		}

		public void Setup(SummonModelBase model)
		{
		}

		public void OnListItemClicked(SummonResultItemData data, int resultIndex)
		{
		}

		public void MovePanelYInstantly(Transform t, float dist)
		{
		}

		public void SetPanelAlpha(Transform t, float alpha = 1f)
		{
		}

		private void SetSingleResultView([Optional] SummonResultItemData data, int resultIndex = 0, bool playAnimation = true)
		{
		}

		public void OnSwitchToMultiListButtonClicked()
		{
		}

		public void OnBonusDetailButtonClicked()
		{
		}

		private void LoadMultiResultList()
		{
		}

		public void OnRedrawButtonPressed(SummonTopItemData.ButtonType buttonType)
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		private void OnSceneLoadEnd()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSwitchTo2DMode(bool isBySwitchButton = false)
		{
		}

		private void DoSwitchTo2DMode()
		{
		}

		private void OnSwitchTo3DMode(bool isBySwitchButton = false)
		{
		}

		private void DoSwitchTo3DMode()
		{
		}

		private void Set3DModel(SummonResultItemData item)
		{
		}

		public void OnSwitch3D2DButtonClicked()
		{
		}

		public void OnScrollRectValueChanged(Vector2 changedVal)
		{
		}

		public void StartToStageAnimation(Action onDone)
		{
		}

		public void PlaySwitchFlash()
		{
		}

		public void OnExchangeSummonDetail()
		{
		}

		public void ExchangePopup(Action onClose)
		{
		}

		public void OnBeforeSceneLeaving()
		{
		}
	}
}
