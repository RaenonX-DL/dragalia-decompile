using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class EnemyEncountParam : MonoBehaviour
	{
		[SerializeField]
		public int _enemyParam;

		[SerializeField]
		public int _rareEnemyGroup;

		[SerializeField]
		private float _popRadius;

		[SerializeField]
		private int _generateCount;

		private int _generateCountOriginal;

		[SerializeField]
		private float _popupRate;

		[SerializeField]
		private int _popupLinkId;

		[SerializeField]
		public int _isDefaultEnemy;

		[NonSerialized]
		private EnemyCtrl[] _enemies;

		[SerializeField]
		private GameObject _anchorObject;

		[SerializeField]
		private List<GameObject> _exAnchorObjectList;

		public int enemyParam => default(int);

		public int rareEnemyGroup => default(int);

		public float popRadius => default(float);

		public int generateCount => default(int);

		public int generateCountOriginal => default(int);

		public float popupRate => default(float);

		public int popupLinkId => default(int);

		public int isDefaultEnemy => default(int);

		public EnemyCtrl[] enemies => null;

		public GameObject AnchorObject => null;

		public List<GameObject> exAnchorObjectList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> serializedList
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

		public void SetGenerateCountScale(int mulNum, int divNum)
		{
		}

		public GameObject GetNearestAnchorObject(Vector3 pos)
		{
			return null;
		}

		public int GetMaxGenerateCount()
		{
			return default(int);
		}

		public bool Initialize(EnemySearchLink link, float searchRange, int generatorId, EnemyPopType popType)
		{
			return default(bool);
		}

		public void InitializeForEnemyObjectPool()
		{
		}

		public void InitPosition(Vector3 basePos, Quaternion rot, bool isRandomPop)
		{
		}

		public int RepopEnemies(Vector3 basePos, ref List<EnemyCtrl> repopEnemies)
		{
			return default(int);
		}

		public int RepopEnemies(Vector3 basePos, ref List<EnemyCtrl> repopEnemies, int limitCount)
		{
			return default(int);
		}

		private Vector3 GetPopPosition(int idx)
		{
			return default(Vector3);
		}
	}
}
