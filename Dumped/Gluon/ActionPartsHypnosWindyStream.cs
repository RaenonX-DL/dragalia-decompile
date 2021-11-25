using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsHypnosWindyStream : ActionParts
	{
		private enum State
		{
			Ready,
			Wait,
			Attack
		}

		private readonly HypnosWindyStreamData _partsData;

		private State _state;

		private EnemyCharacter _enemy;

		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		private float _waiting;

		private int _powerNum;

		private int _checkChildID;

		public ActionPartsHypnosWindyStream(Gluon.ActionData.ActionParts resource)
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

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
