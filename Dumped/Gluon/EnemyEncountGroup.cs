using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class EnemyEncountGroup : MonoBehaviour
	{
		[SerializeField]
		private int _waveIndex;

		[SerializeField]
		private bool _isRandomPop;

		[SerializeField]
		public float _delayPopSec;

		[SerializeField]
		private GameObject _location;

		[SerializeField]
		private bool _isLoitering;

		[SerializeField]
		private bool _isLookNearest;

		[SerializeField]
		private bool _isSquadChief;

		[SerializeField]
		private bool _hideDropItemIcon;

		[SerializeField]
		private bool _isExtramural;

		[HideInInspector]
		public Vector3 _popLocation;

		[HideInInspector]
		public Quaternion _popRotate;

		private List<EnemyCtrl> _lstPopedEnemy;

		[NonSerialized]
		private EnemyEncountParam[] _encountParams;

		private UnityEvent _popEndEvents;

		private bool _isSendEvent;

		private bool _useEnemyObjectPool;

		private bool _activeFromPool;

		public int _groupId
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

		public List<EnemyCtrl> enemies
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int waveIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public void Initialize(int groupId, EnemySearchLink searchLink, float searchRange, int generatorId, EnemyPopType popType, bool useEnemyObjectPool)
		{
		}

		public int SetGenerateCountScale(int mulNum, int divNum)
		{
			return default(int);
		}

		private int GetActiveEnemyCount()
		{
			return default(int);
		}

		public EnemyCtrl[] CreateWavePopEnemies(int popWaveIndex, int limitPopNum, bool isPopEffect, bool enableAutoDelayPop, EnemyCharacter.CallMinionInfo callMinionInfo, RandomXorshift random, bool overrideLimit)
		{
			return null;
		}

		private IEnumerator PopEnemies(EnemyCtrl[] enemies, float delay, bool isPopEffect = false)
		{
			return null;
		}

		public List<EnemyCtrl> CreateWaveRePopEnemies(int popWaveIndex, EnemyCharacter.CallMinionInfo callMinionInfo, int generatorId, int limitCount = -1, bool overrideLimitFlag = false)
		{
			return null;
		}

		public EnemyCtrl[] PopFromEnemyObjectPool(int popWaveIndex, EnemyPopType popType, bool isPopEffect = false, bool enableAutoDelayPop = true, [Optional] EnemyCharacter.CallMinionInfo callMinionInfo, [Optional] EnemySearchLink searchLink, float searchRange = 0f, int generatorId = -1, [Optional] RandomXorshift random)
		{
			return null;
		}

		private void RepopFromEnemyObjectPool(ref List<EnemyCtrl> repopEnemies, int generatorId = -1)
		{
		}

		public bool IsPopWave(int popWaveIndex)
		{
			return default(bool);
		}

		public void AddPopEndEvent(UnityAction eventFunc)
		{
		}

		public bool IsEnemiesDeadAll()
		{
			return default(bool);
		}

		public bool CheckEnemies(int waveIndex)
		{
			return default(bool);
		}

		private bool RepositioningMinion(EnemyCharacter.CallMinionInfo info, int minion_idx, EnemyCtrl minion)
		{
			return default(bool);
		}

		private bool RepositioningMinion(EnemyCharacter.CallMinionInfo info, int minion_idx)
		{
			return default(bool);
		}

		public EnemyCtrl[] CreateGameMaster()
		{
			return null;
		}

		private void ProcCallByGameMaster(EnemyCharacter poped, EnemyCharacter caller)
		{
		}

		public void GetDownloadEnemyParams(List<int> enemyParams, ref int tmpEnemyCount)
		{
		}
	}
}
