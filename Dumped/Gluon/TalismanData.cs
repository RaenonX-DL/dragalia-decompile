using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class TalismanData
	{
		public AbilityDataElement[] abilityData;

		public TalismanDataElement masterData
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

		public TalismanData(int talismanId, int[] abilityIds)
		{
		}

		public bool Setup(int plusHp, int plusAttack)
		{
			return default(bool);
		}
	}
}
