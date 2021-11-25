using UnityEngine;

namespace Gluon.Dungeon
{
	public class BreakableReaction : Reaction
	{
		protected bool hitted;

		protected override void Start()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}
	}
}
