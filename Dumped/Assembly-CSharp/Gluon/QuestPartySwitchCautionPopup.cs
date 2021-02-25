/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPartySwitchCautionPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/QuestCommon/QuestPartySwitchCautionPopup";
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
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
		private string[] limitedElementalTypeCharacterTextList;
		private string[] limitedElementalTypeDragonTextList;
		[CompilerGenerated]
		private QuestPartySwitchModel _partySwitchModel_k__BackingField;
	
		// Properties
		public QuestPartySwitchModel partySwitchModel { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public QuestPartySwitchCautionPopup();
	
		// Methods
		public static QuestPartySwitchCautionPopup Create([IsReadOnly] in QuestPartySwitchModel partySwitchModel);
		private void Initialize();
		private void SetLimitedElementalCaution();
		private void SetLimitedElementalIconAndText(GameObject cautionObject, bool shouldShow, ElementalType limitedElementalType, GiftType type);
		private void MakeLayoutIconInText(GameObject cautionObject);
		private void SetUnFulfilledCharacter([IsReadOnly] in List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledCharaDataList);
		private void SetUnFulfilledWeapon([IsReadOnly] in List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledWeaponDataList);
		private void SetUnFulfilledDragon([IsReadOnly] in List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledDragonDataList);
		private void SetUnFulfilledAbilityCrest([IsReadOnly] in List<QuestPartySwitchModel.UnFulfilledUnitData> unFulfilledAbilityCrestDataList);
		public void OnCloseButtonPressed();
	}
}
