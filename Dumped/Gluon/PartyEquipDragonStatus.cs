using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipDragonStatus : MonoBehaviour
	{
		[SerializeField]
		private GameObject emptyObject;

		[SerializeField]
		private GameObject rootObject;

		[SerializeField]
		private Image dragonIcon;

		[SerializeField]
		private Text dragonName;

		[SerializeField]
		private Text hp;

		[SerializeField]
		private Text attack;

		[SerializeField]
		private PartyEquipStatusIconBar skillIconBar;

		[SerializeField]
		private PartyEquipStatusIconBar[] abilityIconBars;

		private int skillId;

		private int skillLevel;

		private List<int> abilityIds;

		private ElementalType dragonElementalType;

		private ulong dragonKeyId;

		public UnityAction unitLockCallback;

		public void Setup(ulong dragonKeyId)
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
