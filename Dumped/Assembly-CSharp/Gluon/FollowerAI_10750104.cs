/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10750104 : FollowerAIBase
	{
		// Constructors
		public FollowerAI_10750104();
	
		// Methods
		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, float probabilityCoef = 1f, bool force = false);
		public override bool NeedsCheckPrioritizeBurstAttack();
		public override bool IsIgnoreCommonConditionForBurstAttack(PlayerCharacter owner);
		public override void Update(PlayerCharacter owner);
		public override bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target);
		public override bool IsEnableSkill2(PlayerCharacter owner, CharacterBase target);
	}
}
