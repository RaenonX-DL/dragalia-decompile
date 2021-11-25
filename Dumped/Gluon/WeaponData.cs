using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class WeaponData
	{
		public AbilityDataElement[] abilityData;

		public WeaponBodyElement masterData
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

		public WeaponTypeElement typeData
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

		public int defense
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

		public WeaponData(int weaponId)
		{
		}

		public bool Setup(int weaponLv, ElementalType charaElement)
		{
			return default(bool);
		}

		public void SetAbility(int ability1Lv, int ability2Lv)
		{
		}
	}
}
