using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitLimitOverConfirmPopup : CommonPopup, ICustomMessage
	{
		public GameObject originCell;

		public Transform cellParentTransform;

		public Image skillIcon;

		public Image abilityIcon1;

		public Image abilityIcon2;

		public GameObject[] skillUIObjects;

		public GameObject[] abilityUIObjects;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public GameObject needMaterialTextObject;

		public Action reloadCanvasUICallBack;

		[SerializeField]
		private Transform iconDecoNode;

		[SerializeField]
		private Text iconDecoLevelText;

		private GrowthUnitEnhanceModel model;

		private List<CraftMaterialCell> materialCells;

		private bool isDesabledReleaseButton;

		private bool isShortageRupi;

		private int skillId;

		private int skillLevel;

		private int ability1Id;

		private int ability2Id;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static GrowthUnitLimitOverConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		public void OnSkillIconPressed()
		{
		}

		public void OnAbilityIconPressed(int index)
		{
		}

		private void SetupSkill()
		{
		}

		private void SetupAbility()
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
