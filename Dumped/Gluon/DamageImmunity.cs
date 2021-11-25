using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gluon
{
	public class DamageImmunity
	{
		public enum Type
		{
			Normal,
			ExceptDragon,
			Boundary,
			IronWall,
			ExceptCombo
		}

		public enum DamageType
		{
			Hit,
			Slip,
			BuffRelease,
			DrainDamage,
			DrainLife,
			Additional,
			ApplyShield
		}

		private BitArray flags;

		public CharacterBase owner
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

		public DamageImmunity(CharacterBase chara)
		{
		}

		public void Clear()
		{
		}

		public void Set(bool flag, Type type = Type.Normal)
		{
		}

		public bool Get(Type type = Type.Normal)
		{
			return default(bool);
		}

		public bool Any()
		{
			return default(bool);
		}

		public bool Is(Type type)
		{
			return default(bool);
		}

		public bool IsDamageImmunity(DamageType dmgtype = DamageType.Hit, [Optional] CollisionHitAttribute hitAttr, [Optional] CharacterBase attacker, bool isDragonHit = false)
		{
			return default(bool);
		}

		public bool CanTargetFromPlayerAI(PlayerCharacter chara)
		{
			return default(bool);
		}

		private bool IsDamageImmunityExceptDragon(DamageType dmgtype, CollisionHitAttribute hitAttr, CharacterBase attacker, bool isDragonHit)
		{
			return default(bool);
		}

		private bool IsDamageImmunityExceptCombo(DamageType dmgtype, CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		private bool IsDamageImmunityDragonForExceptCombo(CharacterBase attacker)
		{
			return default(bool);
		}
	}
}
