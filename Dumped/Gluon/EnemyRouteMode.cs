using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.AI;

namespace Gluon
{
	public class EnemyRouteMode
	{
		public enum State
		{
			Ready,
			Stepping,
			Idle,
			Move,
			Arrival,
			BackTo,
			Goal,
			EmergencyMove
		}

		private State _state;

		private bool _state1st;

		private List<DungeonPathLine> _pathList;

		private DungeonPathLine.PathPoint _currentPathPoint;

		private Vector3 _lastPassedPathPoint;

		private Vector3 _popedPosition;

		private Vector3 _backPoint;

		private float _steppingTime;

		private float _timer;

		private float _speed;

		private List<EnemyCtrl> _squadMembers;

		private const float FOLLOW_DISTANCE = 1f;

		private const float FOLLOW_ANGLE = (float)Math.PI / 2f;

		private Vector3 _followPoint;

		private float _sqrStoppingDistance;

		private List<CharacterSpecialState> _recvEventQueue;

		private int _searchTimingCnt;

		private int _resetCount;

		public State state
		{
			get
			{
				return default(State);
			}
			private set
			{
			}
		}

		protected EnemyCharacter owner
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

		public NavMeshAgent agent => null;

		public EnemyRouteModeElement data
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

		public bool hasStart
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

		public bool hasGoal
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

		public bool hasReact
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

		public bool hasStopAi
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

		public DungeonPathLine.PathPoint currentPathPoint => null;

		public int squadIdx
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EnemyRouteMode(EnemyCharacter owner_, List<DungeonPathLine> path_list, float steppingTime)
		{
		}

		public void Reset()
		{
		}

		public void Start()
		{
		}

		public bool Restart()
		{
			return default(bool);
		}

		public bool Update()
		{
			return default(bool);
		}

		private void ProcReady()
		{
		}

		private void ProcStepping(ref bool ret)
		{
		}

		private void ProcIdle()
		{
		}

		private void ProcMove(ref bool ret)
		{
		}

		private void ProcArrival()
		{
		}

		private void ProcGoal(ref bool ret)
		{
		}

		private void ProcBackTo()
		{
		}

		private void ProcEmergencyMove(ref bool ret)
		{
		}

		private void EnableAgent(bool sw)
		{
		}

		private bool SetDestination(Vector3 position, bool not_follow = false)
		{
			return default(bool);
		}

		private bool Search()
		{
			return default(bool);
		}

		private void SwicthBattleMode()
		{
		}

		public bool IsOutRange()
		{
			return default(bool);
		}

		public void SetupSquad(List<EnemyCtrl> squad)
		{
		}

		public void UnsetSquad()
		{
		}

		private void SetupUI()
		{
		}

		private void StartUI()
		{
		}

		public float GetPathLengthCurrentPositionToEnd()
		{
			return default(float);
		}

		private float GetSqrRemainingDistance()
		{
			return default(float);
		}

		private void SendArrival()
		{
		}

		public void OnArrival(CharacterSpecialState recvEvent)
		{
		}
	}
}
