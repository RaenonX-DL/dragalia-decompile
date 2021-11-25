using System.Collections.Generic;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsB00254 : ActionParts
	{
		private enum State
		{
			init,
			delayAttack,
			hitCheck,
			retreat
		}

		private readonly B00254Data _partsData;

		private State _state;

		private List<ChargeMarker> _markers;

		private float _generateSec;

		private int _generateCnt;

		private float _forwardRot;

		private float _sectionRot;

		private CollisionHitAttribute _hitAttribute;

		protected HitException _hitException;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		public ActionPartsB00254(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private bool UpdateAttack(float delta)
		{
			return default(bool);
		}

		private bool UpdateRetreat()
		{
			return default(bool);
		}

		private void CreateMarker(float forwardRot)
		{
		}

		private CollisionHitAttribute CreateHitAttribute()
		{
			return null;
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
