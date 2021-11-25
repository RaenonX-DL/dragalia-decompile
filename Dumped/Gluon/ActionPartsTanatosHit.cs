using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsTanatosHit : ActionPartsHit
	{
		private readonly TanatosHitData _partsData;

		private bool _hitFlag;

		private int _difficultyIndex;

		public ActionPartsTanatosHit(Gluon.ActionData.ActionParts resource, long resourceId)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
