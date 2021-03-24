/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Dungeon;
using Gluon.EnemyDef;
using UnityEngine;
using UnityEngine.AI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private int __id_k__BackingField;
		[CompilerGenerated]
		private EnemyCharacter _character_k__BackingField;
		private List<AttackData> _attackList;
		private int _seledtedAttackIndex;
		private AIScript _aiScript;
		[CompilerGenerated]
		private float _PopedElapsedSec_k__BackingField;
		[CompilerGenerated]
		private bool _IsOrderAction_k__BackingField;
		private float _actionBehavirSec;
		private eCtrlState _ctrlState;
		[CompilerGenerated]
		private bool _isForcedExit_k__BackingField;
		private bool _isTerritory;
		private Rect _territoryArea;
		private EnemyCtrlChecker _checker;
		[CompilerGenerated]
		private EnemySearchLink __searchLink_k__BackingField;
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
		[CompilerGenerated]
		private readonly List<CharacterSelector> _registeredTargetList_k__BackingField;
		[CompilerGenerated]
		private DateTime _LastInvalidateTime_k__BackingField;
		[CompilerGenerated]
		private bool _isPauseAI_k__BackingField;
		[CompilerGenerated]
		private bool _EnabledAiScript_k__BackingField;
		private SortedList<float, CharacterSelector> _listOrder;
	
		// Properties
		public int _id { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EnemyCharacter character { [CompilerGenerated] get; [CompilerGenerated] set; }
		public NavMeshAgent navMeshAgent { get; }
		public float PopedElapsedSec { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsOrderAction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsActionBehavir { get; }
		public eCtrlState ctrlState { get; }
		public bool isValid { get; }
		public bool isStandby { get; }
		public bool isAwake { get; }
		public bool isForcedExit { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAlive { get; }
		public EnemySearchLink _searchLink { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AIScriptDef.eMoveAction moveAction { get; }
		public AIScriptDef.eTurnAction turnAction { get; }
		public int actionID { get; }
		public EnemyRouteMode routeMode { get; }
		public List<CharacterSelector> registeredTargetList { [CompilerGenerated] get; }
		public DateTime LastInvalidateTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isPauseAI { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool EnabledAiScript { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum eCtrlState
		{
			none = 0,
			standby = 1,
			battle = 2,
			goHome = 3,
			route = 4
		}
	
		private enum eActionState
		{
			none = 0,
			move = 1,
			rotate = 2,
			action = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0
		{
			// Fields
			public EnemyCtrl __4__this;
			public string aiFileName;
			public EnemyEventReceiver receiver;
	
			// Constructors
			public __c__DisplayClass127_0();
	
			// Methods
			internal void _SetupAIHost_b__0();
		}
	
		// Constructors
		public EnemyCtrl();
		static EnemyCtrl();
	
		// Methods
		private void EnableNavMeshAgent(bool sw);
		public bool IsActiveAIAction();
		public bool IsAttackedAction();
		public static EnemyCtrl Generate(int id, int paramId, bool ai, int generatorId = -1);
		private void Initialize(int id, int paramId, bool ai);
		public void InitializeParts(int id);
		public void SetTerritory(bool sw, Rect rect);
		public void SetSearchLink(EnemySearchLink link, float searchRange);
		public void Invalidate(bool visible = false);
		public void ActiveState();
		public void ResetState();
		public void SetAwake();
		public bool Revive(bool hasInvincibleTime = true);
		public bool IsActiveAI();
		public override void FastUpdate();
		private bool UpdateCharacterState();
		public void Leave();
		private void UpdateBattle();
		protected void UpdateAI();
		private void UpdateAiScript();
		private bool IsOutTerritory();
		private void StartGoHome();
		private void UpdateGoHome();
		private bool StartMove();
		private bool StartTurn();
		private bool GetActionTurnTarget(out Vector3 targetPos);
		private bool StartAction();
		public void CancelAction();
		private bool ValidActionTarget();
		public void SetActionTarget(ActionTarget target, ActionTarget targetSub = ActionTarget.NONE);
		public void SetAIMoveAction(int type, Vector3 offset, float moveDist = 0f);
		public void SetAITurnAction(int type);
		public void SetAIAction(int actionId);
		public void RegisterOrderCloser();
		public void RegisterOrderAliveFarther();
		public AttackData GetSelectedAttackData();
		public void SetupAIHost(EnemyEventReceiver receiver, bool isSolo);
		public void ResetAIAwakeTime();
		public void ResetAIValue();
		public void CreateRouteMode(List<DungeonPathLine> path_list, List<EnemyCtrl> squad, float steppingTime);
		private bool IntervalNoActionCharacter();
		public void RequestUpdateAI();
		private void OnDestroy();
	}
}
