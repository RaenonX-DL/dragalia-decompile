using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class Bomb : GimmickBase
	{
		public GimmickBombObj type;

		public int effectTrigger;

		protected Animator anim;

		protected EffectObject effect;

		private GimmickBombObjElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private SphereCollider hitCollider;

		private bool isRange;

		private bool hit;

		private const float hitStartTime = 5f / 6f;

		private const float hitTime = 0.2f;

		protected override void Awake()
		{
		}

		private IEnumerator StartAction()
		{
			return null;
		}

		protected void OnActionEnd()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
