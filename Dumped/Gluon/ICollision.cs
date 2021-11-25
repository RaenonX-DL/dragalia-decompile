using UnityEngine;

namespace Gluon
{
	public interface ICollision
	{
		void OnCollided(GameObject target, CollisionHitAttribute data);
	}
}
