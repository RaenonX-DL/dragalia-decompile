/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DarkDragonUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		[CompilerGenerated]
		private List<EnemyCharacter> _enemyObject_k__BackingField;
		private int _nextTaskId;
		private float _tempoScale;
		private List<_TaskInfo> _taskList;
		private GameObject _dummyObjectForChargeMarker;
		private CommonObjectStatus _dummyObjectForChargeStatus;
		private MarkerData markerData;
	
		// Properties
		public List<EnemyCharacter> enemyObject { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum _State
		{
			None = 0,
			MarkerCreated = 1,
			Completed = 2
		}
	
		private class _TaskInfo
		{
			// Fields
			public int _taskId;
			public int _actionId;
			public int _actionPartsIndex;
			public MarkerData _markerData;
			public int _catchActionId;
			public CharacterBase _targetChara;
			public CommonObjectStatus _targetForCharageMarker;
			public ChargeMarker _marker;
			public EnemyCtrl _clawEnemy;
			public _State _state;
	
			// Constructors
			public _TaskInfo();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<_TaskInfo> __9__15_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _FastUpdate_b__15_0(_TaskInfo task);
		}
	
		// Constructors
		public DarkDragonUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public int StartTask(int actionId, int actionPartsIndex, CharacterBase targetCharacter, float tempoScale = 1f);
		public bool IsTaskCompleted(int taskId);
		public override void FastUpdate();
		public List<CharacterBase> CollectTargetCharacter();
		private void _UpdateTask(_TaskInfo task);
		private EnemyCtrl _GetChildEnemy();
		private bool _CreateMarker(_TaskInfo task);
	}
}
