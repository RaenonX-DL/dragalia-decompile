using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestPartySwitchCautionPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/QuestCommon/QuestPartySwitchCautionPopup";

		[SerializeField]
		[Header("UI")]
		private GameObject fullMemberCautionTextPanel;

		[SerializeField]
		private GameObject charaListParent;

		[SerializeField]
		private GameObject weaponListParent;

		[SerializeField]
		private GameObject dragonListParent;

		[SerializeField]
		private GameObject abilityCrestListParent;

		[SerializeField]
		private GameObject originalIconObject;

		[SerializeField]
		[Header("Limited Elemental")]
		private GameObject party1Title;

		[SerializeField]
		private GameObject party1CharacterCaution;

		[SerializeField]
		private GameObject party1DragonCaution;

		[SerializeField]
		private GameObject party2Title;

		[SerializeField]
		private GameObject party2CharacterCaution;

		[SerializeField]
		private GameObject party2DragonCaution;

		[SerializeField]
		private LocalizeTextLayoutPadding limitedElementalQuestCautionPadding;

		[SerializeField]
		private Text limitedQuestForCalcText;

		private string[] limitedElementalTypeCharacterTextList;

		private string[] limitedElementalTypeDragonTextList;

		public QuestPartySwitchModel partySwitchModel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static QuestPartySwitchCautionPopup Create([In] ref QuestPartySwitchModel partySwitchModel)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void SetLimitedElementalCaution()
		{
		}

		private void SetLimitedElementalIconAndText(GameObject cautionObject, bool shouldShow, ElementalType limitedElementalType, GiftType type)
		{
		}

		private void MakeLayoutIconInText(GameObject cautionObject)
		{
		}

		private void SetUnFulfilledCharacter([In] ref List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledCharaDataList)
		{
		}

		private void SetUnFulfilledWeapon([In] ref List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledWeaponDataList)
		{
		}

		private void SetUnFulfilledDragon([In] ref List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledDragonDataList)
		{
		}

		private void SetUnFulfilledAbilityCrest([In] ref List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledAbilityCrestDataList)
		{
		}

		private void SetUnFulfilledTalisman([In] ref List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledDataList)
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
