using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetailSkillInfoCell : UnitDetailInfoBaseCell
	{
		public static bool startBatch;

		[SerializeField]
		[Header("WeaponElementalNotMatched")]
		public GameObject weaponElementalNotMatchedNode;

		private bool isWeaponSkillElementalNotMatched;

		[SerializeField]
		[Header("ShareSkill")]
		private Text shareCost;

		[SerializeField]
		private GameObject shareObj;

		[SerializeField]
		private GameObject shareSkillLock;

		[SerializeField]
		private GameObject shareSkillOpen;

		public override void IconPressed()
		{
		}

		public void SetSkillInfo(AbilityConst.UnitType giftType, int skillId, int skillLevel, int skillMaxLevel, bool isWeaponSkillElementalNotMatched = false)
		{
		}

		public void SetShareSkillInfo(int cost, bool canShareSkill)
		{
		}
	}
}
