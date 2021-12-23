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

		public CommonUnitIcon[] talismanIcons;

		public GameObject[] emptyTalismanIconObjs;

		public Image[] editSkill1Icons;

		public Image[] editSkill2Icons;

		public Action<int, int> setButtonCallBack;

		private ClearPartyEquipSampleListCellData cellData;

		private GrowthManaCircleManaCircleData circleData;

		private int[] editSkill1Id;

		private int[] editSkill1Level;

		private int[] editSkill1MaxLevel;

		private int[] editSkill2Id;

		private int[] editSkill2Level;

		private int[] editSkill2MaxLevel;

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

		public void OnTalismanIconPressed(int index)
		{
		}

		public void OnEditSkill1Pressed(int index)
		{
		}

		public void OnEditSkill2Pressed(int index)
		{
		}

		public void OnExAbilityButtonPressed(int index)
		{
		}
	}
}
