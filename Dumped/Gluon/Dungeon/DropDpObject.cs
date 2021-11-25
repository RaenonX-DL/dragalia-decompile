using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DropDpObject : DropItemBox
	{
		private static readonly int brItemData;

		[Lock]
		public int itemData;

		public string effectName;

		public Vector3 effectOffset;

		private EffectObject effect;

		protected override void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent, bool hittedFirst)
		{
		}

		protected override List<EntityData> GetEntityData()
		{
			return null;
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
