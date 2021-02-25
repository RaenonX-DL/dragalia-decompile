/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthUnitLimitOverConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public GameObject originCell;
		public Transform cellParentTransform;
		public Image skillIcon;
		public Image abilityIcon1;
		public Image abilityIcon2;
		public GameObject[] skillUIObjects;
		public GameObject[] abilityUIObjects;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public GameObject needMaterialTextObject;
		public Action reloadCanvasUICallBack;
		[SerializeField]
		private Transform iconDecoNode;
		[SerializeField]
		private UnityEngine.UI.Text iconDecoLevelText;
		private GrowthUnitEnhanceModel model;
		private List<CraftMaterialCell> materialCells;
		private bool isDesabledReleaseButton;
		private bool isShortageRupi;
		private int skillId;
		private int skillLevel;
		private int ability1Id;
		private int ability2Id;
	
		// Constructors
		public GrowthUnitLimitOverConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthUnitLimitOverConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		public void OnSkillIconPressed();
		public void OnAbilityIconPressed(int index);
		private void SetupSkill();
		private void SetupAbility();
		private void SetupRupi();
		private void SetupMaterialCell();
		private void UpdateMaterialCell();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
