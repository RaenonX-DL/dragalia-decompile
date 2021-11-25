using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthReleaseWeaponAbilityConfirmPopup : CommonPopup, ICustomMessage
	{
		public Image[] abilityIcons;

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

		private int[] selectIds;

		private int totalNeedRupi;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static GrowthReleaseWeaponAbilityConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, int[] selectIds)
		{
		}

		public void OnAbilityIconPressed(int index)
		{
		}

		private void SetupAbilityIcons()
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
