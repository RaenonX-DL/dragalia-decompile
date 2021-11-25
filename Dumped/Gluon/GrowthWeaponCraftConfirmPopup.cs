using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponCraftConfirmPopup : CommonPopup, ICustomMessage
	{
		public Image weaponIcon;

		public Text weaponName;

		public Text releaseCount;

		public Text weaponHp;

		public Text weaponAtk;

		public Image[] slotIconsTypeA;

		public Image[] slotIconsTypeB;

		public Image[] slotIconsTypeC;

		public Text topMessage;

		public GameObject originCell;

		public Transform cellParentTransform;

		public Text needRupi;

		public Text beforeRupi;

		public Text afterRupi;

		public Text conditionText;

		public GameObject fortButtonObject;

		public GameObject craftButtonObject;

		public GameObject optionButtonBaseObject;

		public Action fortButtonCallBack;

		public Action<int> craftButtonCallBack;

		public GameObject needMaterialTextObject;

		private int weaponId;

		private List<CraftMaterialCell> materialCells;

		private bool isClearCondition;

		private bool isShortageRupi;

		private int conditionWeaponId;

		private bool isTutorialRequired;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static GrowthWeaponCraftConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(int weaponId)
		{
		}

		public void OnFortButtonPressed()
		{
		}

		public void OnCraftButtonPressed()
		{
		}

		private void UpdateMaterialCell()
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public void OnIconPressed()
		{
		}
	}
}
