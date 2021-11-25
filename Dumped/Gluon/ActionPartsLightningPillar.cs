using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsLightningPillar : ActionParts
	{
		private enum State
		{
			Charge,
			Ready,
			Wait,
			Attack
		}

		private readonly LightningPillarData _partsData;

		private State _state;

		private EnemyCharacter _enemy;

		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		private int _powerNum;

		private float _waiting;

		private float _cyclicTime;

		private bool _isSigned;

		public ActionPartsLightningPillar(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void CyclicHit()
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
