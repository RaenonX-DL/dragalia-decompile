using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class CurseBoxHit : GimmickBase
	{
		public GimmickCurseboxElement variation;

		public CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private SphereCollider hitCollider;

		private void Start()
		{
		}

		public void StartAction(Vector3 pos)
		{
		}

		private IEnumerator Action(Vector3 pos)
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
