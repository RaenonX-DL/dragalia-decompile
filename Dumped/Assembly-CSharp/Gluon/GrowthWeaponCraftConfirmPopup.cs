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
	public class GrowthWeaponCraftConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public Image weaponIcon;
		public UnityEngine.UI.Text weaponName;
		public UnityEngine.UI.Text releaseCount;
		public UnityEngine.UI.Text weaponHp;
		public UnityEngine.UI.Text weaponAtk;
		public Image[] slotIconsTypeA;
		public Image[] slotIconsTypeB;
		public Image[] slotIconsTypeC;
		public UnityEngine.UI.Text topMessage;
		public GameObject originCell;
		public Transform cellParentTransform;
		public UnityEngine.UI.Text needRupi;
		public UnityEngine.UI.Text beforeRupi;
		public UnityEngine.UI.Text afterRupi;
		public UnityEngine.UI.Text conditionText;
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
	
		// Constructors
		public GrowthWeaponCraftConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthWeaponCraftConfirmPopup Create();
		public void InitPopup(int weaponId);
		public void OnFortButtonPressed();
		public void OnCraftButtonPressed();
		private void UpdateMaterialCell();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public void OnIconPressed();
	}
}
