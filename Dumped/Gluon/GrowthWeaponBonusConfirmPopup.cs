using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponBonusConfirmPopup : CommonPopup, ICustomMessage
	{
		public Image weaponTypeIcon;

		public Text hpParamText;

		public Text atkParamText;

		public GameObject originCell;

		public Transform cellParentTransform;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public GameObject needMaterialTextObject;

		public Action reloadCanvasUICallBack;

		private GrowthUnitEnhanceModel model;

		private List<CraftMaterialCell> materialCells;

		private bool isDesabledReleaseButton;

		private bool isShortageRupi;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static GrowthWeaponBonusConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		private void SetupWeaponTypeParam()
		{
		}

		private void SetupRupi()
		{
		}

		private void SetupMaterialCell()
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
	}
}
