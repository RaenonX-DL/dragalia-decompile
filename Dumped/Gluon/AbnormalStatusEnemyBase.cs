using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class AbnormalStatusEnemyBase : AbnormalStatusBase
	{
		public struct SlipData
		{
			public ActionConditionElement data;

			public float duration;

			public float life;

			public float damage;

			public CharacterBase attacker;
		}

		private List<SlipData> _slipList;

		private Dictionary<CharacterBase, int> slipDamageOwnerDict;

		public override float durationTime => default(float);

		public List<SlipData> OverlapList => null;

		public void RemoveOverlapList(int count)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		protected override void OnEventInterval()
		{
		}

		public Dictionary<CharacterBase, int> CalcContribution(int damage)
		{
			return null;
		}

		public override void Setup(CharacterBase chara, CollisionHitAttribute attr, ActionConditionElement elem, bool overrideEffect)
		{
		}

		public override int GetOverlapNum()
		{
			return default(int);
		}

		public override void Addition(CollisionHitAttribute attr, ActionConditionElement elem)
		{
		}

		public override void Exit()
		{
		}

		public override int BuildSlipDamage()
		{
			return default(int);
		}

		public override void GetShortestDurationTime(out float duration, out float life)
		{
		}

		public override void PlayEffect([Optional] GameObject node)
		{
		}
	}
}
