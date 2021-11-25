using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class DropBomb : GimmickBase
	{
		public int type;

		protected EffectObject effect;

		private DungeonItemDataElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private SphereCollider hitCollider;

		private float hitStartTime;

		private const float hitTime = 0.2f;

		protected override void Awake()
		{
		}

		private IEnumerator StartAction()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
