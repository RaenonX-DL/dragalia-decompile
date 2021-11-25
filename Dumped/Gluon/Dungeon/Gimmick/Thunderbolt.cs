using System.Collections;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class Thunderbolt : GimmickBase
	{
		private GimmickThunderboltElement variation;

		private CollisionHitAttribute hitAttribute;

		private SphereCollider hitCollider;

		private bool isRange;

		private bool eventReceived;

		private float delay;

		private int randomSeed;

		private ThunderboltHit[] thunderHit;

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

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
