/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CharacterBuffSubstitude
	{
		// Fields
		public static readonly float SubstitudeReduceDamageRate;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public CharacterBase owner;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal bool _BuildSubstitudeInfos_b__0(CharacterSelector s);
		}
	
		// Constructors
		static CharacterBuffSubstitude();
	
		// Methods
		public static bool IsSubstitudableDamage(int damage, DamageCalculation.DamageStatus status, CollisionHitAttribute hitAttr);
		public static bool IsSubstitudableDamageCharacter(CharacterBase owner);
		public static bool BuildSubstitudeInfos(CharacterBase owner, int originalDamage, out int outReducedDamage, ref List<DamageCalculation.DamageStatus.SubstitudeInfo> outResult);
		public static bool IsSubstitudeTarget(CharacterBase owner, CharacterSelector target);
		public static void ConsumeSubstitudeBuff(CharacterBase owner);
	}
}
