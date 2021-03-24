/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10150502 : FollowerAIBase
	{
		// Constructors
		public FollowerAI_10150502();
	
		// Methods
		public override bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target);
		public override bool IsEnableSkill2(PlayerCharacter owner, CharacterBase target);
		private int GetNextChainSkillIndex(PlayerCharacter owner, EnemyCharacter enemy);
		public override bool IsBarrierEnemy(PlayerCharacter owner, EnemyCharacter enemy);
	}
}
