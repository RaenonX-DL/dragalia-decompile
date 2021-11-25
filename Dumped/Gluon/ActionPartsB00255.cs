using System.Collections.Generic;
using Cute.Cri;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsB00255 : ActionParts
	{
		private enum State
		{
			idle,
			expansion,
			expansionBeam,
			rolling,
			convergence
		}

		private class OptionCtrl
		{
			public CharacterBase chara;

			public ActionMove actMove;

			public EffectObject beamEffect;

			public EffectObject effectObject;

			public Vector3 dir;

			public CollisionHitAttribute hitAttribute;

			public Vector3 GetBeamBasePos(CharacterBase owner)
			{
				return default(Vector3);
			}
		}

		private readonly B00255Data _partsData;

		private const float BEAM_EXPAN_SEC = 0.15f;

		private const float HIT_EXCEPTION_SEC = 1f;

		private State _state;

		private StoneSatelliteUniqueCtrl _ctrl;

		private HitException _hitException;

		private List<OptionCtrl> _options;

		private float _elapsedSec;

		private float _beamExpanSec;

		private float _rollingSec;

		private EffectObject _ringEffect;

		private AudioPlayback _rollingSeHandle;

		private int _effTrig;

		public ActionPartsB00255(Gluon.ActionData.ActionParts resource)
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

		public override void RemoveSelf()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
