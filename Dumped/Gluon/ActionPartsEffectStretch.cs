using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsEffectStretch : ActionParts
	{
		private enum State
		{
			Init,
			Update
		}

		private readonly EffectStretchData _partsData;

		private State _state;

		private EffectObject _effectObject;

		private float _elapsedSec;

		private float _stretchSec;

		private Vector3 _targetPos;

		private Transform startTransform;

		private Vector3 startPosForNullEffectObject;

		public ActionPartsEffectStretch(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void CalcStartTransfrom(out Vector3 pos, out Vector3 scale)
		{
		}

		private Vector3 CalcTargetPos(Vector3 startPos)
		{
			return default(Vector3);
		}
	}
}
