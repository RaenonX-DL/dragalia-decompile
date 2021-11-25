using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftStepupConfirmPopup : CommonPopup, ICustomMessage
	{
		public Text message;

		public CraftMaterialCell originCell;

		public Text totalExp;

		public Text totalCoin;

		public Text breforeCoin;

		public Text afterCoin;

		public Text craftCount;

		public Text craftMaxCount;

		public Slider craftSlider;

		public Text selectWeaponMessage;

		[HideInInspector]
		public int totalCraftCount;

		[HideInInspector]
		public int targetId;

		[HideInInspector]
		public Dictionary<int, int> allMaterialDict;

		public GameObject sliberBase;

		public Text errorMessage;

		public List<CraftMaterialCell> materialCellList;

		public List<CraftMaterialCell> materialWeaponCellList;

		public GameObject autoLimitBreakBase;

		public GameObject autoLimitBreakSpace;

		public Toggle autoLimitBreakToggle;

		public Transform cellParent;

		public Button plusButton;

		public Button minusButton;

		public Action materialReloadCallBack;

		public Action<CraftStepupConfirmPopupBackupData> createMaterialWeaponCallBack;

		private PointerEventHandler plusButtonEventHandler;

		private PointerEventHandler minusButtonEventHandler;

		private Coroutine countCoroutine;

		private int assembleCoin;

		[HideInInspector]
		private CaftNeedMaterialData needMaterialData;

		private bool isMuteSliderSe;

		private Dictionary<int, CraftMaterialCellData> craftMaterialWeaponCellDatas;

		private bool isEnableCraft;

		private int defaultCraftCount;

		private int showMaterialWeaponPopupSetId;

		private ulong[] materialWeaponPopupSelectKeyIds;

		private bool isFirstStepCraft;

		public bool isItemUpdate
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static CraftStepupConfirmPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void InitPop(int weaponId, [Optional] CraftStepupConfirmPopupBackupData backupData)
		{
		}

		private void UpdatePopup()
		{
		}

		private IEnumerator SliderSeActiveDelay()
		{
			return null;
		}

		private void UpdateMaterialInfo()
		{
		}

		public void SliderValueChanged()
		{
		}

		public void OnValueChangeButtonPressed(int value)
		{
		}

		public void OnValueChangeButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isPlus)
		{
			return null;
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		private void DeleteLockedWeaponKeyId(ref ulong[] materialKeys)
		{
		}

		private void UpdateCraftButton()
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		public override void OnCancelButtonPressed()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public CraftStepupSendData GetSendData()
		{
			return null;
		}

		public ulong[] GetUseMaterialWeaponKeyIds()
		{
			return null;
		}

		public static void ShowNoDismantlePopup(Action popupCallBack)
		{
		}
	}
}
