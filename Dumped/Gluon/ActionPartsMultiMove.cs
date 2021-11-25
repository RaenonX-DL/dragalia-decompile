using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsMultiMove : ActionParts
	{
		public enum TargetType
		{
			FixedPosition
		}

		public enum BaseType
		{
			AreaAnchor,
			Owner
		}

		public enum State
		{
			Idle,
			Turn,
			BeginMove,
			Move,
			EndMove,
			Wait,
			End
		}

		private readonly MultiMoveData _partsData;

		private State _state;

		private List<Vector3> _listTarget;

		private int _targetingCnt;

		private float _timer;

		private ActionMove _move;

		private int _moveProperty;

		private Vector3 _preForward;

		public ActionPartsMultiMove(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		private void ProcClear()
		{
		}

		protected override void OnStart()
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

		private void ProcTurn()
		{
		}

		private void ProcBeginMove()
		{
		}

		private void ProcMove(float delta)
		{
		}

		private void ProcEndMove()
		{
		}

		private void CreateTargetList()
		{
		}
	}
}
