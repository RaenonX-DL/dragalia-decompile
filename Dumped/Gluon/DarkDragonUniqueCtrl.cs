using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class DarkDragonUniqueCtrl : EnemyUniqueCtrl
	{
		private enum _State
		{
			None,
			MarkerCreated,
			Completed
		}

		private class _TaskInfo
		{
			public int _taskId;

			public int _actionId;

			public int _actionPartsIndex;

			public MarkerData _markerData;

			public int _catchActionId;

			public CharacterBase _targetChara;

			public CommonObjectStatus _targetForCharageMarker;

			public ChargeMarker _marker;

			public EnemyCtrl _clawEnemy;

			public _State _state;
		}

		private int _nextTaskId;

		private float _tempoScale;

		private List<_TaskInfo> _taskList;

		private GameObject _dummyObjectForChargeMarker;

		private CommonObjectStatus _dummyObjectForChargeStatus;

		private MarkerData markerData;

		public List<EnemyCharacter> enemyObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void Initialize()
		{
		}

		public int StartTask(int actionId, int actionPartsIndex, CharacterBase targetCharacter, float tempoScale = 1f)
		{
			return default(int);
		}

		public bool IsTaskCompleted(int taskId)
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		public List<CharacterBase> CollectTargetCharacter()
		{
			return null;
		}

		private void _UpdateTask(_TaskInfo task)
		{
		}

		private EnemyCtrl _GetChildEnemy()
		{
			return null;
		}

		private bool _CreateMarker(_TaskInfo task)
		{
			return default(bool);
		}
	}
}
