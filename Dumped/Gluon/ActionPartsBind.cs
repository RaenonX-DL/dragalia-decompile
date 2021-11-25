using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsBind : ActionParts
	{
		public enum BindType
		{
			There,
			Owner,
			OwnerNode,
			ThereGround
		}

		private readonly BindData _partsData;

		private CharacterBase _target;

		private CharacterBase _targetOriginal;

		private Transform _attachNode;

		private Quaternion _preRotation;

		private bool _success;

		public ActionPartsBind(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		private void Bind(bool on)
		{
		}

		private void SetTargetPosition()
		{
		}
	}
}
