using UnityEngine;

namespace Gluon
{
	public class DmodeSkillAbilityDetailPopup : SkillAbilityDetailPopup
	{
		private static readonly string prefabPath;

		[SerializeField]
		[Header("Control")]
		private GameObject sellGO;

		[SerializeField]
		[Header("Info")]
		private GameObject activatorPanel;

		[SerializeField]
		private DmodeCommonInGameIcon activatorTemplate;

		private DmodeDungeonItemManager.ContainerType containerType;

		private int sellId;

		private DmodePopupUtil.DmodeUnifiedActiveAbilityInfo info;

		public static DmodeSkillAbilityDetailPopup CreateDmodeSkillDetailPopup(int skillId, DmodeDungeonItemManager.ContainerType containerType = DmodeDungeonItemManager.ContainerType.None, int sellId = 0)
		{
			return null;
		}

		public static DmodeSkillAbilityDetailPopup CreateDmodeAbilityDetailPopup(int abilityId, ElementalType elementalType)
		{
			return null;
		}

		public static DmodeSkillAbilityDetailPopup CreateDmodeExAbilityDetailPopup(int exAbilityId, ElementalType elementalType)
		{
			return null;
		}

		public static DmodeSkillAbilityDetailPopup CreateDmodeAbilityDetailPopup(DmodePopupUtil.DmodeUnifiedActiveAbilityInfo info)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnSellButtonPressed()
		{
		}
	}
}
