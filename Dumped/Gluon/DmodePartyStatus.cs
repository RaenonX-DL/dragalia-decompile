using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodePartyStatus : MonoBehaviour
	{
		[SerializeField]
		private Text selectedCharaNameText;

		[SerializeField]
		private Graphic editSkill1Icon;

		[SerializeField]
		private Graphic editSkill2Icon;

		[SerializeField]
		private Text maxFloorText;

		[SerializeField]
		private DmodeServitorStatus servitorStatus;

		private Action<int> onEquipedEditSkillIconPressed;

		public DmodeServitorType GetSelectedServitorStatus()
		{
			return default(DmodeServitorType);
		}

		public void Initialize(int charaId, int selectedEditSkill1CharaId, int selectedEditSkill2CharaId)
		{
		}

		public void AddOnEquipedEditSkillIconPressedCallback(Action<int> callback)
		{
		}

		public void OnEquipedEditSkillIconPressed(int editSkillIndex)
		{
		}

		public void UpdateCharaInfo(int charaId)
		{
		}

		public void UpdateSelectedServitorType(int charaId)
		{
		}

		public void ReloadEditSkillIcon(bool isFirstEditSkill, int skillId, int skillLevel)
		{
		}
	}
}
