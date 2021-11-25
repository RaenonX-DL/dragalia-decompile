using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public abstract class GimmickBase : DungeonObjectStatus
	{
		private bool isProductionTimeFlag;

		protected bool isProductionTime => default(bool);

		protected bool OnCollided(Collider other, CollisionHitAttribute hitAttribute, float attack, int rateDamage)
		{
			return default(bool);
		}

		public static bool SetDamage(Collider other, CollisionHitAttribute hitAttribute, float attack, bool rateDamage)
		{
			return default(bool);
		}

		public static bool SetDamageFixedDamage(Collider other, CollisionHitAttribute hitAttribute, float attack)
		{
			return default(bool);
		}

		public float GetDeltaTime()
		{
			return default(float);
		}

		public static Transform FindNodePartialMatch(Transform current, string partialMatchName)
		{
			return null;
		}

		protected static void FindNodesPartialMatch(List<GameObject> list, Transform current, string partialMatchName)
		{
		}

		public GameObject GetGimmicksRootObject()
		{
			return null;
		}

		protected void EntryProductionTimeCallbackGimmick()
		{
		}

		public virtual void OnProductionTime()
		{
		}
	}
}
