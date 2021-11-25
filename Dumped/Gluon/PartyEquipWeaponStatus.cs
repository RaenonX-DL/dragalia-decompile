using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipWeaponStatus : MonoBehaviour
	{
		[SerializeField]
		private Image weaponIcon;

		[SerializeField]
		private Image skinIcon;

		[SerializeField]
		private Text weaponName;

		[SerializeField]
		private Text hp;

		[SerializeField]
		private Text attack;

		[SerializeField]
		private PartyEquipStatusIconBar skillIconBar;

		[SerializeField]
		private PartyEquipStatusIconBar[] abilityIconBars;

		private ElementalType weaponElementalType;

		private int skillId;

		private int skillLevel;

		private int skillMaxLevel;

		private bool isNotMatchElement;

		private List<int> abilityIds;

		private int weaponBodyId;

		private int charaId;

		public void Setup(int charaId, int weaponBodyId, int weaponSkinId)
		{
		}

		public void OnSkillIconPressed()
		{
		}

		public void OnAbilityIconPressed(int index)
		{
		}

		public void OpenDetailScene()
		{
		}
	}
}
