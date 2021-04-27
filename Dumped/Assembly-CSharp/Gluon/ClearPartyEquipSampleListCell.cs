/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ClearPartyEquipSampleListCell : TableViewCell<Gluon.ClearPartyEquipSampleListCellData>
	{
		// Fields
		public GameObject[] cellUIBaseObjs;
		public UnityEngine.UI.Text[] charaNameTexts;
		public CommonUnitIcon[] charaIcons;
		public CommonUnitIcon[] weaponIcons;
		public CommonUnitIcon[] dragonIcons;
		public ClearPartyEquipSampleListCellCrestIcons[] unitCrestIcons;
		public GameObject[] emptyDragonIconObjs;
		public Action<int> setButtonCallBack;
		private ClearPartyEquipSampleListCellData cellData;
		private GrowthManaCircleManaCircleData circleData;
	
		// Constructors
		public ClearPartyEquipSampleListCell();
	
		// Methods
		public override void UpdateContent(ClearPartyEquipSampleListCellData cellData);
		public void OnSetButtonPressed();
		public void OnCharaIconPressed(int index);
		public void OnWeaponIconPressed(int index);
		public void OnDragonIconPressed(int index);
		public void OnCrestIconPressed(int index);
	}
}
