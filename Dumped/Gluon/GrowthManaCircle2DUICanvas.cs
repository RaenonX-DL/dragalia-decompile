using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircle2DUICanvas : MonoBehaviour
	{
		public GameObject star;

		public GameObject manaPoint;

		public GameObject platinumCrystal;

		public Button menuButton;

		public Button autoButton;

		public Button abilityListButton;

		public Button platinumButton;

		public Text abilityDetailButtonText;

		public Text growthButtonText;

		public Text autoButtonText;

		public Text manaPointText;

		public Text releasedNumText;

		public Text platinumCrystalCountText;

		[SerializeField]
		private Image usePlatinumCrystalButtonImage;

		[SerializeField]
		private Sprite spriteUsePlatinumCrystal1;

		[SerializeField]
		private Sprite spriteUsePlatinumCrystal2;

		public DragEventScrollRect CircleScrollRect;

		public RectTransform circlrObjectParent;

		[HideInInspector]
		public GrowthManaCircle2DScene scene;

		private GrowthManaCircleModel model;

		private ManaCircle2DCircleObject[] firstCircleObjects;

		private SecondManaCircle2DCircleObject secondCircleObject;

		private int currentCircleIndex;

		private bool isFirstLoadEnded;

		private Vector3 manaPointDefaultPosition;

		private Vector3 manaPointCenterPosition;

		public const int firstCircleLastIndex = 4;

		public const float firstCircleLastCircleObjectHeight = 250f;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitScrollPosition()
		{
		}

		public void Reload()
		{
		}

		public void SetUIInteractable(bool interactable)
		{
		}

		public void SetActiveTutorialPiece()
		{
		}

		public void OnAbilityListButtonPressed()
		{
		}

		public void OnAutoButtonPressed()
		{
		}

		public void FirstCircleAutoReleaseAction()
		{
		}

		public void SecondCircleAutoReleaseAction()
		{
		}

		public void OnManaCircleMenuButtonPressed()
		{
		}

		public void MoveCircleListByCircleIndex(int circleIndex)
		{
		}

		public void PlayReleaseLimitBreakEffect([Optional] Action onCompleteCallBack)
		{
		}

		public void PlayReleaseAllPieceEffect(Action onCompleteCallBack, bool isUsePlatinumCrystal = false)
		{
		}

		public void CreateAllReleasedRewardPopup([Optional] Action onCompleteCallBack, bool isReloadUI = true)
		{
		}

		public void PlayLevelupEffect([Optional] Action onCompleteCallBack, bool isReloadUI = true)
		{
		}

		public void AutoReleasePiece(bool isReleaseSecondCircle = false)
		{
		}

		public void AutoReleasePieceByPieceData(GrowthManaCircleManaPieceData pieceData, bool isReleaseSecondCircle = false)
		{
		}

		public void AutoReleasePieceByCircleIndex(int circleIndex)
		{
		}

		private void AutoReleaseCommonAction(AutoReleasableAllCirclePointData autoReleasableData, Action autoReleasePopOkButtonCallBack)
		{
		}

		private void AutoReleaseDataSendCallBackAction(AutoReleasableAllCirclePointData autoReleasableData)
		{
		}

		private void PlayUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData, GrowthManaCircleManaPieceData[] pieceDataList, int limitBreakCount)
		{
		}

		public void OnPlatinumCrystalPressed()
		{
		}
	}
}
