/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.AI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyRouteMode
	{
		// Fields
		private State _state;
		private bool _state1st;
		[CompilerGenerated]
		private EnemyCharacter _owner_k__BackingField;
		[CompilerGenerated]
		private EnemyRouteModeElement _data_k__BackingField;
		private List<DungeonPathLine> _pathList;
		private DungeonPathLine.PathPoint _currentPathPoint;
		private Vector3 _lastPassedPathPoint;
		private Vector3 _popedPosition;
		private Vector3 _backPoint;
		private float _steppingTime;
		private float _timer;
		private float _speed;
		[CompilerGenerated]
		private bool _hasStart_k__BackingField;
		[CompilerGenerated]
		private bool _hasGoal_k__BackingField;
		[CompilerGenerated]
		private bool _hasReact_k__BackingField;
		[CompilerGenerated]
		private bool _hasStopAi_k__BackingField;
		private List<EnemyCtrl> _squadMembers;
		[CompilerGenerated]
		private int _squadIdx_k__BackingField;
		private const float FOLLOW_DISTANCE = 1f;
		private const float FOLLOW_ANGLE = 1.5707964f;
		private Vector3 _followPoint;
		private float _sqrStoppingDistance;
		private List<CharacterSpecialState> _recvEventQueue;
		private int _searchTimingCnt;
		private int _resetCount;
	
		// Properties
		public State state { get; private set; }
		protected EnemyCharacter owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public NavMeshAgent agent { get; }
		public EnemyRouteModeElement data { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasStart { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasGoal { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasReact { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasStopAi { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DungeonPathLine.PathPoint currentPathPoint { get; }
		public int squadIdx { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum State
		{
			Ready = 0,
			Stepping = 1,
			Idle = 2,
			Move = 3,
			Arrival = 4,
			BackTo = 5,
			Goal = 6,
			EmergencyMove = 7
		}
	
		// Constructors
		public EnemyRouteMode(EnemyCharacter owner_, List<DungeonPathLine> path_list, float steppingTime);
	
		// Methods
		public void Reset();
		public void Start();
		public bool Restart();
		public bool Update();
		private void ProcReady();
		private void ProcStepping(ref bool ret);
		private void ProcIdle();
		private void ProcMove(ref bool ret);
		private void ProcArrival();
		private void ProcGoal(ref bool ret);
		private void ProcBackTo();
		private void ProcEmergencyMove(ref bool ret);
		private void EnableAgent(bool sw);
		private bool SetDestination(Vector3 position, bool not_follow = false);
		private bool Search();
		private void SwicthBattleMode();
		public bool IsOutRange();
		public void SetupSquad(List<EnemyCtrl> squad);
		public void UnsetSquad();
		private void SetupUI();
		private void StartUI();
		public float GetPathLengthCurrentPositionToEnd();
		private float GetSqrRemainingDistance();
		private void SendArrival();
		public void OnArrival(CharacterSpecialState recvEvent);
	}
}
