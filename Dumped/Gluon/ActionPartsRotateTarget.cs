using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsRotateTarget : ActionParts
	{
		private readonly RotateTargetData _partsData;

		private float _baseRot;

		private float _moveRot;

		private Vector3 targetPos;

		private CharacterBase _targetCharacter;

		private float _elapsedSec;

		public ActionPartsRotateTarget(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
