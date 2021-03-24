/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftMaterialCell : MonoBehaviour
	{
		// Fields
		public Image materialIcon;
		public UnityEngine.UI.Text needCount;
		public UnityEngine.UI.Text nowCount;
		public UnityEngine.UI.Text haveText;
		public UnityEngine.UI.Text xText;
		public Image[] errorImage;
		public UnityAction<CraftMaterialCellData> materialPressedCallBack;
		public Transform plusTransform;
		public Badge alertBadgeIcon;
		public GameObject alertBadgeObj;
		public GameObject baseIconObj;
		private CraftMaterialCellData cellData;
		private int needCountBase;
		[SerializeField]
		private Image tradeImage;
		private bool isDismantleWeapon;
	
		// Properties
		public bool isMaterialSetupComplete { get; }
	
		// Constructors
		public CraftMaterialCell();
	
		// Methods
		private void Awake();
		public CraftMaterialCellData InitMaterialCell(GiftType type, int materialId, int needCnt, bool isDismantleWeapon = false);
		public CraftMaterialCellData InitWeaponMaterialCell(int weaponSetId, int needCnt);
		public void InitWeaponMaterialCell(CraftMaterialCellData cellData, int defaultNeedCount);
		private void SetError(bool isError);
		public void OnMaterialIconPressed();
		public void UpdateCell();
		private void UpdateTradeIcon(int nowCnt, int needCnt);
		public void UpDateNeedCount(int craftCount);
	}
}
