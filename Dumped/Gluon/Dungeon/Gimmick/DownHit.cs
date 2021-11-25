using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class DownHit : GimmickBase
	{
		private GimmickDownElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private Down downObj;

		private DownBody downBody;

		public void Initialize(GimmickDownElement elem, Down downObj, DownBody downBody)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
