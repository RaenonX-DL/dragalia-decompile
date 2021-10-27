/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DamageImmunity
	{
		// Fields
		private BitArray flags;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
	
		// Properties
		public CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum Type
		{
			Normal = 0,
			ExceptDragon = 1,
			Boundary = 2,
			IronWall = 3,
			ExceptCombo = 4
		}
	
		public enum DamageType
		{
			Hit = 0,
			Slip = 1,
			BuffRelease = 2,
			DrainDamage = 3,
			DrainLife = 4,
			Additional = 5,
			ApplyShield = 6
		}
	
		// Constructors
		public DamageImmunity(CharacterBase chara);
	
		// Methods
		public void Clear();
		public void Set(bool flag, Type type = Type.Normal);
		public bool Get(Type type = Type.Normal);
		public bool Any();
		public bool Is(Type type);
		public bool IsDamageImmunity(DamageType dmgtype = DamageType.Hit, CollisionHitAttribute hitAttr = null, CharacterBase attacker = null, bool isDragonHit = false);
		public bool CanTargetFromPlayerAI(PlayerCharacter chara);
		private bool IsDamageImmunityExceptDragon(DamageType dmgtype, CollisionHitAttribute hitAttr, CharacterBase attacker, bool isDragonHit);
		private bool IsDamageImmunityExceptCombo(DamageType dmgtype, CollisionHitAttribute hitAttr);
		private bool IsDamageImmunityDragonForExceptCombo(CharacterBase attacker);
	}
}
