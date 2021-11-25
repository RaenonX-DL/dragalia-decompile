using UnityEngine;

namespace Gluon.Dungeon
{
	public class CompositeReaction : Reaction
	{
		[SerializeField]
		protected Reaction child;

		protected override void Start()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}
	}
}
