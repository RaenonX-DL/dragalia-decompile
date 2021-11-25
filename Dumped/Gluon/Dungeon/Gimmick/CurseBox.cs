using System.Collections;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class CurseBox : DungeonObjectBase
	{
		public float dropTime;

		private GimmickCurseboxElement variation;

		private CurseBoxHit curseBoxHit;

		protected bool hitted;

		protected override void Awake()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		protected IEnumerator DropCurse(Vector3 pos)
		{
			return null;
		}

		private IEnumerator Disppear()
		{
			return null;
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
