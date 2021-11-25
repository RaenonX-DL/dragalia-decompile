using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class DragonData
	{
		public const int skillNum = 2;

		public AbilityDataElement ability1Data;

		public AbilityDataElement ability2Data;

		public CharacterSkillData[] skillData;

		public CharacterSkillData skillFAData;

		public int ability1Lv;

		public int ability2Lv;

		public DragonDataElement masterData
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

		public DragonDataElement equipData
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

		public int level
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int hp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int attack
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int defense
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DragonData(int dragonId, int uniqueDragonId)
		{
		}

		public bool Setup(int dragonLv, int plusHp, int plusAttack, ElementalType charaElement)
		{
			return default(bool);
		}

		public void SetupSkill(int skill1Lv, int skill2Lv)
		{
		}

		public void SetupAbility(int ability1Lv, int ability2Lv)
		{
		}

		public void OnReceiveTransSkill(CharacterBase owner, TransSkill recvEvent)
		{
		}

		private void AddSkillAction(CharacterSkillData data)
		{
		}

		private void AddSkillAction(CharacterSkillData data, int actionId)
		{
		}

		public bool CheckTransSkill(CharacterBase owner, CollisionHitAttribute attr, int idx)
		{
			return default(bool);
		}

		public void TransformOverChargeSkill(int idx, int phase)
		{
		}

		public void TransformSkill(int idx)
		{
		}

		public void ReleaseTransSkill(CharacterBase owner, int idx)
		{
		}

		public void DisableTrans(int idx)
		{
		}

		public bool IsPauseTransBuff(int idx)
		{
			return default(bool);
		}

		public void PauseTransBuff(int idx, bool pause)
		{
		}
	}
}
