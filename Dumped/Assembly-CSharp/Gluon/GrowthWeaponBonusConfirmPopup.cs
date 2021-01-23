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
	public class GrowthWeaponBonusConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public Image weaponTypeIcon;
		public UnityEngine.UI.Text hpParamText;
		public UnityEngine.UI.Text atkParamText;
		public GameObject originCell;
		public Transform cellParentTransform;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public GameObject needMaterialTextObject;
		public Action reloadCanvasUICallBack;
		private GrowthUnitEnhanceModel model;
		private List<CraftMaterialCell> materialCells;
		private bool isDesabledReleaseButton;
		private bool isShortageRupi;
	
		// Constructors
		public GrowthWeaponBonusConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthWeaponBonusConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		private void SetupWeaponTypeParam();
		private void SetupRupi();
		private void SetupMaterialCell();
		private void UpdateMaterialCell();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
