/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10850402 : FollowerAIBase
	{
		// Fields
		private RandomBAState randomBAState;
	
		// Nested types
		private enum RandomBAState
		{
			None = 0,
			Reserved = 1,
			Entered = 2,
			Expelled = 3
		}
	
		// Constructors
		public FollowerAI_10850402();
	
		// Methods
		public override void Update(PlayerCharacter owner);
		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false);
		public override bool NeedsCheckPrioritizeBurstAttack();
		public override bool IsEnableSkill(PlayerCharacter owner, CharacterBase target, int index);
	}
}
