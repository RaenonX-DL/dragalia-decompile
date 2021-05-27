/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManagedFacilityCell : FacilityCellBase
	{
		// Fields
		[CompilerGenerated]
		private ManagedFacilityModel.ManagedFacility _managedFacility_k__BackingField;
		private static readonly int GRID_UNIT_SIZE;
		[SerializeField]
		private Image iconImage;
		[SerializeField]
		private Image gridImage;
		[SerializeField]
		private UnityEngine.UI.Text nameLabel;
		[SerializeField]
		private UnityEngine.UI.Text levelLabel;
		[Header]
		[SerializeField]
		private Button centerButton;
		[SerializeField]
		private Button leftButton;
		[SerializeField]
		private Button rightButton;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text centerButtonText;
		[SerializeField]
		private UnityEngine.UI.Text leftButtonText;
		[SerializeField]
		private UnityEngine.UI.Text rightButtonText;
		[SerializeField]
		private UnityEngine.UI.Text buildingRemainText;
		[Header]
		[SerializeField]
		private Sprite buttonGreenBg;
		[SerializeField]
		private Sprite buttonWhiteBg;
		[SerializeField]
		private GameObject upgradeableText;
		[Header]
		[SerializeField]
		private GameObject disablePanel;
		[SerializeField]
		private UnityEngine.UI.Text disableText;
		[SerializeField]
		private GameObject storedCountObject;
		[SerializeField]
		private UnityEngine.UI.Text storedCount;
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
	
		// Properties
		public ManagedFacilityModel.ManagedFacility managedFacility { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ManagedFacilityCell();
		static ManagedFacilityCell();
	
		// Methods
		public void AddPutButtonPressedCallback(Action<Facility> callback);
		public void AddLevelUpButtonPressedCallback(Action<Facility> callback);
		public void AddFacilityInformationButtonPressedCallback(Action<Facility> callback);
		public void AddStoreButtonPressedCallback(Action<Facility> callback);
		public void AddFinishBuildingButtonPressedCallback(Action<Facility> callback);
		private void Awake();
		private void OnDestroy();
		public void OnCenterButtonPressed();
		public void OnLeftButtonPressed();
		public void OnRightButtonPressed();
		private void Update();
		public void SwitchCellStateForAnimation();
		public void SetContent(ManagedFacilityModel.ManagedFacility managedFacility);
		public override bool IsNew();
		public override List<Facility> GetNewFacilityList();
		private void SetUpUI();
		private void SetCellStateStored();
		private void SetCellStateBuilding();
		private void SetCellStateMaxLevel();
		private void SetCellStateUpgradeable();
		private void SetCellStateUnFullfillUpgradeable(FortModel.BuildFacilityResult buildFacilityResult);
	}
}
