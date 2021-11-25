using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Dungeon;
using Gluon.EnemyDef;
using UnityEngine;
using UnityEngine.AI;

namespace Gluon
{
	public class EnemyCtrl : FastUpdateMonoBehaviour
	{
		public enum eCtrlState
		{
			none,
			standby,
			battle,
			goHome,
			route
		}

		private enum eActionState
		{
			none,
			move,
			rotate,
			action
		}

		private List<AttackData> _attackList;

		private int _seledtedAttackIndex;

		private AIScript _aiScript;

		private float _actionBehavirSec;

		private eCtrlState _ctrlState;

		private bool _isTerritory;

		private Rect _territoryArea;

		private EnemyCtrlChecker _checker;

		private StateMachine<EnemyCtrl> _stateMachine;

		private static readonly string[] _actionStateNames;

		private eActionState _actionState;

		private AIScriptDef.eMoveAction _moveAction;

		private float _moveDistance;

		private Vector3 _moveGoalOffset;

		private AIScriptDef.eTurnAction _turnAction;

		private int _actionId;

		private float _approchElapsedSec;

		private const float APPROCH_UPDATE_TIME = 0.5f;

		private float _actionDurationSec;

		private const float ACTION_DURATION_TIME = 3f;

		private float _turnLength;

		private const float TURN_ANGLE_LIMIT = 360f;

		private bool isAlternativeTarget;

		private float _intervalElapsedSec;

		private const float INTERVAL_UPDATE_TIME = 1f;

		private EnemyRouteMode _routeMode;

		private bool _hasPlayedDissolution;

		private SortedList<float, CharacterSelector> _listOrder;

		public int _id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EnemyCharacter character
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public NavMeshAgent navMeshAgent => null;

		public float PopedElapsedSec
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsOrderAction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsActionBehavir => default(bool);

		public eCtrlState ctrlState => default(eCtrlState);

		public bool isValid => default(bool);

		public bool isStandby => default(bool);

		public bool isAwake => default(bool);

		public bool isForcedExit
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isAlive => default(bool);

		public EnemySearchLink _searchLink
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

		public AIScriptDef.eMoveAction moveAction => default(AIScriptDef.eMoveAction);

		public AIScriptDef.eTurnAction turnAction => default(AIScriptDef.eTurnAction);

		public int actionID => default(int);

		public EnemyRouteMode routeMode => null;

		public List<CharacterSelector> registeredTargetList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public DateTime LastInvalidateTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPauseAI
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool EnabledAiScript
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void EnableNavMeshAgent(bool sw)
		{
		}

		public bool IsActiveAIAction()
		{
			return default(bool);
		}

		public bool IsAttackedAction()
		{
			return default(bool);
		}

		public static EnemyCtrl Generate(int id, int paramId, bool ai, int generatorId = -1)
		{
			return null;
		}

		private void Initialize(int id, int paramId, bool ai)
		{
		}

		public void InitializeParts(int id)
		{
		}

		public void SetTerritory(bool sw, Rect rect)
		{
		}

		public void SetSearchLink(EnemySearchLink link, float searchRange)
		{
		}

		public void Invalidate(bool visible = false)
		{
		}

		public void ActiveState()
		{
		}

		public void ResetState()
		{
		}

		public void SetAwake()
		{
		}

		public bool Revive(bool hasInvincibleTime = true)
		{
			return default(bool);
		}

		public bool IsActiveAI()
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		private bool UpdateCharacterState()
		{
			return default(bool);
		}

		public void Leave()
		{
		}

		private void UpdateBattle()
		{
		}

		protected void UpdateAI()
		{
		}

		private void UpdateAiScript()
		{
		}

		private bool IsOutTerritory()
		{
			return default(bool);
		}

		private void StartGoHome()
		{
		}

		private void UpdateGoHome()
		{
		}

		private bool StartMove()
		{
			return default(bool);
		}

		private bool StartTurn()
		{
			return default(bool);
		}

		private bool GetActionTurnTarget(out Vector3 targetPos)
		{
			return default(bool);
		}

		private bool StartAction()
		{
			return default(bool);
		}

		public void CancelAction()
		{
		}

		private bool ValidActionTarget()
		{
			return default(bool);
		}

		public void SetActionTarget(ActionTarget target, ActionTarget targetSub = ActionTarget.NONE)
		{
		}

		public void SetAIMoveAction(int type, Vector3 offset, float moveDist = 0f)
		{
		}

		public void SetAITurnAction(int type)
		{
		}

		public void SetAIAction(int actionId)
		{
		}

		public void RegisterOrderCloser()
		{
		}

		public void RegisterOrderAliveFarther()
		{
		}

		public AttackData GetSelectedAttackData()
		{
			return null;
		}

		public void SetupAIHost(EnemyEventReceiver receiver, bool isSolo)
		{
		}

		public void ResetAIAwakeTime()
		{
		}

		public void ResetAIValue()
		{
		}

		public void CreateRouteMode(List<DungeonPathLine> path_list, List<EnemyCtrl> squad, float steppingTime)
		{
		}

		private bool IntervalNoActionCharacter()
		{
			return default(bool);
		}

		public void RequestUpdateAI()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
