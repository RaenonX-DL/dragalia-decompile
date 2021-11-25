using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using Gluon.Dungeon;
using Gluon.Dungeon.Gimmick;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class EnemyGenerator : FastUpdateMonoBehaviour
	{
		public enum InfinityType
		{
			None,
			DeadTarget,
			DeadEnemyCount,
			DurationTime,
			Summon
		}

		public enum OverrideRepopTriggerNumType
		{
			None,
			Time
		}

		[Serializable]
		public class OverrideRepopTriggerNumDataForTime
		{
			[SerializeField]
			public float waitSec;

			[SerializeField]
			public Vector2Int enemyNumScale;
		}

		public enum eState
		{
			none,
			standby,
			active,
			clear
		}

		[SerializeField]
		public bool _useEnemyObjectPool;

		[SerializeField]
		public EnemyPopType _popType;

		[SerializeField]
		public GameObject _popStateObj;

		[SerializeField]
		public bool _rebootRootGeneratorWhenFinished;

		public EnemyGenerator _rebootGenerator;

		[SerializeField]
		public int _hpRate;

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

		[FormerlySerializedAs("_overrideLRepopTriggerNumType")]
		public OverrideRepopTriggerNumType _overrideRepopTriggerNumType;

		[SerializeField]
		public int _limitPopNum;

		[SerializeField]
		public List<OverrideRepopTriggerNumDataForTime> _overrideRepopTriggerNumDataForTimeList;

		private int _repopTriggerNumListIndex;

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

		public bool useEnemyObjectPool => default(bool);

		public int _generatorId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public void SetRebootGenerator(EnemyGenerator tempGen)
		{
		}

		public int GetGenerateCountMax(int num)
		{
			return default(int);
		}

		public void Start()
		{
		}

		public void Initialize(int generatorId)
		{
		}

		public void GetDownloadEnemyParams(List<int> enemyParams, ref int tmpEnemyCount)
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateStanby()
		{
		}

		private bool IsEnableOverrideRepopTriggerNum()
		{
			return default(bool);
		}

		private void UpdateActive()
		{
		}

		private void OnTriggerEnter(Collider col)
		{
		}

		public bool IsEnemiesDeadAll()
		{
			return default(bool);
		}

		public void CreateWavePopEnemies(bool isPopEffect = false, [Optional] EnemyCharacter.CallMinionInfo callMinionInfo, [Optional] RandomXorshift random)
		{
		}

		public Rect GetTerritoryArea()
		{
			return default(Rect);
		}

		public void SetupEnemyCtrl(EnemyCtrl targetCtrl, Rect targetArea)
		{
		}

		public void RebootGenerator()
		{
		}

		public IEnumerator CoRebootGenerator()
		{
			return null;
		}

		private IEnumerator DelayWaveStartEffect(int waveCnt, int maxWaveIndex, float delay)
		{
			return null;
		}

		public bool CreateWaveRePopEnemies([Optional] EnemyCharacter.CallMinionInfo callMinionInfo)
		{
			return default(bool);
		}

		public void OnEventPopEnemyDeadWall(EnemyCharacter deadEnemy)
		{
		}

		public void OnEventPopWaveEnemies([Optional] EnemyCharacter deadEnemy)
		{
		}

		private bool IsInfinityRepop()
		{
			return default(bool);
		}

		private int GetAliveEnemiesNum()
		{
			return default(int);
		}

		private int GetValidEnemiesNum()
		{
			return default(int);
		}

		public int GetNotInvincibleEnemiesNum()
		{
			return default(int);
		}

		private void CheckCallMinion()
		{
		}

		private void PopCallMinion(EnemyCharacter owner, bool firsttime)
		{
		}

		public void SetSearchLinkAwakeDisable()
		{
		}

		public void SetSearchLinkAwakeAll()
		{
		}

		public void CreateGameMaster()
		{
		}
	}
}
