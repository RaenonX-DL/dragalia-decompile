using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ManagedFacilityCell : FacilityCellBase
	{
		private static readonly int GRID_UNIT_SIZE;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private Image gridImage;

		[SerializeField]
		private Text nameLabel;

		[SerializeField]
		private Text levelLabel;

		[SerializeField]
		[Header("Buttons")]
		private Button centerButton;

		[SerializeField]
		private Button leftButton;

		[SerializeField]
		private Button rightButton;

		[SerializeField]
		[Header("Texts")]
		private Text centerButtonText;

		[SerializeField]
		private Text leftButtonText;

		[SerializeField]
		private Text rightButtonText;

		[SerializeField]
		private Text buildingRemainText;

		[SerializeField]
		[Header("Images")]
		private Sprite buttonGreenBg;

		[SerializeField]
		private Sprite buttonWhiteBg;

		[SerializeField]
		private GameObject upgradeableText;

		[SerializeField]
		private GameObject maxLevelText;

		[SerializeField]
		[Header("disable Node")]
		private GameObject disablePanel;

		[SerializeField]
		private Text disableText;

		[SerializeField]
		private GameObject storedCountObject;

		[SerializeField]
		private Text storedCount;

		private RectTransform gridRectTransformCache;

		private Image rightButtonBgImage;

		private Image centerButtonBgImage;

		private Material buildingFacilityMat;

		private Material completeFacilityMat;

		private Material currentFacilityMat;

		private bool isChangedCompleteFacilityMat;

		private bool showBuildingFacility;

		private const string buildingFacilityMatPath = "Images/Fort/TW02_BLD_IMG_3x3";

		private const string completeFacilityMatPath = "Images/Fort/TW02_CMP_IMG_3x3";

		private Action<Facility> putButtonPressedCallback;

		private Action<Facility> levelUpButtonPressedCallback;

		private Action<Facility> facilityInformationButtonPressedCallback;

		private Action<Facility> storeButtonPressedCallback;

		private Action<Facility> finishBuildingButtonPressedCallback;

		private Action<Facility> centerButtonPressedCallback;

		private Action<Facility> leftButtonPressedCallback;

		private Action<Facility> rightButtonPressedCallback;

		public ManagedFacilityModel.ManagedFacility managedFacility
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

		public void AddPutButtonPressedCallback(Action<Facility> callback)
		{
		}

		public void AddLevelUpButtonPressedCallback(Action<Facility> callback)
		{
		}

		public void AddFacilityInformationButtonPressedCallback(Action<Facility> callback)
		{
		}

		public void AddStoreButtonPressedCallback(Action<Facility> callback)
		{
		}

		public void AddFinishBuildingButtonPressedCallback(Action<Facility> callback)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnCenterButtonPressed()
		{
		}

		public void OnLeftButtonPressed()
		{
		}

		public void OnRightButtonPressed()
		{
		}

		private void Update()
		{
		}

		public void SwitchCellStateForAnimation()
		{
		}

		public void SetContent(ManagedFacilityModel.ManagedFacility managedFacility)
		{
		}

		public override bool IsNew()
		{
			return default(bool);
		}

		public override List<Facility> GetNewFacilityList()
		{
			return null;
		}

		private void SetUpUI()
		{
		}

		private void SetCellStateStored()
		{
		}

		private void SetCellStateBuilding()
		{
		}

		private void SetCellStateMaxLevel()
		{
		}

		private void SetCellStateUpgradeable()
		{
		}

		private void SetCellStateUnFullfillUpgradeable(FortModel.BuildFacilityResult buildFacilityResult)
		{
		}
	}
}
