using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsThunder : ActionParts
	{
		private enum State
		{
			MarkerSet,
			MarkerRun,
			Fire,
			DamageField,
			End
		}

		private readonly ThunderData _partsData;

		private State _state;

		private const int THUNDER_MAX = 4;

		private List<CommonObjectStatus> _targetList;

		private ChargeMarker[] _markers;

		private float _elapsed;

		public ActionPartsThunder(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void State_MarkerSet()
		{
		}

		private void State_MarkerRun(float delta)
		{
		}

		private void State_Fire()
		{
		}

		private void State_DamageField()
		{
		}

		private void State_End()
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		private void PlayEffect(GameObject target)
		{
		}

		private void CreateHitAttribute(ref CollisionHitAttribute hitAttr)
		{
		}
	}
}
