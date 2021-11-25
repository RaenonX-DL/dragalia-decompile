using Gluon.Event;

namespace Gluon
{
	public class BRItemSkill : BRItemBase
	{
		public static readonly BattleRoyalDungeonItem[] skillItemIds;

		private int skillId;

		public static int GetSkillIndexByActionId(int actionId)
		{
			return default(int);
		}

		public static int GetSkillIndexBySkillId(int skillId)
		{
			return default(int);
		}

		protected override void OnEnable()
		{
		}

		public override void SetItemParam(BRItemParam param)
		{
		}

		protected override void Update()
		{
		}

		protected override void Apply(CharacterBase chara)
		{
		}

		public override bool IsEffectiveFor(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
