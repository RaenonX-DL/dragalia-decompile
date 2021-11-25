using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsVolcano : ActionParts
	{
		private enum State
		{
			Ready,
			Charge,
			Freeze,
			Freezing,
			Thaw,
			Explosion,
			End
		}

		private readonly VolcanoData _partsData;

		private State _state;

		private float _chargeTime;

		private EnemyCharacter _enemy;

		protected ChargeMarker _marker;

		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		protected EffectObject _attachEffect;

		protected EffectObject _explosionEffect;

		private float _preSpeedScale;

		public ActionPartsVolcano(Gluon.ActionData.ActionParts resource)
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

		private void Explosion()
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
