using System.Collections.Generic;

namespace Gluon
{
	public class ClawJailUniqueCtrl : EnemyUniqueCtrl
	{
		public class MultiPlayWaitingList
		{
			private List<int> _actorIds;

			public void StartWaitForAllOthers()
			{
			}

			public void Update()
			{
			}

			public void RemoveActor(int actorId)
			{
			}

			public bool IsWaitingForActor(int actorId)
			{
				return default(bool);
			}

			public bool IsWaitingForAny()
			{
				return default(bool);
			}
		}

		private enum _State
		{
			None,
			WaitForBindResult,
			CatchChara,
			Destruct,
			CheckFinishDestruct
		}

		private float _catchRange;

		private string _destructMotion;

		private _State _state;

		private MultiPlayWaitingList _waitingList;

		public void StartTask(int actionId, short actionPartsIndex)
		{
		}

		public bool IsTaskCompleted()
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		public void OnDead()
		{
		}

		private void _UpdateTask()
		{
		}

		private CharacterBase[] _CollectBindTargets()
		{
			return null;
		}

		private void _ApplyBind(CharacterBase[] targets)
		{
		}

		private bool _CheckDestroy()
		{
			return default(bool);
		}

		private void _Destoy()
		{
		}

		private void _SendBindResultEvent(CharacterBase[] targets, int actionId, short actionPartsIndex)
		{
		}

		private void _UpdateRecvBindResult()
		{
		}
	}
}
