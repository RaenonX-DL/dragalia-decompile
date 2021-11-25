using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class AmuletData
	{
		public AbilityDataElement[] abilityData;

		public int[] abilityLv;

		public AbilityCrestElement masterData
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
			private set
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
			private set
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
			private set
			{
			}
		}

		public AmuletData(int amuletId)
		{
		}

		public bool Setup(int amuletLv, int plusHp, int plusAttack)
		{
			return default(bool);
		}

		public void SetupAbility(int ability1Lv, int ability2Lv)
		{
		}
	}
}
