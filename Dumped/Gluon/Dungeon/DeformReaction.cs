using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DeformReaction : Reaction
	{
		private int open2;

		[SerializeField]
		[Lock]
		private string DeformEffect;

		private HashSet<int> triggerHistory;

		protected override void Start()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
