using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class DownBody : DungeonObjectBase
	{
		private Down downObj;

		private bool hitted;

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

		public void SetHitted(bool disableBodyCollision)
		{
		}

		public bool IsHitted()
		{
			return default(bool);
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
