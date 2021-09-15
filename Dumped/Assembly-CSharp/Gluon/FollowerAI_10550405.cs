/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10550405 : FollowerAIBase
	{
		// Constructors
		public FollowerAI_10550405();
	
		// Methods
		public override bool NeedsCheckPrioritizeBurstAttack();
		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false);
		public override bool IsEnableAdditionalInputCount(PlayerCharacter owner, int counter = 0);
		public override bool BurstAttackIsAttack();
	}
}
