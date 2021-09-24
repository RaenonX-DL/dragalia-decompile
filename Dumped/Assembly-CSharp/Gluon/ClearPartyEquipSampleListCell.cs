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
		public Action<int, int> setButtonCallBack;
		private ClearPartyEquipSampleListCellData cellData;
		private GrowthManaCircleManaCircleData circleData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		// Constructors
		public ClearPartyEquipSampleListCell();
	
		// Methods
		public override void UpdateContent(ClearPartyEquipSampleListCellData cellData);
		public void OnSetButtonPressed();
		public void OnSingleSetButtonPressed(int indexInParty);
		public void OnCharaIconPressed(int index);
		public void OnWeaponIconPressed(int index);
		public void OnDragonIconPressed(int index);
		public void OnCrestIconPressed(int index);
		public void OnExAbilityButtonPressed(int index);
	}
}
