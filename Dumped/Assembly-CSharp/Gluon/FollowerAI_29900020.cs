/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_29900020 : FollowerAIBase
	{
		// Fields
		private readonly int skillTriggerMax;
		private int skillTrigger;
	
		// Constructors
		public FollowerAI_29900020();
	
		// Methods
		public override bool IsSkillAvailable(PlayerCharacter owner, int skillIndex);
		public override void OnSkillExit(PlayerCharacter owner, int skillIndex);
		public override void OnAttackExit(PlayerCharacter owner, int actionId);
		public override void OnTransformEnter(PlayerCharacter owner);
		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false);
		public override bool NeedsCheckPrioritizeBurstAttack();
	}
}
