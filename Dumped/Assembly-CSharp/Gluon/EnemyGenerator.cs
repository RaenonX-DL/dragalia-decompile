/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Dungeon;
using Gluon.Dungeon.Gimmick;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	public class EnemyGenerator : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		public bool _useEnemyObjectPool;
		[SerializeField]
		public EnemyPopType _popType;
		[SerializeField]
		public GameObject _popStateObj;
		[SerializeField]
		public bool _rebootRootGeneratorWhenFinished;
		public EnemyGenerator _rebootGenerator;
		[Range]
		[SerializeField]
		public int _hpRate;
		[Range]
		[SerializeField]
		public int _odRate;
		[SerializeField]
		public int _summonTrigger;
		[SerializeField]
		public string _minionLabel;
		[SerializeField]
		public DungeonManager.eStageDifficulty _difficultyLevel;
		[SerializeField]
		public bool _isImmediatedActive;
		[SerializeField]
		public float _searchRange;
		[NonSerialized]
		public const int NonMuitiSafeAction = -1;
		[Range]
		[SerializeField]
		public int _multiSafeActionNum;
		[SerializeField]
		public InfinityType _infinityType;
		[SerializeField]
		public int _infinityRepopToriggerNum;
		[SerializeField]
		public GameObject _infinityTarget;
		[SerializeField]
		public int _infinityValue;
		[SerializeField]
		private bool _isTerritory;
		[SerializeField]
		private Rect _territoryArea;
		[SerializeField]
		public bool _isWaveUIControl;
		[FormerlySerializedAs]
		public OverrideRepopTriggerNumType _overrideRepopTriggerNumType;
		[SerializeField]
		public int _limitPopNum;
		[SerializeField]
		public List<OverrideRepopTriggerNumDataForTime> _overrideRepopTriggerNumDataForTimeList;
		private int _repopTriggerNumListIndex;
		[CompilerGenerated]
		private int __generatorId_k__BackingField;
		[NonSerialized]
		private int _waveCnt;
		[NonSerialized]
		public UnityEvent _wallEvent;
		[NonSerialized]
		public UnityEvent _enemyPopEvent;
		[NonSerialized]
		public bool _isActive;
		[NonSerialized]
		private List<EnemyCtrl> _popEnemies;
		[NonSerialized]
		private EnemyEncountGroup[] _encountGroups;
		[NonSerialized]
		private eState _state;
		private DungeonObjectBase _dunObj;
		private EnemyEncountGroup[] _popTargetGroups;
		[NonSerialized]
		private EnemySearchLink _searchLink;
		private float _infinityElapsedSec;
		private int _infinityDeadCnt;
		private DungeonObjectBase _infinityDunObj;
		private bool _isInfinityEnd;
		public bool _ignoreClearAllEnemiesAtWaveChanging;
		private float _infinityRepopDelayNow;
		[SerializeField]
		private float _infinityRepopDelayMax;
		public int _maxWaveIndex;
		public List<DungeonPathLine> _pathLine;
		public float _steppingTime;
		public WarpRoom.RoomGroup _roomGroup;
		private Dictionary<int, List<EnemyCharacter>> bossEnemies;
		private RandomXorshift _randomForDelayPopSec;
		private List<EnemyCtrl> initializedEnemyCtrlList;
		private int generateGroupRotationIndex;
	
		// Properties
		public bool useEnemyObjectPool { get; }
		public int _generatorId { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum InfinityType
		{
			None = 0,
			DeadTarget = 1,
			DeadEnemyCount = 2,
			DurationTime = 3,
			Summon = 4
		}
	
		public enum OverrideRepopTriggerNumType
		{
			None = 0,
			Time = 1
		}
	
		[Serializable]
		public class OverrideRepopTriggerNumDataForTime
		{
			// Fields
			[SerializeField]
			public float waitSec;
			[SerializeField]
			public Vector2Int enemyNumScale;
	
			// Constructors
			public OverrideRepopTriggerNumDataForTime();
		}
	
		public enum eState
		{
			none = 0,
			standby = 1,
			active = 2,
			clear = 3
		}
	
		[CompilerGenerated]
		private sealed class _CoRebootGenerator_d__74 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EnemyGenerator __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoRebootGenerator_d__74(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DelayWaveStartEffect_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int waveCnt;
			public int maxWaveIndex;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayWaveStartEffect_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EnemyGenerator();
	
		// Methods
		public void SetRebootGenerator(EnemyGenerator tempGen);
		public int GetGenerateCountMax(int num);
		public void Start();
		public void Initialize(int generatorId);
		public void GetDownloadEnemyParams(List<int> enemyParams, ref int tmpEnemyCount);
		public override void FastUpdate();
		private void UpdateStanby();
		private bool IsEnableOverrideRepopTriggerNum();
		private void UpdateActive();
		private void OnTriggerEnter(Collider col);
		public bool IsEnemiesDeadAll();
		public void CreateWavePopEnemies(bool isPopEffect = false, EnemyCharacter.CallMinionInfo callMinionInfo = null, RandomXorshift random = null);
		public Rect GetTerritoryArea();
		public void SetupEnemyCtrl(EnemyCtrl targetCtrl, Rect targetArea);
		public void RebootGenerator();
		[IteratorStateMachine]
		public IEnumerator CoRebootGenerator();
		[IteratorStateMachine]
		private IEnumerator DelayWaveStartEffect(int waveCnt, int maxWaveIndex, float delay);
		public bool CreateWaveRePopEnemies(EnemyCharacter.CallMinionInfo callMinionInfo = null);
		public void OnEventPopEnemyDeadWall(EnemyCharacter deadEnemy);
		public void OnEventPopWaveEnemies(EnemyCharacter deadEnemy = null);
		private bool IsInfinityRepop();
		private int GetAliveEnemiesNum();
		private int GetValidEnemiesNum();
		public int GetNotInvincibleEnemiesNum();
		private void CheckCallMinion();
		private void PopCallMinion(EnemyCharacter owner, bool firsttime);
		public void SetSearchLinkAwakeDisable();
		public void SetSearchLinkAwakeAll();
		public void CreateGameMaster();
	}
}
