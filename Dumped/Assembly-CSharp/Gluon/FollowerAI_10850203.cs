/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10850203 : FollowerAIBase
	{
		// Fields
		private static readonly int modeBBuffId;
	
		// Constructors
		public FollowerAI_10850203();
		static FollowerAI_10850203();
	
		// Methods
		public override bool CheckDragonSkillForAuto();
		public override bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target);
		public override bool IsEnableSkill2(PlayerCharacter owner, CharacterBase target);
		public bool HasAbnormalStatusChara(PlayerCharacter owner);
		public bool HasLowHpChara(PlayerCharacter owner);
	}
}
