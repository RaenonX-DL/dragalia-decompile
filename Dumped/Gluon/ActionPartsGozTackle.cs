using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsGozTackle : ActionParts
	{
		public enum State
		{
			Idle,
			Targeting,
			PostTargeting,
			Aim,
			Wait,
			BeginTackle,
			Move,
			EndTackle,
			ReturnCenter,
			PostReturn,
			CrashRock,
			End
		}

		private readonly GozTackleData _partsData;

		private State _state;

		private List<CharacterBase> _listTarget;

		private CharacterBase _currentTarget;

		private const float TARGET_SYNC_TIME = 2f;

		private float _timer;

		private ActionMove _move;

		private float _moveDuration;

		private int _moveProperty;

		private CollisionHitAttribute _hitAttr;

		protected HitException _hitException;

		private ChargeMarker _marker;

		private float _markerDuration;

		private int _targetingCnt;

		public ActionPartsGozTackle(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		public override void Initialize(CharacterBase chara)
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

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		private void ProcTargeting()
		{
		}

		private void ProcPostTargeting()
		{
		}

		private void ProcAim()
		{
		}

		private void ProcBeginTackle()
		{
		}

		private void ProcMove(float delta)
		{
		}

		private void ProcEndTackle()
		{
		}

		private void ProcReturnCenter()
		{
		}

		private void ProcPostReturn()
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		private void ProcCrashRock()
		{
		}

		private void CreateTargetList()
		{
		}

		private void CreateMarker()
		{
		}

		private void ProcClear()
		{
		}
	}
}
