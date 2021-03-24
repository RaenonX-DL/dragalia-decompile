/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class EnemyEncountParam : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public int _enemyParam;
		[SerializeField]
		public int _rareEnemyGroup;
		[SerializeField]
		private float _popRadius;
		[SerializeField]
		private int _generateCount;
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
		[CompilerGenerated]
		private List<int> _serializedList_k__BackingField;
	
		// Properties
		public int enemyParam { get; }
		public int rareEnemyGroup { get; }
		public float popRadius { get; }
		public int generateCount { get; }
		public float popupRate { get; }
		public int popupLinkId { get; }
		public int isDefaultEnemy { get; }
		public EnemyCtrl[] enemies { get; }
		public GameObject AnchorObject { get; }
		public List<GameObject> exAnchorObjectList { get; set; }
		public List<int> serializedList { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public EnemyEncountParam();
	
		// Methods
		public GameObject GetNearestAnchorObject(Vector3 pos);
		public bool Initialize(EnemySearchLink link, float searchRange, int generatorId, EnemyPopType popType);
		public void InitializeForEnemyObjectPool();
		public void InitPosition(Vector3 basePos, Quaternion rot, bool isRandomPop);
		public void RepopEnemies(Vector3 basePos, ref List<EnemyCtrl> repopEnemies);
		private Vector3 GetPopPosition(int idx);
	}
}
