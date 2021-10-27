/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_20050418 : FollowerAIBase
	{
		// Fields
		private int nextChargeLevel;
		private bool isEnteredChargeState;
	
		// Constructors
		public FollowerAI_20050418();
	
		// Methods
		public override void Update(PlayerCharacter owner);
		public override bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target);
		public override int GetChargeLevel(PlayerCharacter owner, CharacterBase target);
		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false);
		public override bool NeedsCheckPrioritizeBurstAttack();
	}
}
