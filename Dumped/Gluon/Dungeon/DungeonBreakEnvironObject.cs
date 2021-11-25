using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBreakEnvironObject : DungeonObjectBase
	{
		private bool hitted;

		private Collider coll;

		public string effectName;

		public int effectTrigger;

		public string seCueName;

		private GameObject attacker;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
