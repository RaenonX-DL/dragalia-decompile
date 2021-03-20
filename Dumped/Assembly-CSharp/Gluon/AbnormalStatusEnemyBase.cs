/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbnormalStatusEnemyBase : AbnormalStatusBase
	{
		// Fields
		private List<SlipData> _slipList;
		private Dictionary<CharacterBase, int> slipDamageOwnerDict;
	
		// Properties
		public override float durationTime { get; }
		public List<SlipData> OverlapList { get; }
	
		// Nested types
		public struct SlipData
		{
			// Fields
			public ActionConditionElement data;
			public float duration;
			public float life;
			public float damage;
			public CharacterBase attacker;
		}
	
		// Constructors
		public AbnormalStatusEnemyBase();
	
		// Methods
		public void RemoveOverlapList(int count);
		public override bool Update();
		protected override void OnEventInterval();
		public Dictionary<CharacterBase, int> CalcContribution(int damage);
		public override void Setup(CharacterBase chara, CollisionHitAttribute attr, ActionConditionElement elem, bool overrideEffect);
		public override int GetOverlapNum();
		public override void Addition(CollisionHitAttribute attr, ActionConditionElement elem);
		public override void Exit();
		public override int BuildSlipDamage();
		public override void GetShortestDurationTime(out float duration, out float life);
	}
}
