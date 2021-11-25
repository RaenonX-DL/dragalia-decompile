using System.Collections;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DirectionalDropItemBox : DropItemBox
	{
		private MeshRenderer fixedRenderer;

		public string normalEffectName;

		public int normalEffectTrigger;

		public string rareEffectName;

		public int rareEffectTrigger;

		private EffectObject effectObject;

		protected override void Start()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		private IEnumerator Disppear()
		{
			return null;
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
