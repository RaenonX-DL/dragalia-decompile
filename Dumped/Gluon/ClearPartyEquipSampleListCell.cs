using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ClearPartyEquipSampleListCell : TableViewCell<ClearPartyEquipSampleListCellData>
	{
		public GameObject[] cellUIBaseObjs;

		public Text[] charaNameTexts;

		public CommonUnitIcon[] charaIcons;

		public CommonUnitIcon[] weaponIcons;

		public CommonUnitIcon[] dragonIcons;

		public ClearPartyEquipSampleListCellCrestIcons[] unitCrestIcons;

		public GameObject[] emptyDragonIconObjs;

		public Action<int, int> setButtonCallBack;

		private ClearPartyEquipSampleListCellData cellData;

		private GrowthManaCircleManaCircleData circleData;

		public override void UpdateContent(ClearPartyEquipSampleListCellData cellData)
		{
		}

		public void OnSetButtonPressed()
		{
		}

		public void OnSingleSetButtonPressed(int indexInParty)
		{
		}

		public void OnCharaIconPressed(int index)
		{
		}

		public void OnWeaponIconPressed(int index)
		{
		}

		public void OnDragonIconPressed(int index)
		{
		}

		public void OnCrestIconPressed(int index)
		{
		}

		public void OnExAbilityButtonPressed(int index)
		{
		}
	}
}
