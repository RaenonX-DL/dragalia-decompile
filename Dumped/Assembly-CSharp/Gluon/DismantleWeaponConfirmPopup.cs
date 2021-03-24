/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DismantleWeaponConfirmPopup : CommonPopup
	{
		// Fields
		public CraftMaterialCell originCell;
		public UnityEngine.UI.Text totalCoin;
		public UnityEngine.UI.Text breforeCoin;
		public UnityEngine.UI.Text afterCoin;
		public UnityEngine.UI.Text messageText;
		public UnityEngine.UI.Text needCoinText;
		public UnityEngine.UI.Text coinErrorText;
		public UnityEngine.UI.Text weaponAlertText;
		public UnityEngine.UI.Text plusAlertText;
		public GameObject[] popSpeces;
		private int baseWeaponId;
	
		// Constructors
		public DismantleWeaponConfirmPopup();
	
		// Methods
		public static DismantleWeaponConfirmPopup Create(bool showBlackLayer = true);
		public void InitPop(WeaponCraftDataElement craftData, ulong keyId);
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
	}
}
