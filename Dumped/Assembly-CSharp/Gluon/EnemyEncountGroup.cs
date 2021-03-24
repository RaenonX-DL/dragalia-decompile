/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	public class EnemyEncountGroup : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private int _waveIndex;
		[SerializeField]
		private bool _isRandomPop;
		[Range]
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
		[CompilerGenerated]
		private int __groupId_k__BackingField;
		[HideInInspector]
		public Vector3 _popLocation;
		[HideInInspector]
		public Quaternion _popRotate;
		[CompilerGenerated]
		private readonly List<EnemyCtrl> _enemies_k__BackingField;
		private List<EnemyCtrl> _lstPopedEnemy;
		[NonSerialized]
		private EnemyEncountParam[] _encountParams;
		private UnityEvent _popEndEvents;
		private bool _isSendEvent;
		private bool _useEnemyObjectPool;
		private bool _activeFromPool;
	
		// Properties
		public int _groupId { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public List<EnemyCtrl> enemies { [CompilerGenerated] get; }
		public int waveIndex { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<EnemyCtrl> __9__27_0;
			public static Func<bool> __9__29_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Initialize_b__27_0(EnemyCtrl x);
			internal bool _PopEnemies_b__29_0();
		}
	
		[CompilerGenerated]
		private sealed class _PopEnemies_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public bool isPopEffect;
			public EnemyCtrl[] enemies;
			public EnemyEncountGroup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PopEnemies_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EnemyEncountGroup();
	
		// Methods
		public void Initialize(int groupId, EnemySearchLink searchLink, float searchRange, int generatorId, EnemyPopType popType, bool useEnemyObjectPool);
		public EnemyCtrl[] CreateWavePopEnemies(int popWaveIndex, int limitPopNum = 0, bool isPopEffect = false, bool enableAutoDelayPop = true, EnemyCharacter.CallMinionInfo callMinionInfo = null);
		[IteratorStateMachine]
		private IEnumerator PopEnemies(EnemyCtrl[] enemies, float delay, bool isPopEffect = false);
		public EnemyCtrl[] CreateWaveRePopEnemies(int popWaveIndex, EnemyCharacter.CallMinionInfo callMinionInfo = null, int generatorId = -1);
		public EnemyCtrl[] PopFromEnemyObjectPool(int popWaveIndex, EnemyPopType popType, bool isPopEffect = false, bool enableAutoDelayPop = true, EnemyCharacter.CallMinionInfo callMinionInfo = null, EnemySearchLink searchLink = null, float searchRange = 0f, int generatorId = -1);
		private void RepopFromEnemyObjectPool(ref List<EnemyCtrl> repopEnemies, int generatorId = -1);
		public bool IsPopWave(int popWaveIndex);
		public void AddPopEndEvent(UnityAction eventFunc);
		public bool IsEnemiesDeadAll();
		public bool CheckEnemies(int waveIndex);
		private bool RepositioningMinion(EnemyCharacter.CallMinionInfo info, int minion_idx);
		public EnemyCtrl[] CreateGameMaster();
		private void ProcCallByGameMaster(EnemyCharacter poped, EnemyCharacter caller);
		public void GetDownloadEnemyParams(List<int> enemyParams, ref int tmpEnemyCount);
	}
}
