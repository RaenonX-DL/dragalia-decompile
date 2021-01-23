/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRItemSkill : BRItemBase
	{
		// Fields
		public static readonly BattleRoyalDungeonItem[] skillItemIds;
		private int skillId;
	
		// Constructors
		public BRItemSkill();
		static BRItemSkill();
	
		// Methods
		public static int GetSkillIndexByActionId(int actionId);
		public static int GetSkillIndexBySkillId(int skillId);
		protected override void OnEnable();
		public override void SetItemParam(BRItemParam param);
		protected override void Update();
		protected override void Apply(CharacterBase chara);
		public override bool IsEffectiveFor(CharacterBase chara);
	}
}
